using ProjectWinForm.Reports;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectWinForm.Model
{
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"select MainID, TableName,WaiterName,orderType,status,total from Main
                            where status <> 'Pending'  ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
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

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();
            }

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {

                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = @"Select * from Main m inner join
                                Details d on d.MainID = m.MainID
                                inner join Products p on p.ProductId = d.proID
                                where m.MainID = " + MainID + " ";

                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();
                frmPrint frm = new frmPrint();
                CrystalReport1 cr = new CrystalReport1();

                //cr.SetDatabaseLogon("", "");  (này là set mật khẩu)
                cr.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();




            }

            if (guna2DataGridView1 != null && guna2DataGridView1.SelectedRows.Count > 0 && guna2DataGridView1.SelectedRows[0].Cells["dgvid"].Value != null)
            {
                MainID = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["dgvid"].Value);


                if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdelete")
                {
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                    if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                    {
                        string qry = "DELETE FROM Main WHERE status = 'Paid' AND MainID = " + MainID + " ";
                        Hashtable ht = new Hashtable();
                        ht.Add("@id", MainID);
                        MainClass.SQL(qry, ht);
                        if (guna2DataGridView1.SelectedRows[0].Cells["dgvStatus"].Value.ToString() == "Paid")
                        {
                            MainClass.SQL(qry, ht);
                            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                            guna2MessageDialog1.Show("successfully deleted");

                            LoadData();

                        }
                        else
                        {
                            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                            guna2MessageDialog1.Show("Cannot delete bills that are not paid.");
                        }

                    }

                }

            }



        }


    }
}
