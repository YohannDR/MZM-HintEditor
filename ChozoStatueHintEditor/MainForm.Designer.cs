
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
            this.GbMain = new System.Windows.Forms.GroupBox();
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
            this.GbMain.SuspendLayout();
            this.GbEnd.SuspendLayout();
            this.GbStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOpenROM
            // 
            this.BtnOpenROM.Location = new System.Drawing.Point(12, 12);
            this.BtnOpenROM.Name = "BtnOpenROM";
            this.BtnOpenROM.Size = new System.Drawing.Size(90, 31);
            this.BtnOpenROM.TabIndex = 0;
            this.BtnOpenROM.Text = "Open ROM";
            this.BtnOpenROM.UseVisualStyleBackColor = true;
            this.BtnOpenROM.Click += new System.EventHandler(this.BtnOpenROM_Click);
            // 
            // GbMain
            // 
            this.GbMain.Controls.Add(this.GbEnd);
            this.GbMain.Controls.Add(this.GbStart);
            this.GbMain.Controls.Add(this.label1);
            this.GbMain.Controls.Add(this.CbStatues);
            this.GbMain.Location = new System.Drawing.Point(12, 65);
            this.GbMain.Name = "GbMain";
            this.GbMain.Size = new System.Drawing.Size(458, 439);
            this.GbMain.TabIndex = 1;
            this.GbMain.TabStop = false;
            this.GbMain.Text = "Editor";
            this.GbMain.Visible = false;
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
            this.GbEnd.Location = new System.Drawing.Point(19, 274);
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
            this.GbStart.Location = new System.Drawing.Point(19, 83);
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
            this.label1.Location = new System.Drawing.Point(64, 35);
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
            this.CbStatues.Location = new System.Drawing.Point(128, 34);
            this.CbStatues.Name = "CbStatues";
            this.CbStatues.Size = new System.Drawing.Size(183, 23);
            this.CbStatues.TabIndex = 0;
            this.CbStatues.SelectedIndexChanged += new System.EventHandler(this.CbStatues_SelectedIndexChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(389, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(81, 31);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 521);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GbMain);
            this.Controls.Add(this.BtnOpenROM);
            this.Name = "MainForm";
            this.Text = "Chozo Statue Hint Editor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.GbMain.ResumeLayout(false);
            this.GbMain.PerformLayout();
            this.GbEnd.ResumeLayout(false);
            this.GbEnd.PerformLayout();
            this.GbStart.ResumeLayout(false);
            this.GbStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenROM;
        private System.Windows.Forms.GroupBox GbMain;
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
    }
}

