using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class DataDialog : Form
    {
        public DataDialog()
        {
            InitializeComponent();
        }

        private void DataDialog_Scroll(object sender, ScrollEventArgs e)
        {
            Refresh(); // Stops 'Lag/Bad Drawing' when scrolling
        }
    }
}
