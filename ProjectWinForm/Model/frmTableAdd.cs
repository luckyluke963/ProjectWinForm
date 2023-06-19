using System.Collections;

namespace ProjectWinForm.Model
{
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }
        public int id = 0;


        public override void btnSave_Click(object sender, System.EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into Ban Values(@Name)";
            }
            else
            {
                qry = "Update Ban Set TableName = @Name where TableId = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Lưu thành công");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }
    }
}
