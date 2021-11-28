
namespace ChozoStatueHintEditor
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOpenROM = new System.Windows.Forms.Button();
            this.GbHint = new System.Windows.Forms.GroupBox();
            this.GbEnd = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbYTarget = new System.Windows.Forms.TextBox();
            this.TbXTarget = new System.Windows.Forms.TextBox();
            this.CbTargetIcon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CbTargetArea = new System.Windows.Forms.ComboBox();
            this.GbStart = new System.Windows.Forms.GroupBox();
            this.CbStartIcon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbYEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbXEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbYStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbXStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbStartArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbStatues = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIHint = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIPair = new System.Windows.Forms.ToolStripMenuItem();
            this.GbPair = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TbMapY2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TbMapX2 = new System.Windows.Forms.TextBox();
            this.TbRoomID2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CbAreaID2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TbMapY1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TbMapX1 = new System.Windows.Forms.TextBox();
            this.TbRoomID1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CbPairID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CbAreaID1 = new System.Windows.Forms.ComboBox();
            this.GbHint.SuspendLayout();
            this.GbEnd.SuspendLayout();
            this.GbStart.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GbPair.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOpenROM
            // 
            this.BtnOpenROM.Location = new System.Drawing.Point(12, 46);
            this.BtnOpenROM.Name = "BtnOpenROM";
            this.BtnOpenROM.Size = new System.Drawing.Size(90, 31);
            this.BtnOpenROM.TabIndex = 0;
            this.BtnOpenROM.Text = "Open ROM";
            this.BtnOpenROM.UseVisualStyleBackColor = true;
            this.BtnOpenROM.Click += new System.EventHandler(this.BtnOpenROM_Click);
            // 
            // GbHint
            // 
            this.GbHint.Controls.Add(this.GbEnd);
            this.GbHint.Controls.Add(this.GbStart);
            this.GbHint.Controls.Add(this.label1);
            this.GbHint.Controls.Add(this.CbStatues);
            this.GbHint.Location = new System.Drawing.Point(12, 105);
            this.GbHint.Name = "GbHint";
            this.GbHint.Size = new System.Drawing.Size(458, 443);
            this.GbHint.TabIndex = 1;
            this.GbHint.TabStop = false;
            this.GbHint.Text = "Hint";
            this.GbHint.Visible = false;
            // 
            // GbEnd
            // 
            this.GbEnd.Controls.Add(this.label11);
            this.GbEnd.Controls.Add(this.label10);
            this.GbEnd.Controls.Add(this.TbYTarget);
            this.GbEnd.Controls.Add(this.TbXTarget);
            this.GbEnd.Controls.Add(this.CbTargetIcon);
            this.GbEnd.Controls.Add(this.label8);
            this.GbEnd.Controls.Add(this.label9);
            this.GbEnd.Controls.Add(this.CbTargetArea);
            this.GbEnd.Location = new System.Drawing.Point(19, 273);
            this.GbEnd.Name = "GbEnd";
            this.GbEnd.Size = new System.Drawing.Size(418, 149);
            this.GbEnd.TabIndex = 4;
            this.GbEnd.TabStop = false;
            this.GbEnd.Text = "Target";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(246, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Y Position :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(9, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "X Position :";
            // 
            // TbYTarget
            // 
            this.TbYTarget.Location = new System.Drawing.Point(350, 76);
            this.TbYTarget.Name = "TbYTarget";
            this.TbYTarget.Size = new System.Drawing.Size(41, 23);
            this.TbYTarget.TabIndex = 14;
            this.TbYTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbXTarget
            // 
            this.TbXTarget.Location = new System.Drawing.Point(113, 75);
            this.TbXTarget.Name = "TbXTarget";
            this.TbXTarget.Size = new System.Drawing.Size(41, 23);
            this.TbXTarget.TabIndex = 18;
            this.TbXTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbTargetIcon
            // 
            this.CbTargetIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTargetIcon.FormattingEnabled = true;
            this.CbTargetIcon.Items.AddRange(new object[] {
            "Target",
            "Up Elevator",
            "Down Elevator",
            "Green Flame",
            "Green Flame Moving",
            "Pink Flame",
            "Pink Flame Moving"});
            this.CbTargetIcon.Location = new System.Drawing.Point(227, 31);
            this.CbTargetIcon.Name = "CbTargetIcon";
            this.CbTargetIcon.Size = new System.Drawing.Size(164, 23);
            this.CbTargetIcon.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(177, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Icon :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Area :";
            // 
            // CbTargetArea
            // 
            this.CbTargetArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTargetArea.FormattingEnabled = true;
            this.CbTargetArea.Items.AddRange(new object[] {
            "Brinstar",
            "Kraid",
            "Norfair",
            "Ridley",
            "Tourian",
            "Crateria",
            "Chozodia"});
            this.CbTargetArea.Location = new System.Drawing.Point(73, 31);
            this.CbTargetArea.Name = "CbTargetArea";
            this.CbTargetArea.Size = new System.Drawing.Size(81, 23);
            this.CbTargetArea.TabIndex = 14;
            // 
            // GbStart
            // 
            this.GbStart.Controls.Add(this.CbStartIcon);
            this.GbStart.Controls.Add(this.label7);
            this.GbStart.Controls.Add(this.label5);
            this.GbStart.Controls.Add(this.TbYEnd);
            this.GbStart.Controls.Add(this.label6);
            this.GbStart.Controls.Add(this.TbXEnd);
            this.GbStart.Controls.Add(this.label4);
            this.GbStart.Controls.Add(this.TbYStart);
            this.GbStart.Controls.Add(this.label3);
            this.GbStart.Controls.Add(this.TbXStart);
            this.GbStart.Controls.Add(this.label2);
            this.GbStart.Controls.Add(this.CbStartArea);
            this.GbStart.Location = new System.Drawing.Point(19, 82);
            this.GbStart.Name = "GbStart";
            this.GbStart.Size = new System.Drawing.Size(418, 166);
            this.GbStart.TabIndex = 3;
            this.GbStart.TabStop = false;
            this.GbStart.Text = "Start";
            // 
            // CbStartIcon
            // 
            this.CbStartIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStartIcon.FormattingEnabled = true;
            this.CbStartIcon.Items.AddRange(new object[] {
            "Target",
            "Up Elevator",
            "Down Elevator",
            "Green Flame",
            "Green Flame Moving",
            "Pink Flame",
            "Pink Flame Moving"});
            this.CbStartIcon.Location = new System.Drawing.Point(227, 34);
            this.CbStartIcon.Name = "CbStartIcon";
            this.CbStartIcon.Size = new System.Drawing.Size(164, 23);
            this.CbStartIcon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(177, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Icon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(276, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y End :";
            // 
            // TbYEnd
            // 
            this.TbYEnd.Location = new System.Drawing.Point(350, 123);
            this.TbYEnd.Name = "TbYEnd";
            this.TbYEnd.Size = new System.Drawing.Size(41, 23);
            this.TbYEnd.TabIndex = 10;
            this.TbYEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(276, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "X End :";
            // 
            // TbXEnd
            // 
            this.TbXEnd.Location = new System.Drawing.Point(350, 83);
            this.TbXEnd.Name = "TbXEnd";
            this.TbXEnd.Size = new System.Drawing.Size(41, 23);
            this.TbXEnd.TabIndex = 8;
            this.TbXEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y Position :";
            // 
            // TbYStart
            // 
            this.TbYStart.Location = new System.Drawing.Point(113, 122);
            this.TbYStart.Name = "TbYStart";
            this.TbYStart.Size = new System.Drawing.Size(41, 23);
            this.TbYStart.TabIndex = 6;
            this.TbYStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "X Position :";
            // 
            // TbXStart
            // 
            this.TbXStart.Location = new System.Drawing.Point(113, 82);
            this.TbXStart.Name = "TbXStart";
            this.TbXStart.Size = new System.Drawing.Size(41, 23);
            this.TbXStart.TabIndex = 4;
            this.TbXStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Area :";
            // 
            // CbStartArea
            // 
            this.CbStartArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStartArea.FormattingEnabled = true;
            this.CbStartArea.Items.AddRange(new object[] {
            "Brinstar",
            "Kraid",
            "Norfair",
            "Ridley",
            "Tourian",
            "Crateria",
            "Chozodia"});
            this.CbStartArea.Location = new System.Drawing.Point(73, 34);
            this.CbStartArea.Name = "CbStartArea";
            this.CbStartArea.Size = new System.Drawing.Size(81, 23);
            this.CbStartArea.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statue :";
            // 
            // CbStatues
            // 
            this.CbStatues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStatues.FormattingEnabled = true;
            this.CbStatues.Items.AddRange(new object[] {
            "Long Beam",
            "Bomb",
            "Ice Beam",
            "Speedbooster",
            "High Jump",
            "Varia Suit",
            "Wave Beam",
            "Screw (Unused)",
            "Kraid Flame (Unused)",
            "Ridley Flame (Unused)"});
            this.CbStatues.Location = new System.Drawing.Point(128, 33);
            this.CbStatues.Name = "CbStatues";
            this.CbStatues.Size = new System.Drawing.Size(183, 23);
            this.CbStatues.TabIndex = 0;
            this.CbStatues.SelectedIndexChanged += new System.EventHandler(this.CbStatues_SelectedIndexChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(389, 46);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(81, 31);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIHint,
            this.TSMIPair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIHint
            // 
            this.TSMIHint.Enabled = false;
            this.TSMIHint.Name = "TSMIHint";
            this.TSMIHint.Size = new System.Drawing.Size(42, 20);
            this.TSMIHint.Text = "Hint";
            this.TSMIHint.Click += new System.EventHandler(this.TSMIHint_Click);
            // 
            // TSMIPair
            // 
            this.TSMIPair.Enabled = false;
            this.TSMIPair.Name = "TSMIPair";
            this.TSMIPair.Size = new System.Drawing.Size(39, 20);
            this.TSMIPair.Text = "Pair";
            this.TSMIPair.Click += new System.EventHandler(this.TSMIPair_Click);
            // 
            // GbPair
            // 
            this.GbPair.Controls.Add(this.label17);
            this.GbPair.Controls.Add(this.TbMapY2);
            this.GbPair.Controls.Add(this.label18);
            this.GbPair.Controls.Add(this.label19);
            this.GbPair.Controls.Add(this.TbMapX2);
            this.GbPair.Controls.Add(this.TbRoomID2);
            this.GbPair.Controls.Add(this.label20);
            this.GbPair.Controls.Add(this.CbAreaID2);
            this.GbPair.Controls.Add(this.label16);
            this.GbPair.Controls.Add(this.TbMapY1);
            this.GbPair.Controls.Add(this.label15);
            this.GbPair.Controls.Add(this.label14);
            this.GbPair.Controls.Add(this.TbMapX1);
            this.GbPair.Controls.Add(this.TbRoomID1);
            this.GbPair.Controls.Add(this.label13);
            this.GbPair.Controls.Add(this.CbPairID);
            this.GbPair.Controls.Add(this.label12);
            this.GbPair.Controls.Add(this.CbAreaID1);
            this.GbPair.Location = new System.Drawing.Point(12, 105);
            this.GbPair.Name = "GbPair";
            this.GbPair.Size = new System.Drawing.Size(389, 290);
            this.GbPair.TabIndex = 4;
            this.GbPair.TabStop = false;
            this.GbPair.Text = "Pair";
            this.GbPair.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(213, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "Map Y 2 :";
            // 
            // TbMapY2
            // 
            this.TbMapY2.Location = new System.Drawing.Point(317, 241);
            this.TbMapY2.Name = "TbMapY2";
            this.TbMapY2.Size = new System.Drawing.Size(41, 23);
            this.TbMapY2.TabIndex = 24;
            this.TbMapY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(213, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Map X 2 :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(213, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Room ID 2 :";
            // 
            // TbMapX2
            // 
            this.TbMapX2.Location = new System.Drawing.Point(317, 203);
            this.TbMapX2.Name = "TbMapX2";
            this.TbMapX2.Size = new System.Drawing.Size(41, 23);
            this.TbMapX2.TabIndex = 22;
            this.TbMapX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbRoomID2
            // 
            this.TbRoomID2.Location = new System.Drawing.Point(317, 165);
            this.TbRoomID2.Name = "TbRoomID2";
            this.TbRoomID2.Size = new System.Drawing.Size(41, 23);
            this.TbRoomID2.TabIndex = 20;
            this.TbRoomID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(213, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 20);
            this.label20.TabIndex = 19;
            this.label20.Text = "Area 2 :";
            // 
            // CbAreaID2
            // 
            this.CbAreaID2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAreaID2.FormattingEnabled = true;
            this.CbAreaID2.Items.AddRange(new object[] {
            "Brinstar",
            "Kraid",
            "Norfair",
            "Ridley",
            "Tourian",
            "Crateria",
            "Chozodia"});
            this.CbAreaID2.Location = new System.Drawing.Point(277, 117);
            this.CbAreaID2.Name = "CbAreaID2";
            this.CbAreaID2.Size = new System.Drawing.Size(81, 23);
            this.CbAreaID2.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(27, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Map Y 1 :";
            // 
            // TbMapY1
            // 
            this.TbMapY1.Location = new System.Drawing.Point(131, 239);
            this.TbMapY1.Name = "TbMapY1";
            this.TbMapY1.Size = new System.Drawing.Size(41, 23);
            this.TbMapY1.TabIndex = 16;
            this.TbMapY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(27, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Map X 1 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(27, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Room ID 1 :";
            // 
            // TbMapX1
            // 
            this.TbMapX1.Location = new System.Drawing.Point(131, 201);
            this.TbMapX1.Name = "TbMapX1";
            this.TbMapX1.Size = new System.Drawing.Size(41, 23);
            this.TbMapX1.TabIndex = 14;
            this.TbMapX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbRoomID1
            // 
            this.TbRoomID1.Location = new System.Drawing.Point(131, 163);
            this.TbRoomID1.Name = "TbRoomID1";
            this.TbRoomID1.Size = new System.Drawing.Size(41, 23);
            this.TbRoomID1.TabIndex = 9;
            this.TbRoomID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(57, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "ID :";
            // 
            // CbPairID
            // 
            this.CbPairID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPairID.FormattingEnabled = true;
            this.CbPairID.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CbPairID.Location = new System.Drawing.Point(94, 35);
            this.CbPairID.Name = "CbPairID";
            this.CbPairID.Size = new System.Drawing.Size(183, 23);
            this.CbPairID.TabIndex = 7;
            this.CbPairID.SelectedIndexChanged += new System.EventHandler(this.CbPairID_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(27, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Area 1 :";
            // 
            // CbAreaID1
            // 
            this.CbAreaID1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAreaID1.FormattingEnabled = true;
            this.CbAreaID1.Items.AddRange(new object[] {
            "Brinstar",
            "Kraid",
            "Norfair",
            "Ridley",
            "Tourian",
            "Crateria",
            "Chozodia"});
            this.CbAreaID1.Location = new System.Drawing.Point(91, 115);
            this.CbAreaID1.Name = "CbAreaID1";
            this.CbAreaID1.Size = new System.Drawing.Size(81, 23);
            this.CbAreaID1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 560);
            this.Controls.Add(this.GbPair);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GbHint);
            this.Controls.Add(this.BtnOpenROM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Chozo Statue Hint Editor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.GbHint.ResumeLayout(false);
            this.GbHint.PerformLayout();
            this.GbEnd.ResumeLayout(false);
            this.GbEnd.PerformLayout();
            this.GbStart.ResumeLayout(false);
            this.GbStart.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GbPair.ResumeLayout(false);
            this.GbPair.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenROM;
        private System.Windows.Forms.GroupBox GbHint;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CbStatues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbStartArea;
        private System.Windows.Forms.GroupBox GbStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbYStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbXStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbYEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbXEnd;
        private System.Windows.Forms.ComboBox CbStartIcon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GbEnd;
        private System.Windows.Forms.ComboBox CbTargetIcon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbTargetArea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbYTarget;
        private System.Windows.Forms.TextBox TbXTarget;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIHint;
        private System.Windows.Forms.ToolStripMenuItem TSMIPair;
        private System.Windows.Forms.GroupBox GbPair;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CbPairID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CbAreaID1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TbMapY1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbMapX1;
        private System.Windows.Forms.TextBox TbRoomID1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TbMapY2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TbMapX2;
        private System.Windows.Forms.TextBox TbRoomID2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox CbAreaID2;
    }
}

