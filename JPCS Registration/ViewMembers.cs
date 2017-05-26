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
        public String selected;
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
            selected = "";
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
            selected = "";
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
                radGridAllMembers.ClearSelection();
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
                    MySqlCommand comm = new MySqlCommand("CALL Delete_membership(@ornum, @schoolyear);", MySQLConn);
                    comm.Parameters.AddWithValue("ornum", OrNum);
                    comm.Parameters.AddWithValue("schoolyear", globalconfig.schoolyearactive);
                    comm.ExecuteNonQuery();
                    RadMessageBox.Show(this, "The Membership has been deleted Successfully!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                    MySQLConn.Close();
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                }
                finally
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

        private void radGridAllMembers_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //String studno;
            //if (e.RowIndex>0)
            //{
            //    Telerik.WinControls.UI.GridViewRowInfo row = this.radGridAllMembers.Rows[e.RowIndex];

            //    row = this.radGridAllMembers.Rows[e.RowIndex];
            //    studno = row.Cells["Student Number"].Value.ToString();



        }

        private void radGridAllMembers_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            globalconfig.selection = "";
            if (e.RowIndex >= 0)
            {
                Telerik.WinControls.UI.GridViewRowInfo row = this.radGridAllMembers.Rows[e.RowIndex];


                row = this.radGridAllMembers.Rows[e.RowIndex];
                selected = row.Cells["Student Number"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selected != "")
            {
                globalconfig.selection = selected;
                Main edit = new Main();
                edit.MdiParent = this.MdiParent;
                globalconfig.Mainaction = "edit";
                edit.WindowState = FormWindowState.Normal;
                edit.StartPosition = FormStartPosition.CenterParent;
                edit.Show();
                edit.WindowState = FormWindowState.Normal;
                this.Dispose();
            }
            else
            {
                RadMessageBox.Show(this, "Please select a student first!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void btnStat_Click(object sender, EventArgs e)
        {

        }
        private void copyCurrenttoClipboard()
        {
            radGridMembers.MultiSelect = true;
            radGridMembers.SelectAll();
            DataObject dataObj = radGridMembers.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            radGridMembers.MultiSelect = false;
        }
        private void copyAlltoClipboard()
        {
            radGridAllMembers.MultiSelect = true;
            radGridAllMembers.SelectAll();
            DataObject dataObj = radGridAllMembers.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            radGridAllMembers.MultiSelect = false;
        }

        private void btnCopyRows_Click(object sender, EventArgs e)
        {
            copyCurrenttoClipboard();

            try
            {
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected != "")
            {
                globalconfig.selection = selected;

                DialogResult confirmdelete = RadMessageBox.Show(this, "Are you sure you want to delete the selected student? Deleting a student also deletes all of his records on all School Year. This action cannot be undone.", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                if (confirmdelete == DialogResult.Yes)
                {
                    MySqlConnection MySQLConn = new MySqlConnection();
                    MySQLConn.ConnectionString = globalconfig.connstring;

                    try
                    {
                        MySQLConn.Open();
                        MySqlCommand comm = new MySqlCommand("CALL Delete_student(@studno);", MySQLConn);
                        comm.Parameters.AddWithValue("studno", globalconfig.selection);
                        comm.ExecuteNonQuery();
                        RadMessageBox.Show(this, "The student has been successfully removed from the records.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                        MySQLConn.Close();

                    }
                    catch (Exception ex)
                    {
                        RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                    finally
                    {
                        MySQLConn.Dispose();
                    }

                }
            }else
            {
                RadMessageBox.Show(this, "Please select a row first!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void btnStatCurrent_Click(object sender, EventArgs e)
        {
            int totalMoney = 0;
            for (int i = 0; i < radGridMembers.Rows.Count; ++i)
            {
                totalMoney += Convert.ToInt32(radGridMembers.Rows[i].Cells["Payment"].Value);
            }
            globalconfig.currentTotal = radGridMembers.Rows.Count;
            globalconfig.totalMoney = totalMoney;
            Statistics stat = new Statistics();
            stat.ShowDialog();
            
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            if (selected != "")
            {
                globalconfig.selection = selected;
                StudentRecord sr = new StudentRecord();
                sr.ShowDialog();
            }else
            {
                RadMessageBox.Show(this, "Please select a row first!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            {
                copyAlltoClipboard();

                try
                {
                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Microsoft.Office.Interop.Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
        }

        private void radGridAllMembers_Click(object sender, EventArgs e)
        {

        }
    }
}
