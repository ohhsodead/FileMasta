using System.IO;
using System.Windows.Forms;
using FileMasta.Extensions;

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

        private void lblLoadingStuckRestart_Click(object sender, System.EventArgs e)
        {
            if (Directory.Exists(LocalExtensions.pathData)) { Directory.Delete(LocalExtensions.pathData, true); } Application.Restart();
        }
    }
}
