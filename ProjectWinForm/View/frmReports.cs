using ProjectWinForm.Reports;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectWinForm.View
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from Products";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrint frm = new frmPrint();
            rptMenu cr = new rptMenu();

            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from Staff";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrint frm = new frmPrint();
            rptStaffList cr = new rptStaffList();

            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

        private void btnSaleCate_Click(object sender, EventArgs e)
        {
            frmSaleByCategory frm = new frmSaleByCategory();
            frm.Show();
        }
    }
}
