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
        Boolean bdayValue = false;


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
            get_member_ranks_for_the_slot_number();
            reg_tb_ornumber.Focus();
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
                if ((string.IsNullOrEmpty(reg_tb_slotnum.Text)) | (string.IsNullOrEmpty(reg_tb_ornumber.Text)) | (string.IsNullOrEmpty(reg_tb_studno.Text)) | ((string.IsNullOrEmpty(reg_tb_lname.Text)) | ((string.IsNullOrEmpty(reg_tb_fname.Text)) | ((string.IsNullOrEmpty(reg_tb_mname.Text)) | (string.IsNullOrEmpty(reg_cb_coursesect.Text)) | ((string.IsNullOrEmpty(reg_tb_cityaddress.Text)) | ((string.IsNullOrEmpty(reg_tb_contactnum.Text)) | ((string.IsNullOrEmpty(reg_tb_emergencycontactname.Text)) | ((string.IsNullOrEmpty(reg_tb_emergenctcontactnumber.Text)) | (!reg_tb_studno.MaskCompleted) | (!reg_tb_ornumber.MaskCompleted) | (reg_tb_bday.Text.Length==0)))))))))
                {
                    RadMessageBox.Show(this, "Please fill-up all fileds Properly!" + System.Environment.NewLine +""+System.Environment.NewLine+"Check if you have entered the correct format in the OR number and the Student Number.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);

                }
                else
                {                  
                        conn.Open();
                        query = "SELECT * FROM memberlist WHERE studno=@studno";
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
                            RadMessageBox.Show(this, "Student # " + reg_tb_studno.Text +  " is already registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                        }
                        else
                        {
                        conn.Close();
                        conn.Open();
                        query = "SELECT * FROM memberlist where ornumber=@ornumber;";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("ornumber", reg_tb_ornumber.Text);
                        reader = command.ExecuteReader();
                        count = 0;
                        while (reader.Read())
                        {
                            count += 1;
                        }
                        conn.Close();
                        if (count >= 1)
                        {
                            RadMessageBox.Show(this, "OR Number " + reg_tb_ornumber.Text + " is already registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                            return;
                        }
                        addYn = RadMessageBox.Show(this, "Are you sure you want to register?", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                        if (addYn == DialogResult.Yes)
                        {
                            conn.Open();
                            query = "INSERT INTO memberlist VALUES (@slotnum, @ornum, @studno, @lname, @fname, @mname, @section, @emailaddress, @birthday, @nationality, @cityaddress, @provinceaddress, @contactnumber, @emergencycontactname, @emergencycontactnumber);";
                            command = new MySqlCommand(query, conn);
                            command.Parameters.AddWithValue("slotnum", reg_tb_slotnum.Text);
                            command.Parameters.AddWithValue("ornum", reg_tb_ornumber.Text);
                            command.Parameters.AddWithValue("studno", reg_tb_studno.Text);
                            command.Parameters.AddWithValue("lname", reg_tb_lname.Text);
                            command.Parameters.AddWithValue("fname", reg_tb_fname.Text);
                            command.Parameters.AddWithValue("mname", reg_tb_mname.Text);                      
                            command.Parameters.AddWithValue("section", reg_cb_coursesect.Text);
                            command.Parameters.AddWithValue("emailaddress", reg_tb_email.Text);
                            command.Parameters.AddWithValue("birthday", reg_tb_bday.Text);
                            command.Parameters.AddWithValue("nationality", reg_tb_nationality.Text);
                            command.Parameters.AddWithValue("cityaddress", reg_tb_cityaddress.Text);
                            command.Parameters.AddWithValue("provinceaddress", reg_tb_provaddress.Text);
                            command.Parameters.AddWithValue("contactnumber", reg_tb_contactnum.Text);
                            command.Parameters.AddWithValue("emergencycontactname", reg_tb_emergencycontactname.Text);
                            command.Parameters.AddWithValue("emergencycontactnumber", reg_tb_emergenctcontactnumber.Text);
                            //reader = command.ExecuteReader();
                            command.ExecuteNonQuery();

                            RadMessageBox.Show(this, "Successfully Registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                            reg_tb_ornumber.Clear();
                            reg_tb_studno.Clear();
                            reg_tb_slotnum.Focus();
                            reg_tb_lname.Clear();
                            reg_tb_mname.Clear();
                            reg_tb_fname.Clear();
                            reg_cb_coursesect.SelectedIndex = -1;
                            reg_tb_email.Clear();
                            reg_tb_bday.ResetText();
                            reg_tb_nationality.Clear();
                            reg_tb_cityaddress.Clear();
                            reg_tb_provaddress.Clear();
                            reg_tb_contactnum.Clear();
                            reg_tb_emergencycontactname.Clear();
                            reg_tb_emergenctcontactnumber.Clear();
                            reg_tb_bday.ResetText();
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
            get_member_ranks_for_the_slot_number();

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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.Show();
            
        }
        public void get_member_ranks_for_the_slot_number() //This is to automatically assign a slot number for the registered student.
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = gc.conn + "Allow User Variables=True;";
            MySqlDataReader reader = default(MySqlDataReader);
            try
            {
                conn.Open();
                query = "SET @rank=0;SELECT @rank:=@rank+1 AS slot FROM memberlist ORDER BY @rank:=@rank+1 DESC LIMIT 1;";
                command = new MySqlCommand(query, conn);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int compute = reader.GetInt32("slot");
                        compute++;
                        reg_tb_slotnum.Text = compute.ToString();
                    }
                }else
                {
                    reg_tb_slotnum.Text = "1";
                }
            }catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }finally
            {
                conn.Dispose();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Focus())
            {
                reg_tb_bday.Value = dateTimePicker1.Value;
            }
        }

        private void reg_tb_bday_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = reg_tb_bday.Value;
            reg_tb_bday.Focus();
        }
    }
}
