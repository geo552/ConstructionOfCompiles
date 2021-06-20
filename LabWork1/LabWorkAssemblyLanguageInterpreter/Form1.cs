using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWorkAssemblyLanguageInterpreter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void OpenTsmi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "asm files (*.asm)|*.asm|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try
                {
                    CodeTxt.Text = File.ReadAllText(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveTsmi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "asm files (*.asm)|*.asm";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, CodeTxt.Text);
            }
        }

        private void StartTsbtn_Click(object sender, EventArgs e)
        {           
            Asm asm = new Asm();
            asm.Interpreter(CodeTxt.Text);
            MessageBox.Show(String.Join("\n", asm.Registers.Select(s => s.Key + "\t" + s.Value)));
        }
    }
}