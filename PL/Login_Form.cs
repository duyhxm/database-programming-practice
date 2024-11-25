using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BL;
using System.Data.SqlClient;


namespace PL
{
    public partial class Login_Form : Form
    {
        private string _username = null;
        public bool isLoggedIn;
        public Login_Form()
        {
            isLoggedIn = false;
            InitializeComponent();
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtBx_username.Text.Trim(); //loại bỏ khoảng trắng trong trường hợp user nhập khoảng trắng
            string password = txtBx_password.Text;

            Account acc = new Account(username, password);

            try
            {
                isLoggedIn = new LoginBL().Login(acc);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(isLoggedIn == true)
            {
                _username = username;
                MessageBox.Show("Valid");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
