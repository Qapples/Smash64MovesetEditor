namespace Smash64MovesetEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.HexCodeButton = new System.Windows.Forms.Button();
            this.CodeHexButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 43);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(258, 274);
            this.InputBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 336);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(258, 278);
            this.OutputBox.TabIndex = 4;
            // 
            // HexCodeButton
            // 
            this.HexCodeButton.Location = new System.Drawing.Point(302, 71);
            this.HexCodeButton.Name = "HexCodeButton";
            this.HexCodeButton.Size = new System.Drawing.Size(126, 48);
            this.HexCodeButton.TabIndex = 5;
            this.HexCodeButton.Text = "Convert hex into code";
            this.HexCodeButton.UseVisualStyleBackColor = true;
            this.HexCodeButton.Click += new System.EventHandler(this.HexCodeButton_click);
            // 
            // CodeHexButton
            // 
            this.CodeHexButton.Location = new System.Drawing.Point(302, 226);
            this.CodeHexButton.Name = "CodeHexButton";
            this.CodeHexButton.Size = new System.Drawing.Size(126, 48);
            this.CodeHexButton.TabIndex = 6;
            this.CodeHexButton.Text = "Convert code into hex";
            this.CodeHexButton.UseVisualStyleBackColor = true;
            this.CodeHexButton.Click += new System.EventHandler(this.CodeHexButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "Open             Ctrl + O";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save               Crtl + S";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 622);
            this.Controls.Add(this.CodeHexButton);
            this.Controls.Add(this.HexCodeButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Smash 64 Moveset Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button HexCodeButton;
        private System.Windows.Forms.Button CodeHexButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}