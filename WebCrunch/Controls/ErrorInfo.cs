using System.Windows.Forms;

namespace WebCrunch.Controls
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

        /// <summary>
        /// Return this control on with error text */
        /// </summary>
        /// <param name="errorText">Message to be displayed, usually an error</param>
        public static void ShowStartupError(string errorText)
        {
            ErrorInfo a = new ErrorInfo
            {
                BackColor = MainForm.form.tabHome.BackColor,
                Dock = DockStyle.Fill
            };

            a.titleStatus.Text = errorText;
            a.Show();
            MainForm.form.panelTitles.Enabled = false;
            MainForm.form.tabHome.Controls.Clear();
            MainForm.form.tabHome.Padding = new Padding(0, 0, 0, 0);
            MainForm.form.tabHome.Controls.Add(a);
        }
    }
}
