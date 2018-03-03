using System.Windows.Forms;

namespace FileMasta.Controls
{
    public partial class SplashScreen : UserControl
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timerCount_Tick(object sender, System.EventArgs e)
        {
            labelRestart.Visible = true;
        }

        private void labelRestart_Click(object sender, System.EventArgs e)
        {
            MainForm.Form.deleteDataDirectory = true;
        }
    }
}
