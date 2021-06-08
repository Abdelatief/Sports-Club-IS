using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Sport_club_IS
{
    public partial class Form1 : Form
    {


        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
            addTrainingPanel.Visible = false;
            addcoachPanel.Visible = false;
            addTeamPanel.Visible = false;
            coachProfilePanel.Visible = false;
            choicesPanel.Visible = false;
          conn = new OracleConnection(ordb);
            conn.Open();

            // test
            //CFNameTxt.Text = "Mark";
            //CLNameTxt.Text = "Ruffalo";
            //CSalaryTxt.Text = "123";
            //CAddressTxt.Text = "new york";
            //CSportNameTxt.Text = "Handball";
            //// CBdPicker.Text = "22-04-1998";
            //CPhoneNumTxt.Text = "01225896684";

        }

        private void InsertTraningPanel_Paint(object sender, PaintEventArgs e)
        {

            // DatePicker Validation
            DateAddTraningPicker.MinDate = DateTime.UtcNow.Date;
            DateAddTraningPicker.MaxDate = DateTime.UtcNow.Date.AddYears(1);


        }

        private void AddNewTraning_Click(object sender, EventArgs e)
        {
            if (AddSportNameTxt.Text == "")
            {
                MessageBox.Show("Please enter sport name");

            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //enter colunms with the same arrange on database 
                cmd.CommandText = "insert into Training  values (Trainingid_auto_inc.nextval,TO_DATE(:trainingDate, 'dd/MM/yyyy'),:sportName)";
                cmd.Parameters.Add("trainingDate", DateAddTraningPicker.Text);
                cmd.Parameters.Add("sportName", AddSportNameTxt.Text);

                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("New training is added");
                    AddSportNameTxt.Text = "";
                    DateAddTraningPicker.Text = DateTime.Now.ToString();
                }
            }

        }

     
        private void AddCoachbtn_Click(object sender, EventArgs e)
        {
            if (CFNameTxt.Text == "" || CLNameTxt.Text == "" || CSalaryTxt.Text == "" || CAddressTxt.Text == "" || CSportNameTxt.Text == "" || CBdPicker.Text == "")
            {
                MessageBox.Show("Please complete coach data");
            }
            else
            {
                if (CPhoneNumTxt.Text.Length < 11 || CPhoneNumTxt.Text.ElementAt(0) != '0' || CPhoneNumTxt.Text.ElementAt(1) != '1')
                {
                    MessageBox.Show("Please correct phone number");

                }
                else
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into COACH values (COACHID.nextval,:FirstName,:lastName,:coachPass,:salary,:address,:sportName,TO_DATE(:bd, 'dd/MM/yyyy'),:phoneNum)";
                  //  cmd.CommandText = $"insert into COACH values (COACHID.nextval, '{CFNameTxt.Text}', '{CLNameTxt.Text}', '123', {float.Parse(CSalaryTxt.Text)}, '{CAddressTxt.Text}', '{CSportNameTxt.Text}', TO_DATE('{CBdPicker.Text}', 'dd/MM/yyyy'), '{CPhoneNumTxt.Text}')";
                    cmd.Parameters.Add("FirstName", CFNameTxt.Text);
                    cmd.Parameters.Add("lastName", CLNameTxt.Text);
                    cmd.Parameters.Add("coachPass", "123");
                    cmd.Parameters.Add("salary", float.Parse(CSalaryTxt.Text));
                    cmd.Parameters.Add("address", CAddressTxt.Text);
                    cmd.Parameters.Add("sportName", CSportNameTxt.Text);
                    cmd.Parameters.Add("bd", CBdPicker.Text);
                    cmd.Parameters.Add("phoneNum", CPhoneNumTxt.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("New coach is added");
                        CFNameTxt.Text = "";
                        CLNameTxt.Text = "";
                        CSalaryTxt.Text = "";
                        CAddressTxt.Text = "";
                        CSportNameTxt.Text = "";
                        CBdPicker.Text = "";
                        CPhoneNumTxt.Text = "";
                    }

                }
            }

        }



        private void CPhoneNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //8 is enumeration for backspace key

            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void CSalaryTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //8 is enumeration for backspace key
            //46 is enumeration for Del key
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

       

    

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            
        }

        private void addTeamPanel_Paint(object sender, PaintEventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "select SPORT_NAME from training";
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "GetSportName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("sportName", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sportName_cb.Items.Add(dr[0]);
            }

              OracleCommand cmd2 = new OracleCommand();
               cmd2.Connection = conn;
               cmd2.CommandText = "GetCoachID";
               cmd2.CommandType = CommandType.StoredProcedure;
               cmd2.Parameters.Add("coach_id", OracleDbType.RefCursor, ParameterDirection.Output);
               dr = cmd2.ExecuteReader();
               while (dr.Read())
               {
                   coachID_cb.Items.Add(dr[0]);
               }
               dr.Close();
        }

        private void addTeam_btn_Click(object sender, EventArgs e)
        {
           
            if (teamName_txt.Text == "" || sportName_cb.Text == "" || rank_txt.Text == "" || coachID_cb.Text == "")
            {
                MessageBox.Show("Please complete coach data");
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"insert into team values (TEAMID.nextval, '{teamName_txt.Text}', '{sportName_cb.SelectedItem.ToString()}', '{rank_txt.Text}', '{coachID_cb.SelectedItem.ToString()}')";
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("New team is added");
                    teamName_txt.Text = "";
                    sportName_cb.SelectedIndex = -1;
                    rank_txt.Text = "";
                    coachID_cb.SelectedIndex = -1;
                }
            }
        }

        private void rank_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //8 is enumeration for backspace key
            //46 is enumeration for Del key
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
             Hide();
           // System.Windows.Forms.Application.Exit();
            DMForm form = new DMForm();
            form.Show();
        }

        private void newTeam_btn_Click(object sender, EventArgs e)
        {
            addTeamPanel.Visible = true;
            choicesPanel.Visible = false;

        }

        private void AddTraining_btn_Click(object sender, EventArgs e)
        {
            addTrainingPanel.Visible = true;
            choicesPanel.Visible = false;
        }

        private void AddCoach_btn_Click(object sender, EventArgs e)
        {
            addcoachPanel.Visible = true;
            choicesPanel.Visible = false;
        }

        private void backFromTeamPanel_btn_Click(object sender, EventArgs e)
        {
            addTeamPanel.Visible = false;
            choicesPanel.Visible = true;
        }

        private void backFromTrainingPanel_btn_Click(object sender, EventArgs e)
        {
            addTrainingPanel.Visible = false;
            choicesPanel.Visible = true;
        }

        private void backFormNewCoachPanel_btn_Click(object sender, EventArgs e)
        {
            addcoachPanel.Visible = false;
            choicesPanel.Visible = true;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (coachPass_txt.Text == "" || confirmPass_txt.Text == "")
            {
                MessageBox.Show("Please complete data");
            }
            else if (coachPass_txt.Text != confirmPass_txt.Text)
            {
                MessageBox.Show("confirm password doesn't match password");
            }
            else
            {
               OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update coach set COACHPASSWORD = :pass where CoachID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("pass", coachPass_txt.Text);
                //TODO::change 41 by login
                cmd.Parameters.Add("id", 41);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Updated");
                    coachPass_txt.Text = "";
                    confirmPass_txt.Text = "";
                }

            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            coachProfilePanel.Visible = true;
            CoachUpdatePanel.Visible = false;
        }
    }
}
