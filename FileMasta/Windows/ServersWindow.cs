using FileMasta.Worker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileMasta.Windows
{
    public partial class ServersWindow : Form
    {
        public ServersWindow()
        {
            InitializeComponent();
        }


        // Loads Host into Grid
        delegate void loadHostsCallBack();
        private void ShowHosts()
        {
            Program.log.Info("Getting file hosts for Discover tab");

            BackGroundWorker.RunWorkAsync<List<string>>(() => GetFileHosts(), (data) => {
                if (this.InvokeRequired)
                {
                    var b = new loadHostsCallBack(ShowHosts);
                    Invoke(b, new object[] { });
                }
                else
                {
                    dataGridDiscover.Rows.Clear();

                    int count = 1;
                    foreach (string url in data)
                    {
                        dataGridDiscover.Rows.Add(count.ToString(), url, "Web", url);
                        count += 1;
                    }
                }
            });

            Program.log.Info("Successfully loaded hosts/servers");
        }

        object loadHostsLock = new object();
        private List<string> GetFileHosts()
        {
            lock (loadHostsLock)
            {
                List<string> urls = new List<string>();
                foreach (string file in MainForm.DataOpenDirectories)
                    if (!urls.Contains(new Uri(file.Replace("www.", "")).GetLeftPart(UriPartial.Scheme) + new Uri(file.Replace("www.", "")).Authority))
                        urls.Add(new Uri(file.Replace("www.", "")).GetLeftPart(UriPartial.Scheme) + new Uri(file.Replace("www.", "")).Authority);

                return urls;
            }
        }
    }
}
