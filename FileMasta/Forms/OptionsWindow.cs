using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace FileMasta.Forms
{
    public partial class OptionsWindow : Form
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        /// <summary>
        /// Enables/Disables Proxy Settings
        /// </summary>
        private void CheckBoxConnectionDefault_CheckedChanged(object sender, EventArgs e)
        {
            // Connection (Enabled/Disabled)
            textBoxConnectionAddress.Enabled = Properties.Settings.Default.proxyUseCustom;
            textBoxConnectionPort.Enabled = Properties.Settings.Default.proxyUseCustom;
            textBoxConnectionUsername.Enabled = Properties.Settings.Default.proxyUseCustom;
            textBoxConnectionPassword.Enabled = Properties.Settings.Default.proxyUseCustom;
        }

        /// <summary>
        /// Set UI/Web Properties
        /// </summary>
        private void LoadSettings()
        {
            // General
            // todo

            // Connection (Enabled/Disabled)
            textBoxConnectionAddress.Enabled = Properties.Settings.Default.proxyUseCustom;
            textBoxConnectionPort.Enabled = Properties.Settings.Default.proxyUseCustom;
            textBoxConnectionUsername.Enabled = Properties.Settings.Default.proxyUseCustom;
            textBoxConnectionPassword.Enabled = Properties.Settings.Default.proxyUseCustom;

            // Connection
            checkBoxConnectionDefault.Checked = Properties.Settings.Default.proxyUseCustom;
            textBoxConnectionAddress.Text = Properties.Settings.Default.proxyAddress;
            textBoxConnectionPort.Text = Convert.ToString(Properties.Settings.Default.proxyPort);
            textBoxConnectionUsername.Text = Properties.Settings.Default.proxyUsername;
            textBoxConnectionPassword.Text = Properties.Settings.Default.proxyPassword;

            // Set Proxy Settings
            if (Properties.Settings.Default.proxyUseCustom)
            {
                if (Uri.TryCreate(Properties.Settings.Default.proxyAddress + ":" + Properties.Settings.Default.proxyPort, UriKind.RelativeOrAbsolute, out Uri result))
                {
                    Program.WebClient.Proxy = new WebProxy(result);

                    if (Properties.Settings.Default.proxyUsername == "" && Properties.Settings.Default.proxyPassword == "")
                        Program.WebClient.UseDefaultCredentials = true;
                    else
                    {
                        Program.WebClient.UseDefaultCredentials = false;
                        Program.WebClient.Credentials = new NetworkCredential(Properties.Settings.Default.proxyUsername, Properties.Settings.Default.proxyPassword);
                    }
                }
                else
                    MessageBox.Show(this, @"Invalid Address/Port");
            }
            else
            {
                Program.WebClient.UseDefaultCredentials = true;
                Program.WebClient.Proxy = new WebProxy( /* can't present value of type System.Net.WebProxy */);
                Program.WebClient.Credentials = CredentialCache.DefaultCredentials;
            }
        }

        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            Thread.Sleep(500);
            LoadSettings();
            MessageBox.Show(@"Settings restored to default.");
            Program.Log.Info("Restored user settings");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // General
            // todo

            // Connection
            Properties.Settings.Default.proxyUseCustom = checkBoxConnectionDefault.Checked;
            Properties.Settings.Default.proxyAddress = textBoxConnectionAddress.Text;
            Properties.Settings.Default.proxyPort = Convert.ToInt32(textBoxConnectionPort.Text);
            Properties.Settings.Default.proxyUsername = textBoxConnectionUsername.Text;
            Properties.Settings.Default.proxyPassword = textBoxConnectionPassword.Text;

            Thread.Sleep(500);
            Properties.Settings.Default.Save();
            LoadSettings();
            MessageBox.Show(@"Settings Saved.");
            Program.Log.Info("Saved user settings");
        }

        /*************************************************************************/
        /* Keyboard Shortcuts                                                    */
        /*************************************************************************/

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            Close();
            return true;
        }
    }
}
