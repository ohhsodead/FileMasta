using System.Windows.Forms;

namespace FileMasta.Windows
{
    public partial class VLCPlayer : Form
    {
        public VLCPlayer()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
