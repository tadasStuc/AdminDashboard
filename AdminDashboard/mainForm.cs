using AdminDashboard.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDashboard
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            ucOverview uc = new ucOverview();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucOverview uc = new ucOverview();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
          ucEmployees ucEmployees = new ucEmployees();
            addUserControl(ucEmployees);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucVendors ucVendors = new ucVendors();
            addUserControl(ucVendors);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucLogout ucLogout = new ucLogout();
            addUserControl(ucLogout);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
