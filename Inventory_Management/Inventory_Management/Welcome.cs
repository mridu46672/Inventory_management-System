namespace Inventory_management
{
    public partial class WellCome_Page : Form
    {
        public WellCome_Page()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // You can leave this empty for now
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            Signup_Form S = new Signup_Form();
            S.Show();
            this.Hide();


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginPage L = new LoginPage();
            L.Show();
            this.Hide();
        }
    }
}
