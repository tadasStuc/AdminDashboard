using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDashboard.UserControls
{
    public partial class ucEmployees : UserControl
    {
        public ucEmployees()
        {
            InitializeComponent();
      
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            var employeeAdd = new employeeAdd();
            employeeAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

     
    }
}
