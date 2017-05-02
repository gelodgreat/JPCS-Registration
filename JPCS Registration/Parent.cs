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
    public partial class Parent : Telerik.WinControls.UI.RadForm
    {
        MdiClient ctlMDI;
        Main m = new Main();
        
        public Parent()
        {
            InitializeComponent();
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
            
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            // Display a child form to show this is still an MDI application.
            //Form2 frm = new Form2();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void MemberAdd_Click(object sender, EventArgs e)
        {
            // Display a child form to show this is still an MDI application.
            m.MdiParent = this;
            m.Show();
        }
    }
}
