namespace Sport_club_IS
{
    partial class DMForm
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
            this.UpdatePanal = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sportName_txt = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.Informations_DGV = new System.Windows.Forms.DataGridView();
            this.UpdateGB = new System.Windows.Forms.GroupBox();
            this.competitionsInformationRB = new System.Windows.Forms.RadioButton();
            this.TeamsInformationRB = new System.Windows.Forms.RadioButton();
            this.TrainingsInformationRB = new System.Windows.Forms.RadioButton();
            this.LoadInformation_btn = new System.Windows.Forms.Button();
            this.UpdatePanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Informations_DGV)).BeginInit();
            this.UpdateGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdatePanal
            // 
            this.UpdatePanal.Controls.Add(this.search_btn);
            this.UpdatePanal.Controls.Add(this.label1);
            this.UpdatePanal.Controls.Add(this.sportName_txt);
            this.UpdatePanal.Controls.Add(this.back_btn);
            this.UpdatePanal.Controls.Add(this.save_btn);
            this.UpdatePanal.Controls.Add(this.Informations_DGV);
            this.UpdatePanal.Controls.Add(this.UpdateGB);
            this.UpdatePanal.Location = new System.Drawing.Point(45, 4);
            this.UpdatePanal.Name = "UpdatePanal";
            this.UpdatePanal.Size = new System.Drawing.Size(698, 588);
            this.UpdatePanal.TabIndex = 9;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(459, 161);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(147, 28);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sport Name";
            // 
            // sportName_txt
            // 
            this.sportName_txt.Location = new System.Drawing.Point(489, 87);
            this.sportName_txt.Name = "sportName_txt";
            this.sportName_txt.Size = new System.Drawing.Size(145, 22);
            this.sportName_txt.TabIndex = 5;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(46, 550);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(571, 547);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(90, 29);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Informations_DGV
            // 
            this.Informations_DGV.AllowUserToAddRows = false;
            this.Informations_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Informations_DGV.Location = new System.Drawing.Point(46, 236);
            this.Informations_DGV.Name = "Informations_DGV";
            this.Informations_DGV.RowHeadersWidth = 51;
            this.Informations_DGV.RowTemplate.Height = 24;
            this.Informations_DGV.Size = new System.Drawing.Size(615, 284);
            this.Informations_DGV.TabIndex = 2;
            // 
            // UpdateGB
            // 
            this.UpdateGB.Controls.Add(this.competitionsInformationRB);
            this.UpdateGB.Controls.Add(this.TeamsInformationRB);
            this.UpdateGB.Controls.Add(this.TrainingsInformationRB);
            this.UpdateGB.Controls.Add(this.LoadInformation_btn);
            this.UpdateGB.Location = new System.Drawing.Point(33, 27);
            this.UpdateGB.Name = "UpdateGB";
            this.UpdateGB.Size = new System.Drawing.Size(266, 168);
            this.UpdateGB.TabIndex = 0;
            this.UpdateGB.TabStop = false;
            // 
            // competitionsInformationRB
            // 
            this.competitionsInformationRB.AutoSize = true;
            this.competitionsInformationRB.Location = new System.Drawing.Point(23, 100);
            this.competitionsInformationRB.Name = "competitionsInformationRB";
            this.competitionsInformationRB.Size = new System.Drawing.Size(184, 21);
            this.competitionsInformationRB.TabIndex = 2;
            this.competitionsInformationRB.Text = "Competitions information";
            this.competitionsInformationRB.UseVisualStyleBackColor = true;
            // 
            // TeamsInformationRB
            // 
            this.TeamsInformationRB.AutoSize = true;
            this.TeamsInformationRB.Location = new System.Drawing.Point(23, 61);
            this.TeamsInformationRB.Name = "TeamsInformationRB";
            this.TeamsInformationRB.Size = new System.Drawing.Size(146, 21);
            this.TeamsInformationRB.TabIndex = 1;
            this.TeamsInformationRB.Text = "Teams Information";
            this.TeamsInformationRB.UseVisualStyleBackColor = true;
            // 
            // TrainingsInformationRB
            // 
            this.TrainingsInformationRB.AutoSize = true;
            this.TrainingsInformationRB.Checked = true;
            this.TrainingsInformationRB.Location = new System.Drawing.Point(23, 26);
            this.TrainingsInformationRB.Name = "TrainingsInformationRB";
            this.TrainingsInformationRB.Size = new System.Drawing.Size(162, 21);
            this.TrainingsInformationRB.TabIndex = 0;
            this.TrainingsInformationRB.TabStop = true;
            this.TrainingsInformationRB.Text = "Trainings information";
            this.TrainingsInformationRB.UseVisualStyleBackColor = true;
            // 
            // LoadInformation_btn
            // 
            this.LoadInformation_btn.Location = new System.Drawing.Point(52, 134);
            this.LoadInformation_btn.Name = "LoadInformation_btn";
            this.LoadInformation_btn.Size = new System.Drawing.Size(155, 28);
            this.LoadInformation_btn.TabIndex = 1;
            this.LoadInformation_btn.Text = "Load Information";
            this.LoadInformation_btn.UseVisualStyleBackColor = true;
            this.LoadInformation_btn.Click += new System.EventHandler(this.LoadInformation_btn_Click);
            // 
            // DMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 597);
            this.Controls.Add(this.UpdatePanal);
            this.Name = "DMForm";
            this.Text = "DMForm";
            this.UpdatePanal.ResumeLayout(false);
            this.UpdatePanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Informations_DGV)).EndInit();
            this.UpdateGB.ResumeLayout(false);
            this.UpdateGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpdatePanal;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DataGridView Informations_DGV;
        private System.Windows.Forms.Button LoadInformation_btn;
        private System.Windows.Forms.GroupBox UpdateGB;
        private System.Windows.Forms.RadioButton competitionsInformationRB;
        private System.Windows.Forms.RadioButton TeamsInformationRB;
        private System.Windows.Forms.RadioButton TrainingsInformationRB;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sportName_txt;
    }
}