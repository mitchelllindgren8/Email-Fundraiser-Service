using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailFundProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string conStr = @"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "The username or password field entered is empty.";
                return;
            }

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loginTbl where username ='" + username.ToString() + "' and password = '" + password.ToString() + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblMessage.Text = "";

                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                lblMessage.Text = "The username or password entered is inncorrect.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "user1";
            txtPassword.Text = "password1";
        }
    }
}
