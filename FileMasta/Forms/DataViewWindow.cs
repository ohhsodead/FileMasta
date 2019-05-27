using System.Windows.Forms;

namespace FileMasta.Forms
{
    public partial class DataViewWindow : Form
    {
        public DataViewWindow()
        {
            InitializeComponent();
        }

        private void DataDialog_Scroll(object sender, ScrollEventArgs e)
        {
            panelItems.Update(); // Stops 'Lag/Bad Drawing' when scrolling
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