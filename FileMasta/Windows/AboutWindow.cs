using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FileMasta.Windows
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Returns this process bit version
        /// </summary>
        /// <returns></returns>
        public static string GetOsBit() { if (Environment.Is64BitProcess) return "x64"; else return "x32"; }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            LabelVersion.Text = string.Format("Version {0} ({1})", Application.ProductVersion, GetOsBit());
        }

        private void LinkProjectURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LinkProjectURL.Text);
        }

        /*************************************************************************/
        /* Keyboard Shortcuts                                                    */
        /*************************************************************************/

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                // Close this instance
                case Keys.Escape:
                    Close();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
