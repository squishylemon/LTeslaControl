using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTeslaControl
{
    public partial class loginForm : Form
    {
        private string email;
        private string password;
        private bool pass=false;
        public loginForm()
        {
            InitializeComponent();
        }

        private void nextInput_Click(object sender, EventArgs e)
        {
            if (emailInput.Text != "" && pass!=true)
            {
                email=emailInput.Text;
                emailInput.Text = "";
                emailInput.PasswordChar = '*';
                emailInput.UseSystemPasswordChar = true;
                label1.Text = "Password";
                pass = true;
            }
            if (emailInput.Text != "" && pass != false)
            {
                password = emailInput.Text;
                emailInput.Text = "";
                emailInput.Enabled = false;
                emailInput.Visible = false;
                pictureBox1.Visible = false;
                emailInput.UseSystemPasswordChar = false;
                label1.Text = "Attempting Login";
                pass = true;

            }
            
            
        }
    }
}
