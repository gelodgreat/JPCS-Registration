using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls;

namespace JPCS_Registration
{
    public partial class ViewMembers : Telerik.WinControls.UI.RadForm
    {
        public globalconfig gc = new globalconfig();
        String connstring = globalconfig.connstring;
        public DataTable dbdataset_current = new DataTable();
        public DataTable dbdataset_all = new DataTable();

        MySqlConnection MySQLConn = new MySqlConnection();
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            load_all_members();
            load_memberlist();
            lbl_schoolyear.Text = globalconfig.schoolyearactive;
        }
        public void load_memberlist()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            if (MySQLConn.State == ConnectionState.Open)
            {
                MySQLConn.Close();
            }

            MySQLConn.ConnectionString = connstring;
            try
            {
                dbdataset_current.Clear();
                MySQLConn.Open();
                MySqlCommand comm = gc.command;
                comm = new MySqlCommand("CALL show_current_members(@schoolyear);", MySQLConn);
                comm.Parameters.AddWithValue("schoolyear", globalconfig.schoolyearactive);
				//comm = new MySqlCommand("SELECT * FROM memberlist WHERE studno IN (SELECT * FROM test);", MySQLConn);
                adapter.SelectCommand = comm;
                adapter.Fill(dbdataset_current);
                radGridMembers.DataSource = dbdataset_current;
                adapter.Update(dbdataset_current);
                MySQLConn.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }
        public void load_all_members()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (MySQLConn.State == ConnectionState.Open)
            {
                MySQLConn.Close();
            }

            MySQLConn.ConnectionString = connstring;
            try
            {
                dbdataset_all.Clear();
                MySQLConn.Open();
                MySqlCommand comm = gc.command;
                comm = new MySqlCommand("CALL show_all_members();", MySQLConn);
                //comm = new MySqlCommand("SELECT * FROM memberlist WHERE studno IN (SELECT * FROM test);", MySQLConn);
                adapter.SelectCommand = comm;
                adapter.Fill(dbdataset_all);
                radGridAllMembers.DataSource = dbdataset_all;
                adapter.Update(dbdataset_all);
                MySQLConn.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }

        private void radGridMembers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            String OrNum = radGridMembers.MasterView.CurrentRow.Cells["OR Number"].Value.ToString();


            DialogResult ConfirmDelete = RadMessageBox.Show(this, "Are you sure you want to delete the selected student for this semester? This action cannot be undone.", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question);

            if (ConfirmDelete == DialogResult.Yes)
            {
                if (MySQLConn.State == ConnectionState.Open)
                {
                    MySQLConn.Close();
                }
                MySQLConn.ConnectionString = globalconfig.connstring;
                try
                {
                    MySQLConn.Open();
                    MySqlCommand comm = new MySqlCommand("CALL Delete_membership(@ornum);", MySQLConn);
                    comm.Parameters.AddWithValue("ornum", OrNum);
                    comm.ExecuteNonQuery();
                    RadMessageBox.Show(this, "The Membership has been deleted Successfully!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                    MySQLConn.Close();
                }catch (Exception ex)
                {
                    RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                }finally
                {
                    MySQLConn.Dispose();
                }
                load_memberlist();
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = radGridMembers.DataSource;
                bs.Filter = "LastName LIKE '%" + txtSearch.Text + "%'";
                radGridMembers.DataSource = bs;
            }
            
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (txtSearch.Text == "")
            {
                return;
            }
            if (!Regex.IsMatch(txtSearch.Text, @"^[a-zA-Z]+$"))
            {
                RadMessageBox.Show(this, "No Charaters allowed other than Letters!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
        }

        private void txtSearch_All_TextChanged(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = radGridAllMembers.DataSource;
                bs.Filter = "LastName LIKE '%" + txtSearch_All.Text + "%'";
                radGridAllMembers.DataSource = bs;
            }
        }

        private void txtSearch_All_Validating(object sender, CancelEventArgs e)
        {
            if (txtSearch_All.Text == "")
            {
                return;
            }
            if (!Regex.IsMatch(txtSearch_All.Text, @"^[a-zA-Z]+$"))
            {
                RadMessageBox.Show(this, "No Charaters allowed other than Letters!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
        }

        private void radPageViewPage1_Enter(object sender, EventArgs e)
        {
            load_memberlist();
        }

        private void radPageViewPage2_Enter(object sender, EventArgs e)
        {
            load_all_members();
        }
    }
}
