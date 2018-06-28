using FileMasta.Worker;
using System;
using System.Collections.Generic;
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
        delegate void loadHostsCallBack();
        private void LoadServers()
        {
            Program.log.Info("Loading ftp servers");

            BackGroundWorker.RunWorkAsync<List<string>>(() => GetServers(), (data) => {
                if (this.InvokeRequired)
                {
                    Invoke(new loadHostsCallBack(LoadServers), new object[] { });
                }
                else
                {
                    dataGridDiscover.Rows.Clear();

                    int count = 1;
                    foreach (string url in data)
                    {
                        dataGridDiscover.Rows.Add(count.ToString(), url, "FTP", url);
                        count += 1;
                    }
                }
            });

            Program.log.Info("Successfully loaded servers");
        }

        object loadHostsLock = new object();
        private List<string> GetServers()
        {
            lock (loadHostsLock)
            {
                List<string> urls = new List<string>();
                foreach (string file in MainForm.DbOpenServers)
                    urls.Add(new Uri(file).GetLeftPart(UriPartial.Scheme) + new Uri(file).Authority);

                return urls;
            }
        }

        private void dataGridDiscover_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                Process.Start(dataGridDiscover.CurrentRow.Cells[3].Value.ToString());
        }
    }
}
