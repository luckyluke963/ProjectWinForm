using ProjectWinForm.ConnectSql;
using ProjectWinForm.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectWinForm
{
    public partial class frmLogin : Form
    {
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public frmLogin()
        {
            InitializeComponent();
            location[0] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_1.jpg";
            location[1] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_2.jpg";
            location[2] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_3.jpg";
            location[3] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_4.jpg";
            location[4] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_5.jpg";
            location[5] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_6.jpg";
            location[6] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_7.jpg";
            location[7] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_8.jpg";
            location[8] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_9.jpg";
            location[9] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_10.jpg";
            location[10] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_11.jpg";
            location[11] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_12.jpg";
            location[12] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_13.jpg";
            location[13] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_14.jpg";
            location[14] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_15.jpg";
            location[15] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_16.jpg";
            location[16] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_17.jpg";
            location[17] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_18.jpg";
            location[18] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_19.jpg";
            location[19] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_20.jpg";
            location[20] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_21.jpg";
            location[21] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_22.jpg";
            location[22] = @"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_user_23.jpg";
            diapo();
        }


        private void diapo()
        {
            for (int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
        }

        private void txtUserName_TextChanged(object sender, System.EventArgs e)
        {
            if (txtUserName.Text.Length > 0 && txtUserName.Text.Length <= 15)
            {
                pictureBox3.Image = images[txtUserName.Text.Length - 1];
                pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtUserName.Text.Length < 0)
                pictureBox3.Image = Properties.Resources.debut;
            else pictureBox3.Image = images[22];
        }

        private void txtUserName_Click(object sender, System.EventArgs e)
        {
            if (txtUserName.Text.Length > 0)
            {
                pictureBox3.Image = images[txtUserName.Text.Length - 1];
            }
            else
            {
                pictureBox3.Image = Properties.Resources.debut;
            }

        }

        private void txtPassword_Click(object sender, System.EventArgs e)
        {
            Bitmap bm = new Bitmap(@"D:\Học tập\WindowForm\ProjectWinForm\ProjectWinForm\Resources\animation\textbox_password.png");
            pictureBox3.Image = bm;
        }

        private void label8_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        Modify modify = new Modify();

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (userName.Trim() == "" || password.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản!"); }
            else
            {
                string query = "Select * from TaiKhoan where UserName = '" + userName + "' and Password = '" + password + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    if (userName == "admin")
                    {
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.Show();
                    }
                    else
                    {
                        frmPOSuser frm = new frmPOSuser();
                        frm.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!");
                }
            }

        }

        private void lblRegister_Click(object sender, System.EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmLogin frmLogin = new frmLogin();
            frmRegister.Show();
            this.Hide();



        }


        private void lblForgotPassword_Click(object sender, System.EventArgs e)
        {
            frmForgetPassword frmForgetPassword = new frmForgetPassword();
            frmForgetPassword.Show();
            this.Hide();
        }
    }
}
