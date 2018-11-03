using FileMasta.GitHub;
using System;
using System.IO;
using System.Windows.Forms;

namespace FileMasta.Windows
{
    public partial class SubmitWindow : Form
    {
        public SubmitWindow()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (!Path.HasExtension(TextBoxServer.Text))
                if (Uri.IsWellFormedUriString(TextBoxServer.Text, UriKind.Absolute))
                {
                    // Add a '/' if not present
                    var formattedText = TextBoxServer.Text;
                    if (!TextBoxServer.Text.EndsWith("/"))
                        formattedText = TextBoxServer.Text + "/";
                    OpenLink.SubmitLink(new Uri(formattedText));
                    Close();
                }
                else MessageBox.Show(this, "This isn't a public web directory.");
            else MessageBox.Show(this, "This isn't a public web directory.");
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
