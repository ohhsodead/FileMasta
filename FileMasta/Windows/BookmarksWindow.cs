using FileMasta.Bookmarks;
using FileMasta.Extensions;
using FileMasta.Files;
using FileMasta.Models;
using FileMasta.Worker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
        public string[] SelectedFilesType { get; set; } = Types.Any;

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
                Program.log.Info("Loading users bookmarks");
                LabelStatus.Text = "Loading bookmarks...";

                BackGroundWorker.RunWorkAsync<List<FtpFile>>(() => Query.Search(UserBookmarks.BookmarkedFiles(), TextBoxSearchQuery.Text, SelectedFilesSort, SelectedFilesType, SelectedFilesHost), (data) =>
                {
                    if (this.InvokeRequired)
                    {
                        var b = new LoadBookmarksCallBack(LoadBookmarks);
                        Invoke(b, new object[] { });
                    }
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

                        LabelStatus.Text = string.Format("{0} Files", StringExtensions.FormatNumber(DataGridFiles.Rows.Count.ToString()));

                        if (DataGridFiles.Rows.Count == 0) labelNoResultsFound.Visible = true;
                        else labelNoResultsFound.Visible = false;

                        // Sets selected item to host
                        if (SelectedFilesHost == "") ComboBoxHost.SelectedIndex = 0;
                        else ComboBoxHost.SelectedItem = SelectedFilesHost;

                        Program.log.Info("Successfully loaded users bookmarks");
                    }
                });
            }
            catch (Exception ex) { Program.log.Error("Error getting users bookmarks", ex); }
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
            if (ComboBoxType.SelectedIndex == -1) SelectedFilesType = Types.Any;
            else if (ComboBoxType.SelectedIndex == 0) SelectedFilesType = Types.Any;
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
            ButtonRemoveFile.Enabled = (DataGridFiles.SelectedRows.Count > 0);
            ButtonViewDetails.Enabled = (DataGridFiles.SelectedRows.Count > 0);
        }

        private void DataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }
        
        private void ButtonViewDetails_Click(object sender, EventArgs e)
        {
            MainForm.Form.ShowFileDetails(Database.FtpFile(DataGridFiles.CurrentRow.Cells[5].Value.ToString()), DataGridFiles);
        }

        private void ButtonRemoveFile_Click(object sender, EventArgs e)
        {
            UserBookmarks.RemoveFile(DataGridFiles.CurrentRow.Cells[5].Value.ToString());
            LoadBookmarks();
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Note: This will remove all of your bookmarked files. You can't undo this. Continue?", "Clear Bookmarks", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                UserBookmarks.ClearBookmarks();
                LoadBookmarks();
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