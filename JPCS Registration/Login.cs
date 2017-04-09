using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace JPCS_Registration
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void log_btn_login_Click(object sender, EventArgs e)
        {
            Main MainForm = new Main();
            this.Hide();
            MainForm.ShowDialog();
         }

        private void log_btn_main_Click(object sender, EventArgs e)
        {
            OfficersPage op = new OfficersPage();
            op.Show();
            this.Hide();
        }
    }
}
