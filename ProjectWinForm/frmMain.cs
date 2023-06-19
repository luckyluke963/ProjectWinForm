using ProjectWinForm.ConnectSql;
using ProjectWinForm.Model;
using ProjectWinForm.View;
using System;
using System.Windows.Forms;

namespace ProjectWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //for accessing formMain
        static frmMain _obj;
        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }
        }


        // Methord to add Controls in Main form
        public void AddControls(Form f)
        {
            guna2Panel2.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            guna2Panel2.Controls.Add(f);
            f.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.UserName1;
            _obj = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            AddControls(new frmTableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaffView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            AddControls(new frmKitchenView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AddControls(new frmReports());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();

            frmLogin.Show();
            this.Hide();
        }
    }
}
