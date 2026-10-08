using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management
{

    public partial class LoginPage : Form
    {
      
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginusername_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn1_Click(object sender, EventArgs e)
        {
            WellCome_Page W = new WellCome_Page();
            W.Show();
            this.Hide();
        }

        private void LoginBtn1_Click(object sender, EventArgs e)
        {
            string userid = nameText2.Text;
            string pass = PassText3.Text;
            bool Choice = radioButton3.Checked;
            bool choice1 = radioButton4.Checked;
            Mathods m = new Mathods();
            m.ValidateLogin(userid, pass, Choice, choice1);
            DashboardA D1 = new DashboardA();
            DashboardEM D2 = new DashboardEM();

            if (m.validateresult())
            {
                if (Choice)
                {
                    D1.Show();
                    this.Hide();
                }
                else if (choice1)
                {
                    D2.Show();
                    this.Hide();
                }

            }


        }
            
          
                  

        private void PassText2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
