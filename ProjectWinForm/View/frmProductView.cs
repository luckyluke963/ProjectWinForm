﻿using ProjectWinForm.Model;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ProjectWinForm.View
{
    public partial class frmProductView : SampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, System.EventArgs e)
        {
            GetData();
        }

        private void frmStaffView_Load(object sender, System.EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "select ProductId, ProductName,ProductPrice , CategoryId,c.CateName from Products p inner join Category c on c.CateId = p.CategoryId where ProductName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvcat);
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            // frmCategoryAdd frm = new frmCategoryAdd();
            //frm.ShowDialog();

            MainClass.BlurBackground(new frmProductAdd());
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                //this is change as we have to set form text proptes before open
                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvcatID"].Value);


                MainClass.BlurBackground(frm);
                GetData();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {


                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from Products where ProductId= " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("successfully deleted");
                }


                GetData();
            }

        }
    }
}
