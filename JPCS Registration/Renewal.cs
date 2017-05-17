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

        MySqlConnection conn;
        globalconfig gc = new globalconfig();   
        public Renewal()
        {
            InitializeComponent();
        }
        
        private void Renewal_Load(object sender, EventArgs e)
        {
            list_coyesec();
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

            //MySqlDataReader reader = default(MySqlDataReader);
            //if (conn.State == ConnectionState.Open)
            //{
            //    conn.Close();
            //}
            //conn.ConnectionString = globalconfig.connstring;
            //try
            //{
            //    conn.Open();
            //    MySqlCommand comm = new MySqlCommand("CALL show_registered_coyesec();", conn);
            //    reader = comm.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        ddlCoyesec.Items.Add(reader.GetString("coyesec"));
            //    }
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
            //finally
            //{
            //    conn.Dispose();
            //}
        
        }
        public void list_coyesec()
        {
            ddlCoyesec.Items.Clear();
            MySqlConnection MySQLConn=new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL show_registered_courseyearsection()", MySQLConn);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    ddlCoyesec.Items.Add(reader.GetString("Course, Year and Section"));
                }
                MySQLConn.Close();
            }catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration");
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
