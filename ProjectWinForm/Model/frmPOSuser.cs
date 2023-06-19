using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectWinForm.Model
{
    public partial class frmPOSuser : Form
    {
        public frmPOSuser()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        public string OrderType = "";
        public int driverID = 0;
        public string customerName = "";
        public string customerPhone = "";


        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCateogory();

            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddCateogory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();
            Guna.UI2.WinForms.Guna2Button b2 = new Guna.UI2.WinForms.Guna2Button();
            b2.FillColor = Color.FromArgb(50, 55, 89);
            b2.Size = new Size(134, 45);
            b2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            b2.Text = "All Categories";
            b2.CheckedState.FillColor = Color.FromArgb(241, 85, 126);
            b2.Click += new EventHandler(_Click);
            CategoryPanel.Controls.Add(b2);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["CateName"].ToString();
                    b.CheckedState.FillColor = Color.FromArgb(241, 85, 126);
                    b.Click += new EventHandler(_Click);

                    CategoryPanel.Controls.Add(b);

                }


            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;

            if (b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.ProductCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, String proID, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                ProductPName = name,
                ProductPrice = price,
                ProductCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                bool isExist = false;

                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        // Sản phẩm đã tồn tại trong DataGridView, cập nhật số lượng và giá trị tương ứng
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                            double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        isExist = true;
                        break;
                    }
                }

                if (!isExist)
                {
                    // Sản phẩm chưa tồn tại trong DataGridView, thêm một hàng mới cho sản phẩm đó
                    guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.ProductPName, 1, wdg.ProductPrice, wdg.ProductPrice });
                }

                GetTotal();
            };

        }



        private void LoadProducts()
        {
            string qry = "Select * from Products inner join Category on CateId = CategoryId";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["ProductImage"];
                byte[] imagebyarray = imagearray;
                AddItems("0", item["ProductId"].ToString(), item["ProductName"].ToString(), item["CateName"].ToString(),
                        item["ProductPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in CategoryPanel.Controls)
            {
                if (item is Guna.UI2.WinForms.Guna2Button)
                {
                    Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)item;
                    b.Checked = false;
                }
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.ProductPName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }


        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = tot.ToString("N2");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Delivery";

            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlurBackground(frm);

            if (frm.txtName.Text != "")
            {
                driverID = frm.driverID;
                lblDriverName.Text = "Customer Name: " + frm.txtName.Text + " Phone: " + frm.txtPhone.Text + " Driver: " + frm.cbRriver.Text;
                lblDriverName.Visible = true;

                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Take Away";

            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlurBackground(frm);

            if (frm.txtName.Text != "")
            {
                driverID = frm.driverID;
                lblDriverName.Text = "Customer Name: " + frm.txtName.Text + " Phone: " + frm.txtPhone.Text;
                lblDriverName.Visible = true;

                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;
            }
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "Din In";
            lblDriverName.Visible = false;

            frmTableSelect frm = new frmTableSelect();
            MainClass.BlurBackground(frm);
            if (frm.TableName != "")
            {
                lblTable.Text = frm.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }



            frmWaiterSelect frm2 = new frmWaiterSelect();
            MainClass.BlurBackground(frm2);
            if (frm2.waiterName != "")
            {
                lblWaiter.Text = frm2.waiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }
        }

        private void btnKOT_Click(object sender, EventArgs e)
        {
            //luu du lieu vao database
            string qry1 = "";
            string qry2 = "";

            int detailID = 0;

            if (MainID == 0)
            {
                qry1 = @"Insert into Main Values(@aDate,@aTime,@TableName,@WaiterName,
                        @status, @orderType, @total, @received, @change, @driverID, @CustName, @CustPhone);
                            Select SCOPE_IDENTITY()";

            }
            else
            {
                qry1 = @"Update Main Set status = @status, total = @total ,
                           received =@received, change = @change where MainID = @ID";
            }




            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }

            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0)
                {
                    qry2 = @"Insert into Details Values(@MainID,@proID,@qty,@price,@amount)";
                }
                else
                {
                    qry2 = @"Update Details Set proID = @proID, qty = @qty, price = @price, amount = @amount
                                where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();

                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            }

            guna2MessageDialog1.Show("Goods received");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;

            lblTotal.Text = "00";
            lblDriverName.Text = "";
        }

        public int id = 0;

        private void btnBill_Click(object sender, EventArgs e)
        {

            frmBillList frm = new frmBillList();

            MainClass.BlurBackground(frm);

            if (frm.MainID > 0)
            {
                id = frm.MainID;
                MainID = frm.MainID;
                LoadEntries();
            }

        }

        private void LoadEntries()
        {
            string qry = @"Select * from Main m 
                            inner join Details d on m.MainID = d.MainID
                            inner join Products p on p.ProductId = d.proID
                                where m.MainID = " + id + "";
            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);


            if (dt2.Rows[0]["orderType"].ToString() == "Delivery")
            {
                btnDelivery.Checked = true;
                lblWaiter.Visible = false;
                lblTable.Visible = false;

            }
            else if (dt2.Rows[0]["orderType"].ToString() == "Take away")
            {
                btnTake.Checked = true;
                lblWaiter.Visible = false;
                lblTable.Visible = false;
            }
            else
            {
                btnDin.Checked = true;
                lblWaiter.Visible = true;
                lblTable.Visible = true;

            }

            guna2DataGridView1.Rows.Clear();

            foreach (DataRow item in dt2.Rows)
            {

                lblTable.Text = item["TableName"].ToString();
                lblWaiter.Text = item["WaiterName"].ToString();

                string detailid = item["DetailID"].ToString();
                string proName = item["ProductName"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = { 0, detailid, proid, proName, qty, price, amount };
                guna2DataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.MainID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);

            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00";
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            //luu du lieu vao database
            string qry1 = "";
            string qry2 = "";

            int detailID = 0;

            if (OrderType == "")
            {
                guna2MessageDialog1.Show("Please select order type");
                return;
            }

            if (MainID == 0)
            {
                qry1 = @"Insert into Main Values(@aDate,@aTime,@TableName,@WaiterName,
                        @status, @orderType, @total, @received, @change, @driverID, @CustName, @CustPhone);
                            Select SCOPE_IDENTITY()";

            }
            else
            {
                qry1 = @"Update Main Set status = @status, total = @total ,
                           received =@received, change = @change where MainID = @ID";
            }




            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }

            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0)
                {
                    qry2 = @"Insert into Details Values(@MainID,@proID,@qty,@price,@amount)";
                }
                else
                {
                    qry2 = @"Update Details Set proID = @proID, qty = @qty, price = @price, amount = @amount
                                where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();

                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            }

            guna2MessageDialog1.Show("Goods received");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;

            lblTotal.Text = "00";
            lblDriverName.Text = "";
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

                if (guna2MessageDialog1.Show("Are you are want to delete?") == DialogResult.Yes) // thay đổi từ Show() sang ShowDialog()
                {
                    int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;
                    guna2DataGridView1.Rows.RemoveAt(rowIndex);
                    if (guna2DataGridView1.CurrentRow != null && guna2DataGridView1.CurrentRow.Cells["dgvid"] != null)
                    {
                        int id;
                        if (int.TryParse(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value.ToString(), out id))
                        {
                            string qry = "Delete from Main where MainID = " + id + "";
                            string qry2 = "Delete from Details where MainID = " + id + "";
                            Hashtable ht = new Hashtable();
                            MainClass.SQL(qry, ht);
                            if (MainClass.SQL(qry2, ht) > 0)
                            {
                                // code xử lý thành công
                            }
                        }
                    }
                    GetTotal();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            GetTotal();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //luu du lieu vao database
            string qry1 = "";
            string qry2 = "";

            int detailID = 0;

            if (MainID == 0)
            {
                qry1 = @"Insert into Main Values(@aDate,@aTime,@TableName,@WaiterName,
                        @status, @orderType, @total, @received, @change, @driverID, @CustName, @CustPhone);
                            Select SCOPE_IDENTITY()";

            }
            else
            {
                qry1 = @"Update Main Set status = @status, total = @total ,
                           received =@received, change = @change where MainID = @ID";
            }




            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }

            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0)
                {
                    qry2 = @"Insert into Details Values(@MainID,@proID,@qty,@price,@amount)";
                }
                else
                {
                    qry2 = @"Update Details Set proID = @proID, qty = @qty, price = @price, amount = @amount
                                where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();

                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            }

            guna2MessageDialog1.Show("Goods received");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;

            lblTotal.Text = "00";
            lblDriverName.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
