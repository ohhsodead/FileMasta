using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPlex
{
    public partial class frmDataView : Form
    {
        public frmDataView()
        {
            InitializeComponent();
        }

        private void frmDataView_Scroll(object sender, ScrollEventArgs e)
        {
            Update(); // Stops 'Lag/Bad Drawing' when scrolling
        }
    }
}
