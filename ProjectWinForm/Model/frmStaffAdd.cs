using System.Collections;

namespace ProjectWinForm.Model
{
    public partial class frmStaffAdd : SampleAdd
    {
        public frmStaffAdd()
        {
            InitializeComponent();
        }
        public int id = 0;

        public override void btnSave_Click(object sender, System.EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into Staff Values(@Name, @Phone, @role)";
            }
            else
            {
                qry = "Update Staff Set StaffName = @Name , StaffPhone = @Phone, StaffRole = @role where StaffId = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@Phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Lưu thành công");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }
    }
}
