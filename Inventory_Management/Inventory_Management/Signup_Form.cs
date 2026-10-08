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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Reflection;




namespace Inventory_management
{
    public partial class Signup_Form : Form
    {
        public Signup_Form()
        {
            InitializeComponent();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            WellCome_Page W = new WellCome_Page();

            W.Show();
            this.Hide();
        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {

        }

        private void SignupBtn1_Click(object sender, EventArgs e)
        {
            string Id =SignupId.Text;
            string pass = PassText3.Text;
            bool Choice = rdBtn3.Checked;
            bool Choice1 = rdBtn4.Checked;
            Mathods Sm = new Mathods();
            Sm.InsertAsPerson(Id, pass, Choice,Choice1);




            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DELL Inspiron 3511\Documents\Inventory.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True";
           // SqlConnection sqc = new SqlConnection(connection) ;

        }

    }
}
