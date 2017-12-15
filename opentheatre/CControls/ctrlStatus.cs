using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnhandledExceptions;

namespace OpenTheatre
{
    public partial class ctrlStatus : UserControl
    {
        public ctrlStatus()
        {
            InitializeComponent();
        }

        private void btnRestartApp_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Application.Restart();
        }
    }
}
