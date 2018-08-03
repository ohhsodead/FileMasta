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
            Program.log.Info("Loading servers");

            DataGridServers.Rows.Clear();

            int count = 0;
            foreach (string ftpServer in MainForm.DbOpenServers)
            {
                //Uri serverUri = new Uri(ftpServer); // Causes error?
                DataGridServers.Rows.Add(StringExtensions.FormatNumber(count.ToString()), ftpServer, "FTP", ftpServer);
                count += 1;
            }

            Program.log.Info("Successfully loaded servers");
        }

        private void DataGridServers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            string URL = DataGridServers.CurrentRow.Cells[3].Value.ToString();

            Process FileZilla = new Process();
            FileZilla.StartInfo.FileName = LocalExtensions._pathFileZilla;
            FileZilla.StartInfo.Arguments = URL;
            FileZilla.Start();
        }
    }
}