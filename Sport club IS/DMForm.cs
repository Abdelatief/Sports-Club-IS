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

namespace Sport_club_IS
{
    public partial class DMForm : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds = new DataSet();
        string connstr = "Data Source=ORCL;User Id=hr;Password=hr;";
        string cmdstr = "";
        public DMForm()
        {
            InitializeComponent();
        }

        private void LoadInformation_btn_Click(object sender, EventArgs e)
        {

            if (TrainingsInformationRB.Checked)
                cmdstr = "select * from training";
            else if (TeamsInformationRB.Checked)
                cmdstr = "select * from team";
            else if (competitionsInformationRB.Checked)
                cmdstr = "select * from COMPETITION";
               
            adapter = new OracleDataAdapter(cmdstr, connstr);
            ds = new DataSet();
            adapter.Fill(ds);
            Informations_DGV.DataSource = ds.Tables[0];
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
         
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Saved");

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
          
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (TrainingsInformationRB.Checked)
                cmdstr = @"select * from training where Sport_Name = :name";
            else if (TeamsInformationRB.Checked)
                cmdstr = @"select * from team where Sport_Name = :name";
            else if (competitionsInformationRB.Checked)
                cmdstr = @"select * from competition where SportName = :name";
            adapter = new OracleDataAdapter(cmdstr, connstr);
            adapter.SelectCommand.Parameters.Add("name", sportName_txt.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            Informations_DGV.DataSource = ds.Tables[0];

        }

      
    }
}
