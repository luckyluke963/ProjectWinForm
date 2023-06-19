using System;
using System.Collections;

namespace ProjectWinForm.Model
{
    public partial class frmCheckout : SampleAdd
    {
        public frmCheckout()
        {
            InitializeComponent();
        }


        public double amt;
        public int MainID = 0;

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;
            double.TryParse(txtBillAmount.Text, out amt);
            double.TryParse(txtReceived.Text, out receipt);

            change = Math.Abs(amt - receipt);

            txtChange.Text = change.ToString();

        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string qry = @"Update Main set total = @total,  received = @rec, change = @change,
                            status = 'Paid' where MainID = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", txtBillAmount.Text);
            ht.Add("@rec", txtReceived.Text);
            ht.Add("@change", txtChange.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Saved Successfull");
                this.Close();
            }
        }
    }
}
