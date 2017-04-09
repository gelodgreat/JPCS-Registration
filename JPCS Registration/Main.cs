using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using MySql.Data.MySqlClient;

namespace JPCS_Registration
{
    
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        public string[] course_section = new string[13];
        MySqlConnection conn;
        globalconfig gc = new globalconfig();
        DialogResult addYn;
        public string query;

        public Main()
        {
            InitializeComponent();
        }

        public void courses()
        {
            course_section[0] = "BSIT-1A";
            course_section[1] = "BSIT-2A";
            course_section[2] = "BSIT-3A";
            course_section[3] = "BSIT-4A";
            course_section[4] = "BSCS-1A";
            course_section[5] = "BSCS-2A";
            course_section[6] = "BSCS-3A";
            course_section[7] = "BSCS-4A";
            course_section[8] = "BSCPE-1A";
            course_section[9] = "BSCPE-2A";
            course_section[10] = "BSCPE-3A";
            course_section[11] = "BSCPE-4A";
            course_section[12] = "BSCPE-5A";
        }
        private void Main_Load(object sender, EventArgs e)
        {
                    ManageCourses();
        }

        private void ManageCourses()
        {
            courses();
            reg_cb_coursesect.Items.Clear();
            if (reg_cb_coursesect.SelectedIndex <= 1) {
                foreach (string courses in course_section)
                {
                   
                    reg_cb_coursesect.Items.Add(courses);
                }
            } else
            {
                MessageBox.Show("Empty Fields");
            }
        }

        private void reg_btn_save_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = gc.conn;
            MySqlDataReader reader = default(MySqlDataReader);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                if ((string.IsNullOrEmpty(reg_tb_studno.Text)) | ((string.IsNullOrEmpty(reg_name.Text)) | ((string.IsNullOrEmpty(reg_address.Text)) | ((string.IsNullOrEmpty(reg_cn.Text))| (string.IsNullOrEmpty(reg_cb_coursesect.Text))))))
                {
                    MessageBox.Show("Please fill all fields");

                }
                else
                {                  
                        conn.Open();
                        query = "SELECT * FROM registration WHERE studno=@studno";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("studno", reg_tb_studno.Text);
                        reader = command.ExecuteReader();
                        int count = 0;
                        
                        while (reader.Read())
                        {
                            count += 1;
                        }

                        if (count >= 1)
                        {
                            RadMessageBox.Show(this, "Studno " + reg_tb_studno.Text +  " is already registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                        }
                        else
                        {
                            conn.Close();
                            conn.Open();

                        addYn = addYn = RadMessageBox.Show(this, "Are you sure you want to register?", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                        if (addYn == DialogResult.Yes)
                        {
                            query = "INSERT INTO registration VALUES (@studno,@name,@section,@address,@cn)";
                            command = new MySqlCommand(query, conn);
                            command.Parameters.AddWithValue("studno", reg_tb_studno.Text);
                            command.Parameters.AddWithValue("name", reg_name.Text);
                            command.Parameters.AddWithValue("section", reg_cb_coursesect.Text);
                            command.Parameters.AddWithValue("address", reg_address.Text);
                            command.Parameters.AddWithValue("cn", reg_cn.Text);
                            reader = command.ExecuteReader();

                            RadMessageBox.Show(this, "Successfully Registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                            reg_tb_studno.Clear();
                            reg_tb_studno.Focus();
                            reg_name.Clear();
                            reg_cb_coursesect.SelectedIndex = -1;
                            reg_address.Clear();
                            reg_cn.Clear();
                            
                            conn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Dispose();
            }
         

        }

        private void reg_cn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&&(e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void reg_btn_secnotfound_Click(object sender, EventArgs e)
        {
            reg_cb_coursesect.DropDownStyle = RadDropDownStyle.DropDown;
            timersec.Start();
           
        }
        int i = 0;
        private void timersec_Tick(object sender, EventArgs e)
        {
            i++;
           if (i == 100)
            {
                timersec.Stop();
                reg_cb_coursesect.DropDownStyle = RadDropDownStyle.DropDownList;
                i = 0;
            }
        }


    }
}
