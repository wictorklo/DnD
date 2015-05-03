namespace DnD
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Character = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CharName = new System.Windows.Forms.TextBox();
            this.Abilities = new System.Windows.Forms.TabPage();
            this.Skills = new System.Windows.Forms.TabPage();
            this.Inventory = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.levelCount = new System.Windows.Forms.NumericUpDown();
            this.str = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dex = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.con = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cha = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.wis = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.inti = new System.Windows.Forms.NumericUpDown();
            this.chaMod = new System.Windows.Forms.NumericUpDown();
            this.wisMod = new System.Windows.Forms.NumericUpDown();
            this.intMod = new System.Windows.Forms.NumericUpDown();
            this.conMod = new System.Windows.Forms.NumericUpDown();
            this.dexMod = new System.Windows.Forms.NumericUpDown();
            this.strMod = new System.Windows.Forms.NumericUpDown();
            this.calcStats = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Character.SuspendLayout();
            this.Abilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strMod)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Character);
            this.tabControl1.Controls.Add(this.Abilities);
            this.tabControl1.Controls.Add(this.Skills);
            this.tabControl1.Controls.Add(this.Inventory);
            this.tabControl1.Location = new System.Drawing.Point(156, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // Character
            // 
            this.Character.Controls.Add(this.levelCount);
            this.Character.Controls.Add(this.label4);
            this.Character.Controls.Add(this.comboBox2);
            this.Character.Controls.Add(this.label3);
            this.Character.Controls.Add(this.label2);
            this.Character.Controls.Add(this.comboBox1);
            this.Character.Controls.Add(this.label1);
            this.Character.Controls.Add(this.CharName);
            this.Character.Location = new System.Drawing.Point(4, 22);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(486, 330);
            this.Character.TabIndex = 3;
            this.Character.Text = "Character";
            this.Character.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.comboBox2.Location = new System.Drawing.Point(58, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Race:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Human",
            "Dwarf",
            "Halfling",
            "Half-elf",
            "Half-orc",
            "Dragonborn",
            "Tiefling"});
            this.comboBox1.Location = new System.Drawing.Point(58, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Please choose one";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // CharName
            // 
            this.CharName.Location = new System.Drawing.Point(58, 18);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(184, 20);
            this.CharName.TabIndex = 0;
            // 
            // Abilities
            // 
            this.Abilities.Controls.Add(this.calcStats);
            this.Abilities.Controls.Add(this.chaMod);
            this.Abilities.Controls.Add(this.wisMod);
            this.Abilities.Controls.Add(this.intMod);
            this.Abilities.Controls.Add(this.conMod);
            this.Abilities.Controls.Add(this.dexMod);
            this.Abilities.Controls.Add(this.strMod);
            this.Abilities.Controls.Add(this.label8);
            this.Abilities.Controls.Add(this.cha);
            this.Abilities.Controls.Add(this.label9);
            this.Abilities.Controls.Add(this.wis);
            this.Abilities.Controls.Add(this.label10);
            this.Abilities.Controls.Add(this.inti);
            this.Abilities.Controls.Add(this.label7);
            this.Abilities.Controls.Add(this.con);
            this.Abilities.Controls.Add(this.label6);
            this.Abilities.Controls.Add(this.dex);
            this.Abilities.Controls.Add(this.label5);
            this.Abilities.Controls.Add(this.str);
            this.Abilities.Location = new System.Drawing.Point(4, 22);
            this.Abilities.Name = "Abilities";
            this.Abilities.Padding = new System.Windows.Forms.Padding(3);
            this.Abilities.Size = new System.Drawing.Size(486, 330);
            this.Abilities.TabIndex = 0;
            this.Abilities.Text = "Abilities";
            this.Abilities.UseVisualStyleBackColor = true;
            // 
            // Skills
            // 
            this.Skills.Location = new System.Drawing.Point(4, 22);
            this.Skills.Name = "Skills";
            this.Skills.Padding = new System.Windows.Forms.Padding(3);
            this.Skills.Size = new System.Drawing.Size(486, 330);
            this.Skills.TabIndex = 1;
            this.Skills.Text = "Skills";
            this.Skills.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.Inventory.Location = new System.Drawing.Point(4, 22);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(486, 330);
            this.Inventory.TabIndex = 2;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 35);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(15, 86);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(113, 35);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Level:";
            // 
            // levelCount
            // 
            this.levelCount.Location = new System.Drawing.Point(58, 153);
            this.levelCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.levelCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelCount.Name = "levelCount";
            this.levelCount.Size = new System.Drawing.Size(45, 20);
            this.levelCount.TabIndex = 7;
            this.levelCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(78, 60);
            this.str.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(88, 20);
            this.str.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Str:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dex:";
            // 
            // dex
            // 
            this.dex.Location = new System.Drawing.Point(78, 100);
            this.dex.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.dex.Name = "dex";
            this.dex.Size = new System.Drawing.Size(88, 20);
            this.dex.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Con:";
            // 
            // con
            // 
            this.con.Location = new System.Drawing.Point(78, 142);
            this.con.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(88, 20);
            this.con.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cha:";
            // 
            // cha
            // 
            this.cha.Location = new System.Drawing.Point(78, 270);
            this.cha.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.cha.Name = "cha";
            this.cha.Size = new System.Drawing.Size(88, 20);
            this.cha.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Wis:";
            // 
            // wis
            // 
            this.wis.Location = new System.Drawing.Point(78, 228);
            this.wis.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.wis.Name = "wis";
            this.wis.Size = new System.Drawing.Size(88, 20);
            this.wis.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Int:";
            // 
            // inti
            // 
            this.inti.Location = new System.Drawing.Point(78, 188);
            this.inti.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.inti.Name = "inti";
            this.inti.Size = new System.Drawing.Size(88, 20);
            this.inti.TabIndex = 6;
            // 
            // chaMod
            // 
            this.chaMod.Enabled = false;
            this.chaMod.Location = new System.Drawing.Point(274, 270);
            this.chaMod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.chaMod.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.chaMod.Name = "chaMod";
            this.chaMod.Size = new System.Drawing.Size(88, 20);
            this.chaMod.TabIndex = 17;
            this.chaMod.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // wisMod
            // 
            this.wisMod.Enabled = false;
            this.wisMod.Location = new System.Drawing.Point(274, 228);
            this.wisMod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wisMod.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.wisMod.Name = "wisMod";
            this.wisMod.Size = new System.Drawing.Size(88, 20);
            this.wisMod.TabIndex = 16;
            this.wisMod.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // intMod
            // 
            this.intMod.Enabled = false;
            this.intMod.Location = new System.Drawing.Point(274, 188);
            this.intMod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.intMod.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.intMod.Name = "intMod";
            this.intMod.Size = new System.Drawing.Size(88, 20);
            this.intMod.TabIndex = 15;
            this.intMod.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // conMod
            // 
            this.conMod.Enabled = false;
            this.conMod.Location = new System.Drawing.Point(274, 142);
            this.conMod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.conMod.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.conMod.Name = "conMod";
            this.conMod.Size = new System.Drawing.Size(88, 20);
            this.conMod.TabIndex = 14;
            this.conMod.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // dexMod
            // 
            this.dexMod.Enabled = false;
            this.dexMod.Location = new System.Drawing.Point(274, 100);
            this.dexMod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dexMod.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.dexMod.Name = "dexMod";
            this.dexMod.Size = new System.Drawing.Size(88, 20);
            this.dexMod.TabIndex = 13;
            this.dexMod.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // strMod
            // 
            this.strMod.Enabled = false;
            this.strMod.Location = new System.Drawing.Point(274, 60);
            this.strMod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.strMod.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.strMod.Name = "strMod";
            this.strMod.Size = new System.Drawing.Size(88, 20);
            this.strMod.TabIndex = 12;
            this.strMod.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // calcStats
            // 
            this.calcStats.Location = new System.Drawing.Point(78, 302);
            this.calcStats.Name = "calcStats";
            this.calcStats.Size = new System.Drawing.Size(88, 25);
            this.calcStats.TabIndex = 18;
            this.calcStats.Text = "Calculate";
            this.calcStats.UseVisualStyleBackColor = true;
            this.calcStats.Click += new System.EventHandler(this.calcStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 465);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DnD char sheet";
            this.tabControl1.ResumeLayout(false);
            this.Character.ResumeLayout(false);
            this.Character.PerformLayout();
            this.Abilities.ResumeLayout(false);
            this.Abilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Character;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CharName;
        private System.Windows.Forms.TabPage Abilities;
        private System.Windows.Forms.TabPage Skills;
        private System.Windows.Forms.TabPage Inventory;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.NumericUpDown levelCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown chaMod;
        private System.Windows.Forms.NumericUpDown wisMod;
        private System.Windows.Forms.NumericUpDown intMod;
        private System.Windows.Forms.NumericUpDown conMod;
        private System.Windows.Forms.NumericUpDown dexMod;
        private System.Windows.Forms.NumericUpDown strMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown wis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown inti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown con;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown dex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown str;
        private System.Windows.Forms.Button calcStats;
    }
}

