using FileMasta.Extensions;
using System;
using System.Diagnostics;
using System.IO;
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

            DataGridServers.Rows.Clear();

            int count = 0;
            foreach (string ftpServer in MainForm.DbOpenServers)
            {
                var serverUri = new Uri(ftpServer);
                DataGridServers.Rows.Add(StringExtensions.FormatNumber(count.ToString()), serverUri.Host, serverUri.Scheme, ftpServer);
                count += 1;
            }

            Program.log.Info("Successfully loaded ftp servers");
        }

        private void DataGridDiscover_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                Process.Start(DataGridServers.CurrentRow.Cells[3].Value.ToString());
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

        private void MenuFileZilla_Click(object sender, EventArgs e)
        {
            string URL = DataGridServers.CurrentRow.Cells[4].Value.ToString();

            Process FileZilla = new Process();
            FileZilla.StartInfo.FileName = LocalExtensions._pathFileZilla;
            FileZilla.StartInfo.Arguments = ("-d " + URL);
            FileZilla.Start();
        }
    }
}
