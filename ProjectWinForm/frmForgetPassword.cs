using ProjectWinForm.ConnectSql;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectWinForm
{
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        Modify modify = new Modify();
        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            string email = txtEmailRegistration.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    lblResult.ForeColor = Color.Blue;
                    lblResult.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].Password1;
                }
                else
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "Email này chưa được đăng kí!";
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
