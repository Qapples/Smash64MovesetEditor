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
        /// Requethod for Designer support - do
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ThrowData = new System.Windows.Forms.TabControl();
            this.MovesetTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ThrowDataTab = new System.Windows.Forms.TabPage();
            this.GenerateThrowDataButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.FKBReleaseDataBox = new System.Windows.Forms.TextBox();
            this.BKBReleaseDataBox = new System.Windows.Forms.TextBox();
            this.KBSReleaseDataBox = new System.Windows.Forms.TextBox();
            this.AngleReleaseDataBox = new System.Windows.Forms.TextBox();
            this.DamageReleaseDataBox = new System.Windows.Forms.TextBox();
            this.DamageEffectReleaseBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FKBThrowDataBox = new System.Windows.Forms.TextBox();
            this.BKBThrowDataBox = new System.Windows.Forms.TextBox();
            this.KBSThrowDataBox = new System.Windows.Forms.TextBox();
            this.AngleThrowDataBox = new System.Windows.Forms.TextBox();
            this.DamageThrowDataBox = new System.Windows.Forms.TextBox();
            this.ActionIdBox = new System.Windows.Forms.TextBox();
            this.DamageEffectThrowBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OutputBoxThrow = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.ThrowData.SuspendLayout();
            this.MovesetTab.SuspendLayout();
            this.ThrowDataTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(3, 19);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(258, 247);
            this.InputBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, -74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(3, 285);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(258, 276);
            this.OutputBox.TabIndex = 4;
            // 
            // HexCodeButton
            // 
            this.HexCodeButton.Location = new System.Drawing.Point(298, 201);
            this.HexCodeButton.Name = "HexCodeButton";
            this.HexCodeButton.Size = new System.Drawing.Size(126, 48);
            this.HexCodeButton.TabIndex = 5;
            this.HexCodeButton.Text = "Convert hex into code";
            this.HexCodeButton.UseVisualStyleBackColor = true;
            this.HexCodeButton.Click += new System.EventHandler(this.HexCodeButton_click);
            // 
            // CodeHexButton
            // 
            this.CodeHexButton.Location = new System.Drawing.Point(298, 33);
            this.CodeHexButton.Name = "CodeHexButton";
            this.CodeHexButton.Size = new System.Drawing.Size(119, 50);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openToolStripMenuItem.Text = "Import              Ctrl + I";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveToolStripMenuItem.Text = "Export               Crtl + E";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            // ThrowData
            // 
            this.ThrowData.Controls.Add(this.MovesetTab);
            this.ThrowData.Controls.Add(this.ThrowDataTab);
            this.ThrowData.Location = new System.Drawing.Point(0, 27);
            this.ThrowData.Name = "ThrowData";
            this.ThrowData.SelectedIndex = 0;
            this.ThrowData.Size = new System.Drawing.Size(451, 593);
            this.ThrowData.TabIndex = 8;
            // 
            // MovesetTab
            // 
            this.MovesetTab.Controls.Add(this.label4);
            this.MovesetTab.Controls.Add(this.label1);
            this.MovesetTab.Controls.Add(this.HexCodeButton);
            this.MovesetTab.Controls.Add(this.CodeHexButton);
            this.MovesetTab.Controls.Add(this.InputBox);
            this.MovesetTab.Controls.Add(this.label2);
            this.MovesetTab.Controls.Add(this.label3);
            this.MovesetTab.Controls.Add(this.OutputBox);
            this.MovesetTab.Location = new System.Drawing.Point(4, 22);
            this.MovesetTab.Name = "MovesetTab";
            this.MovesetTab.Padding = new System.Windows.Forms.Padding(3);
            this.MovesetTab.Size = new System.Drawing.Size(443, 567);
            this.MovesetTab.TabIndex = 0;
            this.MovesetTab.Text = "Moveset Editor";
            this.MovesetTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input";
            // 
            // ThrowDataTab
            // 
            this.ThrowDataTab.Controls.Add(this.GenerateThrowDataButton);
            this.ThrowDataTab.Controls.Add(this.label21);
            this.ThrowDataTab.Controls.Add(this.label20);
            this.ThrowDataTab.Controls.Add(this.label13);
            this.ThrowDataTab.Controls.Add(this.label14);
            this.ThrowDataTab.Controls.Add(this.label15);
            this.ThrowDataTab.Controls.Add(this.label16);
            this.ThrowDataTab.Controls.Add(this.label17);
            this.ThrowDataTab.Controls.Add(this.label18);
            this.ThrowDataTab.Controls.Add(this.FKBReleaseDataBox);
            this.ThrowDataTab.Controls.Add(this.BKBReleaseDataBox);
            this.ThrowDataTab.Controls.Add(this.KBSReleaseDataBox);
            this.ThrowDataTab.Controls.Add(this.AngleReleaseDataBox);
            this.ThrowDataTab.Controls.Add(this.DamageReleaseDataBox);
            this.ThrowDataTab.Controls.Add(this.DamageEffectReleaseBox);
            this.ThrowDataTab.Controls.Add(this.label12);
            this.ThrowDataTab.Controls.Add(this.label11);
            this.ThrowDataTab.Controls.Add(this.label10);
            this.ThrowDataTab.Controls.Add(this.label9);
            this.ThrowDataTab.Controls.Add(this.label8);
            this.ThrowDataTab.Controls.Add(this.label7);
            this.ThrowDataTab.Controls.Add(this.label6);
            this.ThrowDataTab.Controls.Add(this.FKBThrowDataBox);
            this.ThrowDataTab.Controls.Add(this.BKBThrowDataBox);
            this.ThrowDataTab.Controls.Add(this.KBSThrowDataBox);
            this.ThrowDataTab.Controls.Add(this.AngleThrowDataBox);
            this.ThrowDataTab.Controls.Add(this.DamageThrowDataBox);
            this.ThrowDataTab.Controls.Add(this.ActionIdBox);
            this.ThrowDataTab.Controls.Add(this.DamageEffectThrowBox);
            this.ThrowDataTab.Controls.Add(this.label5);
            this.ThrowDataTab.Controls.Add(this.OutputBoxThrow);
            this.ThrowDataTab.Location = new System.Drawing.Point(4, 22);
            this.ThrowDataTab.Name = "ThrowDataTab";
            this.ThrowDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.ThrowDataTab.Size = new System.Drawing.Size(443, 567);
            this.ThrowDataTab.TabIndex = 1;
            this.ThrowDataTab.Text = "Throw Data Generator";
            this.ThrowDataTab.UseVisualStyleBackColor = true;
            // 
            // GenerateThrowDataButton
            // 
            this.GenerateThrowDataButton.Location = new System.Drawing.Point(166, 257);
            this.GenerateThrowDataButton.Name = "GenerateThrowDataButton";
            this.GenerateThrowDataButton.Size = new System.Drawing.Size(135, 23);
            this.GenerateThrowDataButton.TabIndex = 34;
            this.GenerateThrowDataButton.Text = "Generate Throw Data";
            this.GenerateThrowDataButton.UseVisualStyleBackColor = true;
            this.GenerateThrowDataButton.Click += new System.EventHandler(this.GenerateThrowDataButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(181, 135);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Grab Release Data";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(191, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Throw Data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Damage Type/Effect";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(358, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "   BKB";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "   FKB";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(205, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "   KBS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(126, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "   ANG";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(47, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "   DMG";
            // 
            // FKBReleaseDataBox
            // 
            this.FKBReleaseDataBox.Location = new System.Drawing.Point(287, 173);
            this.FKBReleaseDataBox.Name = "FKBReleaseDataBox";
            this.FKBReleaseDataBox.Size = new System.Drawing.Size(42, 20);
            this.FKBReleaseDataBox.TabIndex = 24;
            // 
            // BKBReleaseDataBox
            // 
            this.BKBReleaseDataBox.Location = new System.Drawing.Point(361, 173);
            this.BKBReleaseDataBox.Name = "BKBReleaseDataBox";
            this.BKBReleaseDataBox.Size = new System.Drawing.Size(42, 20);
            this.BKBReleaseDataBox.TabIndex = 23;
            // 
            // KBSReleaseDataBox
            // 
            this.KBSReleaseDataBox.Location = new System.Drawing.Point(208, 173);
            this.KBSReleaseDataBox.Name = "KBSReleaseDataBox";
            this.KBSReleaseDataBox.Size = new System.Drawing.Size(42, 20);
            this.KBSReleaseDataBox.TabIndex = 22;
            // 
            // AngleReleaseDataBox
            // 
            this.AngleReleaseDataBox.Location = new System.Drawing.Point(129, 173);
            this.AngleReleaseDataBox.Name = "AngleReleaseDataBox";
            this.AngleReleaseDataBox.Size = new System.Drawing.Size(42, 20);
            this.AngleReleaseDataBox.TabIndex = 21;
            // 
            // DamageReleaseDataBox
            // 
            this.DamageReleaseDataBox.Location = new System.Drawing.Point(50, 173);
            this.DamageReleaseDataBox.Name = "DamageReleaseDataBox";
            this.DamageReleaseDataBox.Size = new System.Drawing.Size(42, 20);
            this.DamageReleaseDataBox.TabIndex = 20;
            // 
            // DamageEffectReleaseBox
            // 
            this.DamageEffectReleaseBox.DisplayMember = "Normal";
            this.DamageEffectReleaseBox.FormattingEnabled = true;
            this.DamageEffectReleaseBox.Items.AddRange(new object[] {
            "Normal",
            "Fire",
            "Electric",
            "Slash",
            "Coin",
            "Sleep"});
            this.DamageEffectReleaseBox.Location = new System.Drawing.Point(166, 214);
            this.DamageEffectReleaseBox.Name = "DamageEffectReleaseBox";
            this.DamageEffectReleaseBox.Size = new System.Drawing.Size(121, 21);
            this.DamageEffectReleaseBox.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Damage Type/Effect";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "   BKB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "   FKB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "   KBS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "   ANG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "   DMG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Action ID";
            // 
            // FKBThrowDataBox
            // 
            this.FKBThrowDataBox.Location = new System.Drawing.Point(324, 35);
            this.FKBThrowDataBox.Name = "FKBThrowDataBox";
            this.FKBThrowDataBox.Size = new System.Drawing.Size(42, 20);
            this.FKBThrowDataBox.TabIndex = 10;
            // 
            // BKBThrowDataBox
            // 
            this.BKBThrowDataBox.Location = new System.Drawing.Point(398, 35);
            this.BKBThrowDataBox.Name = "BKBThrowDataBox";
            this.BKBThrowDataBox.Size = new System.Drawing.Size(42, 20);
            this.BKBThrowDataBox.TabIndex = 9;
            // 
            // KBSThrowDataBox
            // 
            this.KBSThrowDataBox.Location = new System.Drawing.Point(245, 35);
            this.KBSThrowDataBox.Name = "KBSThrowDataBox";
            this.KBSThrowDataBox.Size = new System.Drawing.Size(42, 20);
            this.KBSThrowDataBox.TabIndex = 8;
            // 
            // AngleThrowDataBox
            // 
            this.AngleThrowDataBox.Location = new System.Drawing.Point(166, 35);
            this.AngleThrowDataBox.Name = "AngleThrowDataBox";
            this.AngleThrowDataBox.Size = new System.Drawing.Size(42, 20);
            this.AngleThrowDataBox.TabIndex = 7;
            // 
            // DamageThrowDataBox
            // 
            this.DamageThrowDataBox.Location = new System.Drawing.Point(87, 35);
            this.DamageThrowDataBox.Name = "DamageThrowDataBox";
            this.DamageThrowDataBox.Size = new System.Drawing.Size(42, 20);
            this.DamageThrowDataBox.TabIndex = 6;
            // 
            // ActionIdBox
            // 
            this.ActionIdBox.Location = new System.Drawing.Point(8, 35);
            this.ActionIdBox.Name = "ActionIdBox";
            this.ActionIdBox.Size = new System.Drawing.Size(42, 20);
            this.ActionIdBox.TabIndex = 5;
            // 
            // DamageEffectThrowBox
            // 
            this.DamageEffectThrowBox.AllowDrop = true;
            this.DamageEffectThrowBox.DisplayMember = "Normal";
            this.DamageEffectThrowBox.FormattingEnabled = true;
            this.DamageEffectThrowBox.Items.AddRange(new object[] {
            "Normal",
            "Fire",
            "Electric",
            "Slash",
            "Coin",
            "Sleep"});
            this.DamageEffectThrowBox.Location = new System.Drawing.Point(166, 81);
            this.DamageEffectThrowBox.Name = "DamageEffectThrowBox";
            this.DamageEffectThrowBox.Size = new System.Drawing.Size(121, 21);
            this.DamageEffectThrowBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Output";
            // 
            // OutputBoxThrow
            // 
            this.OutputBoxThrow.Location = new System.Drawing.Point(99, 314);
            this.OutputBoxThrow.Multiline = true;
            this.OutputBoxThrow.Name = "OutputBoxThrow";
            this.OutputBoxThrow.Size = new System.Drawing.Size(258, 247);
            this.OutputBoxThrow.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 622);
            this.Controls.Add(this.ThrowData);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Smash 64 Moveset Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ThrowData.ResumeLayout(false);
            this.MovesetTab.ResumeLayout(false);
            this.MovesetTab.PerformLayout();
            this.ThrowDataTab.ResumeLayout(false);
            this.ThrowDataTab.PerformLayout();
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl ThrowData;
        private System.Windows.Forms.TabPage MovesetTab;
        private System.Windows.Forms.TabPage ThrowDataTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputBoxThrow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FKBThrowDataBox;
        private System.Windows.Forms.TextBox BKBThrowDataBox;
        private System.Windows.Forms.TextBox KBSThrowDataBox;
        private System.Windows.Forms.TextBox AngleThrowDataBox;
        private System.Windows.Forms.TextBox DamageThrowDataBox;
        private System.Windows.Forms.TextBox ActionIdBox;
        private System.Windows.Forms.ComboBox DamageEffectThrowBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox FKBReleaseDataBox;
        private System.Windows.Forms.TextBox BKBReleaseDataBox;
        private System.Windows.Forms.TextBox KBSReleaseDataBox;
        private System.Windows.Forms.TextBox AngleReleaseDataBox;
        private System.Windows.Forms.TextBox DamageReleaseDataBox;
        private System.Windows.Forms.ComboBox DamageEffectReleaseBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button GenerateThrowDataButton;
    }
}