using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management
{
    public partial class DashboardA : Form
    {
        public DashboardA()
        {
            InitializeComponent();
        }

        private void ProductLbl_Click(object sender, EventArgs e)
        {

        }

        private void ProfileLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WellCome_Page W=new WellCome_Page();
            W.Show();
            this.Hide();
        }
    }
}
