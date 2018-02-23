using System.Windows.Forms;

namespace WebCrunch.Dialogs
{
    public partial class DataWindow : Form
    {
        public DataWindow()
        {
            InitializeComponent();
        }

        private void DataDialog_Scroll(object sender, ScrollEventArgs e)
        {
            Refresh(); // Stops 'Lag/Bad Drawing' when scrolling
        }
    }
}
