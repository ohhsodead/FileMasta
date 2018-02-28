using System.Windows.Forms;

namespace FileMasta.Windows
{
    public partial class DataWindow : Form
    {
        public DataWindow()
        {
            InitializeComponent();
        }

        private void DataDialog_Scroll(object sender, ScrollEventArgs e)
        {
            panelItems.Update(); // Stops 'Lag/Bad Drawing' when scrolling
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