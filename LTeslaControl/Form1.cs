namespace LTeslaControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
        }
    }
}