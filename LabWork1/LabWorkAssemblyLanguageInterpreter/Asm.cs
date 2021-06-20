using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabWorkAssemblyLanguageInterpreter
{
    public class Asm
    {
        public List<string> Errors { get; private set; }
        public Dictionary<string, byte> Registers { get; private set; }
        private Dictionary<string, int> Marker { get; set; }

        public Asm()
        {
            Marker = new Dictionary<string, int>();
            Errors = new List<string>();
            Registers = Enumerable.Range(0, 16).ToDictionary(t => "r" + t, y => Byte.MinValue);
        }

        private (string[] lines, bool flag) CheckingForValidity(string str)
        {
            string[] lines = Regex.Split(Regex.Replace(str, "^[\r\n]+|[\r\n]+$", ""), "[\r\n]+");
            if (lines.Select(str => Regex.IsMatch(str, @"(^\w+ \w+$)|(^\w+ \w+,#{1}\w+$)|(^\w+ \w+,\w+)")).Contains(false)) return (null, false);
            return (lines, true);
        }

        public void Interpreter(string program)
        {
            var value = CheckingForValidity(program);
            if (!value.flag)
            {
                MessageBox.Show("Failed checking for validity.");
                return;
            }

            for (int commandCounter = 0; commandCounter < value.lines.Length; commandCounter++)
            {
                string[] token = Regex.Split(value.lines[commandCounter], @"[,\s]");

                switch (token[0].ToUpper())
                {
                    case "LD":
                        Ld(token);
                        break;
                    case "MOV":
                        Mov(token);
                        break;
                    case "ADD":
                        Add(token);
                        break;
                    case "SUB":
                        Sub(token);
                        break;
                    case "BR":
                        Br(token, ref commandCounter);
                        break;
                    case "BRGZ":
                        Brgz(token, ref commandCounter);
                        break;
                    case "METKA":
                        Metka(token, ref commandCounter);
                        break;
                    default:
                        MessageBox.Show("This command does not exist");
                        return;
                }

                if (Errors.Any())
                {
                    MessageBox.Show(String.Join("\n", Errors));
                    break;
                }
            }
        }

        private void Metka(string[] tokens, ref int commandCounter)
        {
            if (tokens.Length == 2 && !Marker.ContainsKey(tokens[1]))
            {
                Marker.Add(tokens[1], commandCounter);
            }
        }

        private void Br(string[] tokens, ref int commandCounter)
        {
            if (tokens.Length == 2 && Marker.ContainsKey(tokens[1]))
            {
                commandCounter = Marker[tokens[1]];
                return;
            }

            Errors.Add("Failed BR");
        }

        private void Brgz(string[] tokens, ref int commandCounter)
        {
            if (tokens.Length == 3 && Marker.ContainsKey(tokens[1]) && Registers.ContainsKey(tokens[2]))
            {
                if (Registers[tokens[2]] > 0)
                {
                    commandCounter = Marker[tokens[1]];
                    return;
                }

                return;
            }

            Errors.Add("Failed BRGZ");
        }

        private void Ld(string[] tokens)
        {
            if (tokens.Length == 3 && Registers.ContainsKey(tokens[1]))
            {
                if (IsNum(tokens[2]).Ok)
                {
                    Registers[tokens[1]] = IsNum(tokens[2]).value;
                    return;
                }

                Errors.Add("Failed LD");
            }
        }

        private void Mov(string[] tokens)
        {
            if (tokens.Length == 3 && Registers.ContainsKey(tokens[1]) && Registers.ContainsKey(tokens[2]))
            {
                Registers[tokens[1]] = Registers[tokens[2]];
                return;
            }

            Errors.Add("Failed MOV");
        }

        private void Add(string[] tokens)
        {
            if (tokens.Length == 3 && Registers.ContainsKey(tokens[1]) && Registers.ContainsKey(tokens[2]))
            {
                Registers[tokens[1]] += Registers[tokens[2]];
                return;
            }

            Errors.Add("Failed ADD");
        }

        private void Sub(string[] tokens)
        {
            if (tokens.Length == 3 && Registers.ContainsKey(tokens[1]) && Registers.ContainsKey(tokens[2]))
            {
                if (Registers[tokens[1]] - Registers[tokens[2]] < 0)
                {
                    Errors.Add($"By doing SUB {tokens[1]} went into negative");
                }

                Registers[tokens[1]] -= Registers[tokens[2]];
                return;
            }

            Errors.Add("Failed SUB");
        }

        private (byte value, bool Ok) IsNum(string token)
        {
            var result = Regex.Match(token, @"^#(\d+)$");
            if (result.Success)
            {
                byte parse;
                bool flag = Byte.TryParse(result.Groups[1].Value, out parse);
                if (!flag) Errors.Add($"{token} failed to convert from String in Byte");
                return (parse, flag);
            }

            Errors.Add($"{token} did not pass the conformity check");
            return (0, false);
        }
    }
}