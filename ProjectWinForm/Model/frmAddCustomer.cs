using System;
using System.Windows.Forms;

namespace ProjectWinForm.Model
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        public string orderType = "";
        public int driverID = 0;
        public string cusName = "";

        public int mainID = 0;


        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            if (orderType == "Take Away")
            {
                lblDriver.Visible = false;
                cbRriver.Visible = false;
            }

            string qry = "Select StaffId 'id', StaffName 'name' from Staff where StaffRole = 'Driver'";
            MainClass.CBFill(qry, cbRriver);

            if (mainID > 0)
            {
                cbRriver.SelectedValue = driverID;
            }
        }

        private void cbRriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverID = Convert.ToInt32(cbRriver.SelectedValue);
        }
    }
}
