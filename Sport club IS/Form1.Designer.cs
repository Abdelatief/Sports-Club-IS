namespace Sport_club_IS
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
            this.InsertTraningPanel = new System.Windows.Forms.Panel();
            this.AddNewTraning = new System.Windows.Forms.Button();
            this.DateAddTraningPicker = new System.Windows.Forms.DateTimePicker();
            this.AddSportNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddcoachPanel = new System.Windows.Forms.Panel();
            this.AddCoachbtn = new System.Windows.Forms.Button();
            this.CLNameTxt = new System.Windows.Forms.TextBox();
            this.CSalaryTxt = new System.Windows.Forms.TextBox();
            this.CAddressTxt = new System.Windows.Forms.TextBox();
            this.CSportNameTxt = new System.Windows.Forms.TextBox();
            this.CPhoneNumTxt = new System.Windows.Forms.TextBox();
            this.CFNameTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBdPicker = new System.Windows.Forms.DateTimePicker();
            this.InsertTraningPanel.SuspendLayout();
            this.AddcoachPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertTraningPanel
            // 
            this.InsertTraningPanel.Controls.Add(this.AddNewTraning);
            this.InsertTraningPanel.Controls.Add(this.DateAddTraningPicker);
            this.InsertTraningPanel.Controls.Add(this.AddSportNameTxt);
            this.InsertTraningPanel.Controls.Add(this.label3);
            this.InsertTraningPanel.Controls.Add(this.label2);
            this.InsertTraningPanel.Controls.Add(this.label1);
            this.InsertTraningPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsertTraningPanel.Location = new System.Drawing.Point(0, 0);
            this.InsertTraningPanel.Name = "InsertTraningPanel";
            this.InsertTraningPanel.Size = new System.Drawing.Size(800, 450);
            this.InsertTraningPanel.TabIndex = 0;
            this.InsertTraningPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InsertTraningPanel_Paint);
            // 
            // AddNewTraning
            // 
            this.AddNewTraning.Location = new System.Drawing.Point(334, 265);
            this.AddNewTraning.Name = "AddNewTraning";
            this.AddNewTraning.Size = new System.Drawing.Size(75, 23);
            this.AddNewTraning.TabIndex = 6;
            this.AddNewTraning.Text = "Add";
            this.AddNewTraning.UseVisualStyleBackColor = true;
            this.AddNewTraning.Click += new System.EventHandler(this.AddNewTraning_Click);
            // 
            // DateAddTraningPicker
            // 
            this.DateAddTraningPicker.Checked = false;
            this.DateAddTraningPicker.CustomFormat = "dd/MM/yyyy";
            this.DateAddTraningPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateAddTraningPicker.Location = new System.Drawing.Point(417, 161);
            this.DateAddTraningPicker.MaxDate = new System.DateTime(2021, 9, 10, 0, 0, 0, 0);
            this.DateAddTraningPicker.MinDate = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            this.DateAddTraningPicker.Name = "DateAddTraningPicker";
            this.DateAddTraningPicker.Size = new System.Drawing.Size(200, 22);
            this.DateAddTraningPicker.TabIndex = 5;
            this.DateAddTraningPicker.Value = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            this.DateAddTraningPicker.ValueChanged += new System.EventHandler(this.DateAddTraningPicker_ValueChanged);
            // 
            // AddSportNameTxt
            // 
            this.AddSportNameTxt.Location = new System.Drawing.Point(417, 102);
            this.AddSportNameTxt.Name = "AddSportNameTxt";
            this.AddSportNameTxt.Size = new System.Drawing.Size(200, 22);
            this.AddSportNameTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sport Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Traning";
            // 
            // AddcoachPanel
            // 
            this.AddcoachPanel.Controls.Add(this.CBdPicker);
            this.AddcoachPanel.Controls.Add(this.AddCoachbtn);
            this.AddcoachPanel.Controls.Add(this.CLNameTxt);
            this.AddcoachPanel.Controls.Add(this.CSalaryTxt);
            this.AddcoachPanel.Controls.Add(this.CAddressTxt);
            this.AddcoachPanel.Controls.Add(this.CSportNameTxt);
            this.AddcoachPanel.Controls.Add(this.CPhoneNumTxt);
            this.AddcoachPanel.Controls.Add(this.CFNameTxt);
            this.AddcoachPanel.Controls.Add(this.label12);
            this.AddcoachPanel.Controls.Add(this.label11);
            this.AddcoachPanel.Controls.Add(this.label9);
            this.AddcoachPanel.Controls.Add(this.label8);
            this.AddcoachPanel.Controls.Add(this.label7);
            this.AddcoachPanel.Controls.Add(this.label6);
            this.AddcoachPanel.Controls.Add(this.label5);
            this.AddcoachPanel.Controls.Add(this.label4);
            this.AddcoachPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddcoachPanel.Location = new System.Drawing.Point(0, 0);
            this.AddcoachPanel.Name = "AddcoachPanel";
            this.AddcoachPanel.Size = new System.Drawing.Size(800, 450);
            this.AddcoachPanel.TabIndex = 7;
            this.AddcoachPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddcoachPanel_Paint);
            // 
            // AddCoachbtn
            // 
            this.AddCoachbtn.Location = new System.Drawing.Point(344, 400);
            this.AddCoachbtn.Name = "AddCoachbtn";
            this.AddCoachbtn.Size = new System.Drawing.Size(75, 23);
            this.AddCoachbtn.TabIndex = 16;
            this.AddCoachbtn.Text = "Add";
            this.AddCoachbtn.UseVisualStyleBackColor = true;
            this.AddCoachbtn.Click += new System.EventHandler(this.AddCoachbtn_Click);
            // 
            // CLNameTxt
            // 
            this.CLNameTxt.Location = new System.Drawing.Point(434, 134);
            this.CLNameTxt.Name = "CLNameTxt";
            this.CLNameTxt.Size = new System.Drawing.Size(200, 22);
            this.CLNameTxt.TabIndex = 15;
            // 
            // CSalaryTxt
            // 
            this.CSalaryTxt.Location = new System.Drawing.Point(434, 179);
            this.CSalaryTxt.Name = "CSalaryTxt";
            this.CSalaryTxt.Size = new System.Drawing.Size(200, 22);
            this.CSalaryTxt.TabIndex = 14;
            this.CSalaryTxt.TextChanged += new System.EventHandler(this.CSalaryTxt_TextChanged);
            this.CSalaryTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CSalaryTxt_KeyPress);
            // 
            // CAddressTxt
            // 
            this.CAddressTxt.Location = new System.Drawing.Point(434, 221);
            this.CAddressTxt.Name = "CAddressTxt";
            this.CAddressTxt.Size = new System.Drawing.Size(200, 22);
            this.CAddressTxt.TabIndex = 13;
            // 
            // CSportNameTxt
            // 
            this.CSportNameTxt.Location = new System.Drawing.Point(434, 263);
            this.CSportNameTxt.Name = "CSportNameTxt";
            this.CSportNameTxt.Size = new System.Drawing.Size(200, 22);
            this.CSportNameTxt.TabIndex = 12;
            // 
            // CPhoneNumTxt
            // 
            this.CPhoneNumTxt.Location = new System.Drawing.Point(434, 342);
            this.CPhoneNumTxt.MaxLength = 11;
            this.CPhoneNumTxt.Name = "CPhoneNumTxt";
            this.CPhoneNumTxt.Size = new System.Drawing.Size(200, 22);
            this.CPhoneNumTxt.TabIndex = 10;
            this.CPhoneNumTxt.TextChanged += new System.EventHandler(this.CPhoneNumTxt_TextChanged);
            this.CPhoneNumTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPhoneNumTxt_KeyPress);
            // 
            // CFNameTxt
            // 
            this.CFNameTxt.Location = new System.Drawing.Point(434, 90);
            this.CFNameTxt.Name = "CFNameTxt";
            this.CFNameTxt.Size = new System.Drawing.Size(200, 22);
            this.CFNameTxt.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sport Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "BirthDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add new Coach";
            // 
            // CBdPicker
            // 
            this.CBdPicker.Checked = false;
            this.CBdPicker.CustomFormat = "dd/MM/yyyy";
            this.CBdPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CBdPicker.Location = new System.Drawing.Point(434, 305);
            this.CBdPicker.MaxDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CBdPicker.MinDate = new System.DateTime(1980, 6, 10, 0, 0, 0, 0);
            this.CBdPicker.Name = "CBdPicker";
            this.CBdPicker.Size = new System.Drawing.Size(200, 22);
            this.CBdPicker.TabIndex = 18;
            this.CBdPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddcoachPanel);
            this.Controls.Add(this.InsertTraningPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InsertTraningPanel.ResumeLayout(false);
            this.InsertTraningPanel.PerformLayout();
            this.AddcoachPanel.ResumeLayout(false);
            this.AddcoachPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InsertTraningPanel;
        private System.Windows.Forms.Button AddNewTraning;
        private System.Windows.Forms.DateTimePicker DateAddTraningPicker;
        private System.Windows.Forms.TextBox AddSportNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddcoachPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddCoachbtn;
        private System.Windows.Forms.TextBox CLNameTxt;
        private System.Windows.Forms.TextBox CSalaryTxt;
        private System.Windows.Forms.TextBox CAddressTxt;
        private System.Windows.Forms.TextBox CSportNameTxt;
        private System.Windows.Forms.TextBox CPhoneNumTxt;
        private System.Windows.Forms.TextBox CFNameTxt;
        private System.Windows.Forms.DateTimePicker CBdPicker;
    }
}

