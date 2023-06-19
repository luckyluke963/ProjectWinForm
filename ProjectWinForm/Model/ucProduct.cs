using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectWinForm.Model
{


    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;
        public int id { get; set; }
        public string ProductPrice { get; set; }



        public string ProductCategory { get; set; }
        public string ProductPName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }



        private void txtImage_Click_1(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
