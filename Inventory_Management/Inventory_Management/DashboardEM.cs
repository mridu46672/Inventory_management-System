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
    public partial class DashboardEM : Form
    {
        public DashboardEM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WellCome_Page W = new WellCome_Page();
            W.Show();
            this.Hide();
        }
    }
}
