using FileMasta.Extensions;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FileMasta.Windows
{
    public partial class ServersWindow : Form
    {
        public ServersWindow()
        {
            InitializeComponent();
        }

        private void ServersWindow_Load(object sender, EventArgs e)
        {
            LoadServers();
        }
        
        // Loads Servers into DataGrid
        private void LoadServers()
        {
            Program.log.Info("Loading ftp servers");

            DataGridDiscover.Rows.Clear();

            int count = 0;
            foreach (string ftpServer in MainForm.DbOpenServers)
            {
                DataGridDiscover.Rows.Add(StringExtensions.FormatNumber(count.ToString()), ftpServer, "FTP", ftpServer);
                count += 1;
            }

            Program.log.Info("Successfully loaded ftp servers");
        }

        private void DataGridDiscover_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                Process.Start(DataGridDiscover.CurrentRow.Cells[3].Value.ToString());
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
