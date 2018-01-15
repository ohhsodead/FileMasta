using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPlex.CControls
{
    public partial class ctrlInfoTemplate : UserControl
    {
        public ctrlInfoTemplate()
        {
            InitializeComponent();
        }

        //protected override void OnPaint(PaintEventArgs e) { }

        private void appClose_Click(object sender, EventArgs e)
        {
            frmWebPlex.form.frmInfo.Hide();
        }

        private void ctrlInfoTemplate_Load(object sender, EventArgs e)
        {

        }

        private void ctrlInfoTemplate_Scroll(object sender, ScrollEventArgs e)
        {
            panelDataItems.Refresh();
        }
    }
}
