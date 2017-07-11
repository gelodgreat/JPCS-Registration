using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using MySql.Data.MySqlClient;

namespace JPCS_Registration
{
    public partial class Renewal : Telerik.WinControls.UI.RadForm
    {

        
        globalconfig gc = new globalconfig();
        

        public Renewal()
        {
            InitializeComponent();
        }
        
        private void Renewal_Load(object sender, EventArgs e)
        {
            list_coyesec();
            AcceptButton = btnRegister;
            lblSchoolYear.Text = "S.Y. " + globalconfig.schoolyearactive;
        }

        private void txt_payment_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (txt_payment.Text.Contains("."))
            //{
            //    e.Handled = !(char.IsDigit(e.KeyChar));
            //}
            //else
            //{
            //    e.Handled = (char.IsDigit(e.KeyChar).Equals(false) | (e.KeyChar=Convert.ToChar(deci)).Equals(false));

            //}

            if (txt_payment.Text.Contains("."))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
            else
            {
                e.Handled = !(char.IsDigit(e.KeyChar) | e.KeyChar == '.');

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult registerResponse=new DialogResult();
            if (!(mtbStudNum.MaskCompleted) | !(mtbOrNum.MaskCompleted))
            {
                RadMessageBox.Show(this, "Please Complete Student Number and OR number.");
                return;
            }
            MySqlConnection MySQLConn=new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL renew(@studno, @ornum, @coyesec, @payment, @schoolyear);", MySQLConn);
                comm.Parameters.AddWithValue("studno", mtbStudNum.Text);
                comm.Parameters.AddWithValue("ornum", mtbOrNum.Text);
                comm.Parameters.AddWithValue("coyesec", ddlCoyesec.Text);
                comm.Parameters.AddWithValue("payment", txt_payment.Text);
                comm.Parameters.AddWithValue("schoolyear", globalconfig.schoolyearactive);
                comm.ExecuteNonQuery();
                MySQLConn.Close();
                RadMessageBox.Show(this, "Successfully Registered!. You may now proceed to Advising section.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                mtbStudNum.Clear();
                mtbOrNum.Clear();
                txt_payment.Clear();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("foreign"))
                {
                    registerResponse=RadMessageBox.Show(this, "You are not yet registered to the student list. Please register first!", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Exclamation);
                }
                else
                {
                    RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                }
                
                
            }finally
            {
                MySQLConn.Dispose();
            }
            if (registerResponse == DialogResult.Yes)
            {
                globalconfig.Mainaction = "add";
                Main norecord = new Main();
                norecord.MdiParent = this.MdiParent;
                norecord.Show();
                this.Dispose();
            }
        
        }
        public void list_coyesec()
        {
            ddlCoyesec.Items.Clear();
            MySqlConnection MySQLConn=new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL get_registered_courseyearsection()", MySQLConn);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    ddlCoyesec.Items.Add(reader.GetString("Course, Year and Section"));
                }
                MySQLConn.Close();
            }catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }

        private void txt_payment_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txt_payment.Text.Length > 0)
                {
                    txt_payment.Text = txt_payment.Text.Substring(0, txt_payment.Text.Length - 1);
                    txt_payment.Select(txt_payment.Text.Length, 0);
                }

            }
        }
    }
}
