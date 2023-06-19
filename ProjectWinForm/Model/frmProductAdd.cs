using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectWinForm.Model
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;

        private void frmProductAdd_Load(object sender, System.EventArgs e)
        {
            string qry = "Select CateId 'id', CateName 'name' from Category ";
            MainClass.CBFill(qry, cbCategory);
            if (cID > 0) //for update
            {
                cbCategory.SelectedValue = cID;
            }

            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }
        string filePath;
        Byte[] imageByteArray;
        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);
            }
        }
        public override void btnSave_Click(object sender, System.EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into Products Values(@Name, @price, @cat, @img)";
            }
            else
            {
                qry = "Update Products Set ProductName = @Name , ProductPrice = @price, CategoryId = @cat, ProductImage = @img where ProductId = @id";
            }

            //for image
            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(cbCategory.SelectedValue));
            ht.Add("@img", imageByteArray);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Lưu thành công");
                id = 0;
                cID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                cbCategory.SelectedIndex = 0;
                cbCategory.SelectedIndex = -1;
                txtImage.Image = ProjectWinForm.Properties.Resources.icons8_basket_64;
                txtName.Focus();
            }
        }

        private void ForUpdateLoadData()
        {
            string qry = @"Select * from Products where ProductId = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["ProductName"].ToString();
                txtPrice.Text = dt.Rows[0]["ProductPrice"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["ProductImage"]);
                byte[] imageByteArray = imageArray;
                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

    }
}
