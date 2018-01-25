using System.Windows.Forms;

namespace UserControls
{
    public partial class ErrorInfo : UserControl
    {
        public ErrorInfo()
        {
            InitializeComponent();
        }

        private void btnRestartApp_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Application.Restart();
        }
    }
}
