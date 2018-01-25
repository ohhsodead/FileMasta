using System.Windows.Forms;

namespace WebPlex.CControls
{
    public partial class ctrlStatus : UserControl
    {
        public ctrlStatus()
        {
            InitializeComponent();
        }

        private void btnRestartApp_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Application.Restart();
        }
    }
}
