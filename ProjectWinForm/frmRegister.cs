using ProjectWinForm.ConnectSql;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectWinForm
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        public bool checkAccount(string account) //check mat khau va tai khoan
        {
            return Regex.IsMatch(account, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string name = txtName.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Vui lỏng xác nhận mật khẩu chính xác!");
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
                return;
            }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đặng ký, vui lòng đăng ký email khác");
                return;
            }
            try
            {
                string query = "Insert into TaiKhoan values ('" + userName + "','" + password + "','" + email + "','" + phone + "','" + name + "')";
                modify.Comand(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
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
