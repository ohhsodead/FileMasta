using System;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using FileMasta.Utilities;
using FileMasta.Models;
using FileMasta.Files;
using FileMasta.Extensions;

namespace FileMasta.Windows
{
    public partial class BookmarksWindow : Form
    {
        public BookmarksWindow()
        {
            InitializeComponent();

            ComboBoxType.SelectedIndex = 0;
            ComboBoxSort.SelectedIndex = 0;
            ComboBoxHost.SelectedIndex = 0;
        }

        private void BookmarksWindow_Load(object sender, EventArgs e)
        {
            LoadBookmarks();
        }
        
        /// <summary>
        /// User Preference: Files Type
        /// </summary>
        public string[] SelectedFilesType { get; set; } = Types.Everything;

        /// <summary>
        /// User Preference: Sort Files By
        /// </summary>
        public Query.Sort SelectedFilesSort { get; set; } = Query.Sort.Name;

        /// <summary>
        /// User Preference: Files Host
        /// </summary>
        public string SelectedFilesHost { get; set; } = "";

        /// <summary>
        /// Powered by the HackerTarget API to get Top Searches from FileChef.com
        /// </summary>
        delegate void LoadBookmarksCallBack();
        private void LoadBookmarks()
        {
            try
            {
                Program.Log.Info("Loading users bookmarks");
                LabelStatus.Text = "Loading bookmarks...";

                BackGroundWorker.RunWorkAsync<List<FtpFile>>(() => Query.Search(Bookmarks.BookmarkedFiles(), TextBoxSearchQuery.Text, SelectedFilesSort, SelectedFilesType, SelectedFilesHost), (List<FtpFile> data) =>
                {
                    if (InvokeRequired)
                        Invoke(new LoadBookmarksCallBack(LoadBookmarks), new object[] { });
                    else
                    {
                        DataGridFiles.Rows.Clear();
                        ComboBoxHost.Items.Clear(); ComboBoxHost.Items.Add("Any");

                        foreach (var ftpFile in data)
                        {
                            DataGridFiles.Rows.Add(ftpFile.Name, StringExtensions.BytesToPrefix(ftpFile.Size), StringExtensions.TimeSpanAge(ftpFile.DateModified), new Uri(ftpFile.URL).Host, ftpFile.URL);
                            if (!(ComboBoxHost.Items.Contains(new Uri(ftpFile.URL).Host)))
                                ComboBoxHost.Items.Add(new Uri(ftpFile.URL).Host);
                        }

                        LabelStatus.Text = string.Format("{0} Bookmarks", StringExtensions.FormatNumber(DataGridFiles.Rows.Count.ToString()));

                        // Sets selected item to host
                        if (SelectedFilesHost == "") ComboBoxHost.SelectedIndex = 0;
                        else ComboBoxHost.SelectedItem = SelectedFilesHost;

                        Program.Log.Info("Successfully loaded users bookmarks");
                    }
                });
            }
            catch (Exception ex) { Program.Log.Error("Error getting users bookmarks", ex); }
        }
        
        private void TextBoxSearchQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (TextBoxSearchQuery.Text.Length > 2)
                    LoadBookmarks();
                else LabelStatus.Text = "Minimum 3 characters.";
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxType.SelectedIndex == -1) SelectedFilesType = Types.Everything;
            else if (ComboBoxType.SelectedIndex == 0) SelectedFilesType = Types.Everything;
            else if (ComboBoxType.SelectedIndex == 1) SelectedFilesType = Types.Audio;
            else if (ComboBoxType.SelectedIndex == 2) SelectedFilesType = Types.Compressed;
            else if (ComboBoxType.SelectedIndex == 3) SelectedFilesType = Types.Document;
            else if (ComboBoxType.SelectedIndex == 4) SelectedFilesType = Types.Executable;
            else if (ComboBoxType.SelectedIndex == 5) SelectedFilesType = Types.Picture;
            else if (ComboBoxType.SelectedIndex == 6) SelectedFilesType = Types.Video;
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort.SelectedIndex == 0) SelectedFilesSort = Query.Sort.Name;
            else if (ComboBoxSort.SelectedIndex == 1) SelectedFilesSort = Query.Sort.Size;
            else if (ComboBoxSort.SelectedIndex == 2) SelectedFilesSort = Query.Sort.Date;
        }

        private void ComboBoxHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxHost.SelectedIndex == 0) SelectedFilesHost = "";
            else SelectedFilesHost = ComboBoxHost.SelectedItem.ToString();
        }

        private void ButtonSearchFiles_Click(object sender, EventArgs e)
        {
            LoadBookmarks();
        }

        private void DataGridFiles_SelectionChanged(object sender, EventArgs e)
        {
            ButtonRemove.Enabled = (DataGridFiles.SelectedRows.Count > 0);
            ButtonViewDetails.Enabled = (DataGridFiles.SelectedRows.Count > 0);
        }

        private void DataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }
        
        private void ButtonViewDetails_Click(object sender, EventArgs e)
        {
            MainForm.Form.ShowFileDetails(Database.FtpFile(DataGridFiles.CurrentRow.Cells[4].Value.ToString()), DataGridFiles);
        }

        private void ButtonRemoveFile_Click(object sender, EventArgs e)
        {
            Bookmarks.RemoveFile(DataGridFiles.CurrentRow.Cells[4].Value.ToString());
            LoadBookmarks();
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Note: This will remove all of your bookmarked files. You can't undo this. Continue?", "Clear Bookmarks", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Bookmarks.ClearBookmarks();
                LoadBookmarks();
            }
        }

        private void DataGridFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MainForm.Form.ShowFileDetails(Database.FtpFile(DataGridFiles.CurrentRow.Cells[4].Value.ToString()), DataGridFiles);
            }
        }

        // Context Menu Items
        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
            {
                string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
                Process.Start(URL);
            }
        }

        private void MenuFileViewDetails_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
            {
                string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
                MainForm.Form.ShowFileDetails(Database.FtpFile(URL), DataGridFiles);
            }
        }

        private void MenuFileViewWebPage_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
            {
                Uri URL = new Uri(DataGridFiles.CurrentRow.Cells[4].Value.ToString());
                Process.Start(URL.AbsoluteUri.Remove(URL.AbsoluteUri.Length - URL.Segments.Last().Length));
            }
        }

        private void MenuFileCopyURL_Click(object sender, EventArgs e)
        {
            if (DataGridFiles.SelectedRows.Count > 0)
            {
                string URL = DataGridFiles.CurrentRow.Cells[4].Value.ToString();
                Clipboard.SetText(URL);
                MessageBox.Show("Clipboard set to : " + URL);
            }
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