using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectWinForm.Reports
{
    public partial class frmSaleByCategory : Form
    {
        public frmSaleByCategory()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from Main m
                            inner join Details d on m.MainID = d.MainID
                            inner join Products p on p.ProductId = d.proID
                            inner join Category c on c.CateId = p.CategoryId
                            Where m.aDate between @adate and @edate ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.Parameters.AddWithValue("@adate", Convert.ToDateTime(dateTimePicker1.Value).Date);
            cmd.Parameters.AddWithValue("@edate", Convert.ToDateTime(dateTimePicker2.Value).Date);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrint frm = new frmPrint();
            rptSaleByCategory cr = new rptSaleByCategory();

            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }
    }
}
