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
            this.addTrainingPanel = new System.Windows.Forms.Panel();
            this.backFromTrainingPanel_btn = new System.Windows.Forms.Button();
            this.AddNewTraning = new System.Windows.Forms.Button();
            this.DateAddTraningPicker = new System.Windows.Forms.DateTimePicker();
            this.AddSportNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addcoachPanel = new System.Windows.Forms.Panel();
            this.backFormNewCoachPanel_btn = new System.Windows.Forms.Button();
            this.CBdPicker = new System.Windows.Forms.DateTimePicker();
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
            this.addTeamPanel = new System.Windows.Forms.Panel();
            this.backFromTeamPanel_btn = new System.Windows.Forms.Button();
            this.addTeam_btn = new System.Windows.Forms.Button();
            this.coachID_cb = new System.Windows.Forms.ComboBox();
            this.rank_txt = new System.Windows.Forms.TextBox();
            this.sportName_cb = new System.Windows.Forms.ComboBox();
            this.teamName_txt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.choicesPanel = new System.Windows.Forms.Panel();
            this.AddCoach_btn = new System.Windows.Forms.Button();
            this.AddTraining_btn = new System.Windows.Forms.Button();
            this.newTeam_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.CoachUpdatePanel = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.confirmPass_txt = new System.Windows.Forms.TextBox();
            this.coachPass_txt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.coachProfilePanel = new System.Windows.Forms.Panel();
            this.backFromCoachprofile_btn = new System.Windows.Forms.Button();
            this.trainingDates_DGV = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.TeamDGV = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.coachOptions_Panel = new System.Windows.Forms.Panel();
            this.coachProfile_btn = new System.Windows.Forms.Button();
            this.restPass_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.addTrainingPanel.SuspendLayout();
            this.addcoachPanel.SuspendLayout();
            this.addTeamPanel.SuspendLayout();
            this.choicesPanel.SuspendLayout();
            this.CoachUpdatePanel.SuspendLayout();
            this.coachProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDates_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDGV)).BeginInit();
            this.coachOptions_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTrainingPanel
            // 
            this.addTrainingPanel.Controls.Add(this.backFromTrainingPanel_btn);
            this.addTrainingPanel.Controls.Add(this.AddNewTraning);
            this.addTrainingPanel.Controls.Add(this.DateAddTraningPicker);
            this.addTrainingPanel.Controls.Add(this.AddSportNameTxt);
            this.addTrainingPanel.Controls.Add(this.label3);
            this.addTrainingPanel.Controls.Add(this.label2);
            this.addTrainingPanel.Controls.Add(this.label1);
            this.addTrainingPanel.Location = new System.Drawing.Point(12, 12);
            this.addTrainingPanel.Name = "addTrainingPanel";
            this.addTrainingPanel.Size = new System.Drawing.Size(681, 447);
            this.addTrainingPanel.TabIndex = 0;
            this.addTrainingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InsertTraningPanel_Paint);
            // 
            // backFromTrainingPanel_btn
            // 
            this.backFromTrainingPanel_btn.Location = new System.Drawing.Point(219, 268);
            this.backFromTrainingPanel_btn.Name = "backFromTrainingPanel_btn";
            this.backFromTrainingPanel_btn.Size = new System.Drawing.Size(75, 23);
            this.backFromTrainingPanel_btn.TabIndex = 7;
            this.backFromTrainingPanel_btn.Text = "Back";
            this.backFromTrainingPanel_btn.UseVisualStyleBackColor = true;
            this.backFromTrainingPanel_btn.Click += new System.EventHandler(this.backFromTrainingPanel_btn_Click);
            // 
            // AddNewTraning
            // 
            this.AddNewTraning.Location = new System.Drawing.Point(362, 265);
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
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Training";
            // 
            // addcoachPanel
            // 
            this.addcoachPanel.Controls.Add(this.backFormNewCoachPanel_btn);
            this.addcoachPanel.Controls.Add(this.CBdPicker);
            this.addcoachPanel.Controls.Add(this.AddCoachbtn);
            this.addcoachPanel.Controls.Add(this.CLNameTxt);
            this.addcoachPanel.Controls.Add(this.CSalaryTxt);
            this.addcoachPanel.Controls.Add(this.CAddressTxt);
            this.addcoachPanel.Controls.Add(this.CSportNameTxt);
            this.addcoachPanel.Controls.Add(this.CPhoneNumTxt);
            this.addcoachPanel.Controls.Add(this.CFNameTxt);
            this.addcoachPanel.Controls.Add(this.label12);
            this.addcoachPanel.Controls.Add(this.label11);
            this.addcoachPanel.Controls.Add(this.label9);
            this.addcoachPanel.Controls.Add(this.label8);
            this.addcoachPanel.Controls.Add(this.label7);
            this.addcoachPanel.Controls.Add(this.label6);
            this.addcoachPanel.Controls.Add(this.label5);
            this.addcoachPanel.Controls.Add(this.label4);
            this.addcoachPanel.Location = new System.Drawing.Point(12, 12);
            this.addcoachPanel.Name = "addcoachPanel";
            this.addcoachPanel.Size = new System.Drawing.Size(684, 450);
            this.addcoachPanel.TabIndex = 7;
            // 
            // backFormNewCoachPanel_btn
            // 
            this.backFormNewCoachPanel_btn.Location = new System.Drawing.Point(248, 400);
            this.backFormNewCoachPanel_btn.Name = "backFormNewCoachPanel_btn";
            this.backFormNewCoachPanel_btn.Size = new System.Drawing.Size(75, 23);
            this.backFormNewCoachPanel_btn.TabIndex = 19;
            this.backFormNewCoachPanel_btn.Text = "Back";
            this.backFormNewCoachPanel_btn.UseVisualStyleBackColor = true;
            this.backFormNewCoachPanel_btn.Click += new System.EventHandler(this.backFormNewCoachPanel_btn_Click);
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
            // AddCoachbtn
            // 
            this.AddCoachbtn.Location = new System.Drawing.Point(434, 400);
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
            // addTeamPanel
            // 
            this.addTeamPanel.Controls.Add(this.backFromTeamPanel_btn);
            this.addTeamPanel.Controls.Add(this.addTeam_btn);
            this.addTeamPanel.Controls.Add(this.coachID_cb);
            this.addTeamPanel.Controls.Add(this.rank_txt);
            this.addTeamPanel.Controls.Add(this.sportName_cb);
            this.addTeamPanel.Controls.Add(this.teamName_txt);
            this.addTeamPanel.Controls.Add(this.label16);
            this.addTeamPanel.Controls.Add(this.label15);
            this.addTeamPanel.Controls.Add(this.label14);
            this.addTeamPanel.Controls.Add(this.label13);
            this.addTeamPanel.Controls.Add(this.label10);
            this.addTeamPanel.Location = new System.Drawing.Point(12, 12);
            this.addTeamPanel.Name = "addTeamPanel";
            this.addTeamPanel.Size = new System.Drawing.Size(698, 418);
            this.addTeamPanel.TabIndex = 20;
            this.addTeamPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addTeamPanel_Paint);
            // 
            // backFromTeamPanel_btn
            // 
            this.backFromTeamPanel_btn.Location = new System.Drawing.Point(207, 328);
            this.backFromTeamPanel_btn.Name = "backFromTeamPanel_btn";
            this.backFromTeamPanel_btn.Size = new System.Drawing.Size(75, 23);
            this.backFromTeamPanel_btn.TabIndex = 10;
            this.backFromTeamPanel_btn.Text = "Back";
            this.backFromTeamPanel_btn.UseVisualStyleBackColor = true;
            this.backFromTeamPanel_btn.Click += new System.EventHandler(this.backFromTeamPanel_btn_Click);
            // 
            // addTeam_btn
            // 
            this.addTeam_btn.Location = new System.Drawing.Point(362, 328);
            this.addTeam_btn.Name = "addTeam_btn";
            this.addTeam_btn.Size = new System.Drawing.Size(75, 23);
            this.addTeam_btn.TabIndex = 9;
            this.addTeam_btn.Text = "Add";
            this.addTeam_btn.UseVisualStyleBackColor = true;
            this.addTeam_btn.Click += new System.EventHandler(this.addTeam_btn_Click);
            // 
            // coachID_cb
            // 
            this.coachID_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coachID_cb.FormattingEnabled = true;
            this.coachID_cb.Location = new System.Drawing.Point(389, 264);
            this.coachID_cb.Name = "coachID_cb";
            this.coachID_cb.Size = new System.Drawing.Size(160, 24);
            this.coachID_cb.TabIndex = 8;
            // 
            // rank_txt
            // 
            this.rank_txt.Location = new System.Drawing.Point(389, 216);
            this.rank_txt.Name = "rank_txt";
            this.rank_txt.Size = new System.Drawing.Size(160, 22);
            this.rank_txt.TabIndex = 7;
            this.rank_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rank_txt_KeyPress);
            // 
            // sportName_cb
            // 
            this.sportName_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sportName_cb.FormattingEnabled = true;
            this.sportName_cb.Location = new System.Drawing.Point(389, 161);
            this.sportName_cb.Name = "sportName_cb";
            this.sportName_cb.Size = new System.Drawing.Size(160, 24);
            this.sportName_cb.TabIndex = 6;
            // 
            // teamName_txt
            // 
            this.teamName_txt.Location = new System.Drawing.Point(389, 107);
            this.teamName_txt.Name = "teamName_txt";
            this.teamName_txt.Size = new System.Drawing.Size(160, 22);
            this.teamName_txt.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(91, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Coach ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Rank";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Sport Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Team Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Add Team";
            // 
            // choicesPanel
            // 
            this.choicesPanel.Controls.Add(this.AddCoach_btn);
            this.choicesPanel.Controls.Add(this.AddTraining_btn);
            this.choicesPanel.Controls.Add(this.newTeam_btn);
            this.choicesPanel.Controls.Add(this.Update_btn);
            this.choicesPanel.Location = new System.Drawing.Point(12, 12);
            this.choicesPanel.Name = "choicesPanel";
            this.choicesPanel.Size = new System.Drawing.Size(698, 464);
            this.choicesPanel.TabIndex = 21;
            // 
            // AddCoach_btn
            // 
            this.AddCoach_btn.Location = new System.Drawing.Point(273, 199);
            this.AddCoach_btn.Name = "AddCoach_btn";
            this.AddCoach_btn.Size = new System.Drawing.Size(164, 39);
            this.AddCoach_btn.TabIndex = 3;
            this.AddCoach_btn.Text = "Add Coach";
            this.AddCoach_btn.UseVisualStyleBackColor = true;
            this.AddCoach_btn.Click += new System.EventHandler(this.AddCoach_btn_Click);
            // 
            // AddTraining_btn
            // 
            this.AddTraining_btn.Location = new System.Drawing.Point(273, 126);
            this.AddTraining_btn.Name = "AddTraining_btn";
            this.AddTraining_btn.Size = new System.Drawing.Size(164, 39);
            this.AddTraining_btn.TabIndex = 2;
            this.AddTraining_btn.Text = "Add Training";
            this.AddTraining_btn.UseVisualStyleBackColor = true;
            this.AddTraining_btn.Click += new System.EventHandler(this.AddTraining_btn_Click);
            // 
            // newTeam_btn
            // 
            this.newTeam_btn.Location = new System.Drawing.Point(273, 57);
            this.newTeam_btn.Name = "newTeam_btn";
            this.newTeam_btn.Size = new System.Drawing.Size(164, 39);
            this.newTeam_btn.TabIndex = 1;
            this.newTeam_btn.Text = "Add new Team";
            this.newTeam_btn.UseVisualStyleBackColor = true;
            this.newTeam_btn.Click += new System.EventHandler(this.newTeam_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(273, 281);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(164, 41);
            this.Update_btn.TabIndex = 0;
            this.Update_btn.Text = "Update Informations";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // CoachUpdatePanel
            // 
            this.CoachUpdatePanel.Controls.Add(this.back_btn);
            this.CoachUpdatePanel.Controls.Add(this.updatebtn);
            this.CoachUpdatePanel.Controls.Add(this.confirmPass_txt);
            this.CoachUpdatePanel.Controls.Add(this.coachPass_txt);
            this.CoachUpdatePanel.Controls.Add(this.label18);
            this.CoachUpdatePanel.Controls.Add(this.label17);
            this.CoachUpdatePanel.Location = new System.Drawing.Point(12, 12);
            this.CoachUpdatePanel.Name = "CoachUpdatePanel";
            this.CoachUpdatePanel.Size = new System.Drawing.Size(695, 461);
            this.CoachUpdatePanel.TabIndex = 20;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(152, 302);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(103, 25);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(353, 302);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(107, 25);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // confirmPass_txt
            // 
            this.confirmPass_txt.Location = new System.Drawing.Point(334, 199);
            this.confirmPass_txt.Name = "confirmPass_txt";
            this.confirmPass_txt.PasswordChar = '*';
            this.confirmPass_txt.Size = new System.Drawing.Size(163, 22);
            this.confirmPass_txt.TabIndex = 4;
            // 
            // coachPass_txt
            // 
            this.coachPass_txt.Location = new System.Drawing.Point(334, 119);
            this.coachPass_txt.Name = "coachPass_txt";
            this.coachPass_txt.PasswordChar = '*';
            this.coachPass_txt.Size = new System.Drawing.Size(163, 22);
            this.coachPass_txt.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(105, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Confirm password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(105, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Password";
            // 
            // coachProfilePanel
            // 
            this.coachProfilePanel.Controls.Add(this.backFromCoachprofile_btn);
            this.coachProfilePanel.Controls.Add(this.trainingDates_DGV);
            this.coachProfilePanel.Controls.Add(this.label20);
            this.coachProfilePanel.Controls.Add(this.TeamDGV);
            this.coachProfilePanel.Controls.Add(this.label19);
            this.coachProfilePanel.Location = new System.Drawing.Point(12, 12);
            this.coachProfilePanel.Name = "coachProfilePanel";
            this.coachProfilePanel.Size = new System.Drawing.Size(698, 533);
            this.coachProfilePanel.TabIndex = 22;
            this.coachProfilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.coachProfilePanel_Paint);
            // 
            // backFromCoachprofile_btn
            // 
            this.backFromCoachprofile_btn.Location = new System.Drawing.Point(94, 482);
            this.backFromCoachprofile_btn.Name = "backFromCoachprofile_btn";
            this.backFromCoachprofile_btn.Size = new System.Drawing.Size(116, 28);
            this.backFromCoachprofile_btn.TabIndex = 4;
            this.backFromCoachprofile_btn.Text = "Back";
            this.backFromCoachprofile_btn.UseVisualStyleBackColor = true;
            this.backFromCoachprofile_btn.Click += new System.EventHandler(this.backFromCoachprofile_btn_Click);
            // 
            // trainingDates_DGV
            // 
            this.trainingDates_DGV.AllowUserToAddRows = false;
            this.trainingDates_DGV.AllowUserToDeleteRows = false;
            this.trainingDates_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingDates_DGV.Location = new System.Drawing.Point(94, 291);
            this.trainingDates_DGV.Name = "trainingDates_DGV";
            this.trainingDates_DGV.ReadOnly = true;
            this.trainingDates_DGV.RowHeadersWidth = 51;
            this.trainingDates_DGV.RowTemplate.Height = 24;
            this.trainingDates_DGV.Size = new System.Drawing.Size(515, 148);
            this.trainingDates_DGV.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(91, 246);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 17);
            this.label20.TabIndex = 2;
            this.label20.Text = "Training dates";
            // 
            // TeamDGV
            // 
            this.TeamDGV.AllowUserToAddRows = false;
            this.TeamDGV.AllowUserToDeleteRows = false;
            this.TeamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamDGV.Location = new System.Drawing.Point(94, 79);
            this.TeamDGV.Name = "TeamDGV";
            this.TeamDGV.ReadOnly = true;
            this.TeamDGV.RowHeadersWidth = 51;
            this.TeamDGV.RowTemplate.Height = 24;
            this.TeamDGV.Size = new System.Drawing.Size(515, 148);
            this.TeamDGV.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(91, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "The teams you are ranking";
            // 
            // coachOptions_Panel
            // 
            this.coachOptions_Panel.Controls.Add(this.logout_btn);
            this.coachOptions_Panel.Controls.Add(this.restPass_btn);
            this.coachOptions_Panel.Controls.Add(this.coachProfile_btn);
            this.coachOptions_Panel.Location = new System.Drawing.Point(12, 12);
            this.coachOptions_Panel.Name = "coachOptions_Panel";
            this.coachOptions_Panel.Size = new System.Drawing.Size(695, 533);
            this.coachOptions_Panel.TabIndex = 5;
            // 
            // coachProfile_btn
            // 
            this.coachProfile_btn.Location = new System.Drawing.Point(248, 78);
            this.coachProfile_btn.Name = "coachProfile_btn";
            this.coachProfile_btn.Size = new System.Drawing.Size(203, 47);
            this.coachProfile_btn.TabIndex = 0;
            this.coachProfile_btn.Text = "Profile";
            this.coachProfile_btn.UseVisualStyleBackColor = true;
            this.coachProfile_btn.Click += new System.EventHandler(this.coachProfile_btn_Click);
            // 
            // restPass_btn
            // 
            this.restPass_btn.Location = new System.Drawing.Point(248, 191);
            this.restPass_btn.Name = "restPass_btn";
            this.restPass_btn.Size = new System.Drawing.Size(203, 47);
            this.restPass_btn.TabIndex = 1;
            this.restPass_btn.Text = "Rest Password";
            this.restPass_btn.UseVisualStyleBackColor = true;
            this.restPass_btn.Click += new System.EventHandler(this.restPass_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(248, 305);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(203, 47);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 583);
            this.Controls.Add(this.coachOptions_Panel);
            this.Controls.Add(this.coachProfilePanel);
            this.Controls.Add(this.CoachUpdatePanel);
            this.Controls.Add(this.addcoachPanel);
            this.Controls.Add(this.choicesPanel);
            this.Controls.Add(this.addTeamPanel);
            this.Controls.Add(this.addTrainingPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.addTrainingPanel.ResumeLayout(false);
            this.addTrainingPanel.PerformLayout();
            this.addcoachPanel.ResumeLayout(false);
            this.addcoachPanel.PerformLayout();
            this.addTeamPanel.ResumeLayout(false);
            this.addTeamPanel.PerformLayout();
            this.choicesPanel.ResumeLayout(false);
            this.CoachUpdatePanel.ResumeLayout(false);
            this.CoachUpdatePanel.PerformLayout();
            this.coachProfilePanel.ResumeLayout(false);
            this.coachProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDates_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDGV)).EndInit();
            this.coachOptions_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addTrainingPanel;
        private System.Windows.Forms.Button AddNewTraning;
        private System.Windows.Forms.DateTimePicker DateAddTraningPicker;
        private System.Windows.Forms.TextBox AddSportNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addcoachPanel;
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
        private System.Windows.Forms.Panel addTeamPanel;
        private System.Windows.Forms.Button addTeam_btn;
        private System.Windows.Forms.ComboBox coachID_cb;
        private System.Windows.Forms.TextBox rank_txt;
        private System.Windows.Forms.ComboBox sportName_cb;
        private System.Windows.Forms.TextBox teamName_txt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel choicesPanel;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button AddCoach_btn;
        private System.Windows.Forms.Button AddTraining_btn;
        private System.Windows.Forms.Button newTeam_btn;
        private System.Windows.Forms.Button backFromTeamPanel_btn;
        private System.Windows.Forms.Button backFromTrainingPanel_btn;
        private System.Windows.Forms.Button backFormNewCoachPanel_btn;
        private System.Windows.Forms.Panel CoachUpdatePanel;
        private System.Windows.Forms.TextBox confirmPass_txt;
        private System.Windows.Forms.TextBox coachPass_txt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Panel coachProfilePanel;
        private System.Windows.Forms.DataGridView TeamDGV;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView trainingDates_DGV;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button backFromCoachprofile_btn;
        private System.Windows.Forms.Panel coachOptions_Panel;
        private System.Windows.Forms.Button coachProfile_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button restPass_btn;
    }
}

