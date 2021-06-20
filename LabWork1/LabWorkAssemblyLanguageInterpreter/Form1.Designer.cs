namespace LabWorkAssemblyLanguageInterpreter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CodeTxt = new System.Windows.Forms.TextBox();
            this.MenuTs = new System.Windows.Forms.ToolStrip();
            this.FileTsddb = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.StartTsbtn = new System.Windows.Forms.ToolStripButton();
            this.MenuTs.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeTxt
            // 
            this.CodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTxt.Location = new System.Drawing.Point(12, 28);
            this.CodeTxt.Multiline = true;
            this.CodeTxt.Name = "CodeTxt";
            this.CodeTxt.Size = new System.Drawing.Size(360, 421);
            this.CodeTxt.TabIndex = 0;
            // 
            // MenuTs
            // 
            this.MenuTs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileTsddb, this.StartTsbtn});
            this.MenuTs.Location = new System.Drawing.Point(0, 0);
            this.MenuTs.Name = "MenuTs";
            this.MenuTs.Size = new System.Drawing.Size(384, 25);
            this.MenuTs.TabIndex = 1;
            this.MenuTs.Text = "toolStrip1";
            // 
            // FileTsddb
            // 
            this.FileTsddb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileTsddb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.SaveTsmi, this.OpenTsmi});
            this.FileTsddb.Image = ((System.Drawing.Image) (resources.GetObject("FileTsddb.Image")));
            this.FileTsddb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileTsddb.Name = "FileTsddb";
            this.FileTsddb.Size = new System.Drawing.Size(38, 22);
            this.FileTsddb.Text = "File";
            // 
            // SaveTsmi
            // 
            this.SaveTsmi.Name = "SaveTsmi";
            this.SaveTsmi.Size = new System.Drawing.Size(152, 22);
            this.SaveTsmi.Text = "Save";
            this.SaveTsmi.Click += new System.EventHandler(this.SaveTsmi_Click);
            // 
            // OpenTsmi
            // 
            this.OpenTsmi.Name = "OpenTsmi";
            this.OpenTsmi.Size = new System.Drawing.Size(152, 22);
            this.OpenTsmi.Text = "Open";
            this.OpenTsmi.Click += new System.EventHandler(this.OpenTsmi_Click);
            // 
            // StartTsbtn
            // 
            this.StartTsbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StartTsbtn.Image = ((System.Drawing.Image) (resources.GetObject("StartTsbtn.Image")));
            this.StartTsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartTsbtn.Name = "StartTsbtn";
            this.StartTsbtn.Size = new System.Drawing.Size(35, 22);
            this.StartTsbtn.Text = "Start";
            this.StartTsbtn.Click += new System.EventHandler(this.StartTsbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.MenuTs);
            this.Controls.Add(this.CodeTxt);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuTs.ResumeLayout(false);
            this.MenuTs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem OpenTsmi;
        private System.Windows.Forms.ToolStripMenuItem SaveTsmi;

        private System.Windows.Forms.ToolStripButton StartTsbtn;

        private System.Windows.Forms.ToolStripDropDownButton FileTsddb;

        private System.Windows.Forms.ToolStrip MenuTs;

        private System.Windows.Forms.TextBox CodeTxt;

        #endregion
    }
}