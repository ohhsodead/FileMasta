using System.Windows.Forms;

namespace FileMasta.Windows
{
    public partial class ShortcutsWindow : Form
    {
        public ShortcutsWindow()
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
