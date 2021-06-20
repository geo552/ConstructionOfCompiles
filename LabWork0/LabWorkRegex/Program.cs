using System;
using System.Text.RegularExpressions;

namespace LabWorkRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            WorkOne();
            WorkTwo();
            WorkTree();
        }

        public static void WorkOne()
        {
            Console.WriteLine($"Task 1");
            string str = "234567, 323452, 333, 234123,:::;; 23 423421 34 23";
            Console.WriteLine($"string = {str}");
            Console.WriteLine($"Value = {Count(str)}\n");
        }

        public static void WorkTwo()
        {
            Console.WriteLine($"Task 2");
            string str = "В простом предложении содержится только одна грамматическая основа. ";
            Console.WriteLine($"string = {str}");
            Console.WriteLine($"Value = {Replace(str)}\n");
        }

        public static void WorkTree()
        {
            Console.WriteLine($"Task 3");
            string str = "g:-f4f;:[]h8 df ;rs:-):---(()))-;-- :]]]][::---() :;-))))9)";
            Console.WriteLine($"string = {str}");
            Console.WriteLine($"Value = {CountSmiles(str)}\n");
        }
        
        public static int Count(string postcode)
        {
            string pattern = @"\d{6}";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(postcode);
            return match.Count;
        }
        
        public static string Replace(string multiString)
        {
            string str = Regex.Replace(multiString, @"(\w)(\w+)(\w)", $"$3$2$1");
            return str;
        }
        
        public static int CountSmiles(string str)
        {
            string pattern = @"[;:]{1}-*(\[+|\]+|\(+|\)+)";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(str);
            return match.Count;
        }
    }
}
