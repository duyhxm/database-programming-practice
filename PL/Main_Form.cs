using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Show();

            Login_Form loginForm = new Login_Form();
            loginForm.FormClosed += new FormClosedEventHandler(LoginForm_FormClosed);
            loginForm.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login_Form loginForm = sender as Login_Form;

            if (loginForm != null && !loginForm.isLoggedIn)
            {
                //xử lý khi đăng nhập không thành công
            }
            else
            {
                this.Enabled = true;
                txtBx_message.Text = "Welcome " + loginForm.Username;
            }
        }
    }
}
