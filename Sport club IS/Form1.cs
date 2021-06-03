using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

// change 1
// change 2

namespace Sport_club_IS
{
    public partial class Form1 : Form
    {

        
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn;
     
        public Form1()
        {
            InitializeComponent();
            InsertTraningPanel.Visible = false;
           // AddcoachPanel.Visible = false;
            conn = new OracleConnection(ordb);
            conn.Open();
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
            else {
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddCoachbtn_Click(object sender, EventArgs e)
        {
            if(CFNameTxt.Text == "" || CLNameTxt.Text == "" || CSalaryTxt.Text == "" || CAddressTxt.Text == "" || CSportNameTxt.Text == "" || CBdPicker.Text == "")
            {
                MessageBox.Show("Please complete coach data");
            }
            else {
                if (CPhoneNumTxt.Text.Length < 11 || CPhoneNumTxt.Text.ElementAt(0) != '0' ||  CPhoneNumTxt.Text.ElementAt(1) != '1')
                {
                    MessageBox.Show("Please correct phone number");

                }
                else
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into COACH values (COACHID.nextval,:FirstName,:lastName,:coachPass,:salary,:address,:sportName,TO_DATE(:bd, 'dd/MM/yyyy'),:phoneNum)";
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

        private void CSalaryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateAddTraningPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CPhoneNumTxt_TextChanged(object sender, EventArgs e)
        {
      
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

        private void AddcoachPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
