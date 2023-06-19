using System.Windows.Forms;

namespace ProjectWinForm
{
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        public virtual void btnSave_Click(object sender, System.EventArgs e)
        {

        }


    }
}
