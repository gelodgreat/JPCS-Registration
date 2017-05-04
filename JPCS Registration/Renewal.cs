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
    public partial class Renewal : Telerik.WinControls.UI.RadForm
    {
        public Renewal()
        {
            InitializeComponent();
        }
        
        private void Renewal_Load(object sender, EventArgs e)
        {

        }

        private void txt_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            String deci = ".";
            if (txt_payment.Text.Contains("."))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
            else
            {
                e.Handled = (char.IsDigit(e.KeyChar).Equals(false) | (e.KeyChar=Convert.ToChar(deci)).Equals(false));

            }
        }
    }
}
