using System.Windows.Forms;

namespace Controls
{
    public partial class ErrorInfo : UserControl
    {
        public ErrorInfo()
        {
            InitializeComponent();
        }

        private void btnRestart_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Application.Restart();
        }
    }
}
