using FileMasta.Bookmarks;
using FileMasta.Extensions;
using FileMasta.Files;
using FileMasta.Models;
using FileMasta.Worker;
using System;
using System.Collections.Generic;
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
        public List<string> SelectedFilesType { get; set; } = Types.All;

        /// <summary>
        /// User Preference: Sort Files By
        /// </summary>
        public Query.SortBy SelectedFilesSort { get; set; } = Query.SortBy.Name;

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

                BackGroundWorker.RunWorkAsync<List<WebFile>>(() => Query.Search(UserBookmarks.BookmarkedFiles(), TextBoxSearchQuery.Text, SelectedFilesSort), (data) =>
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

                        foreach (var webFile in data)
                            if (SelectedFilesType.Contains(webFile.Type) && webFile.Host.Contains(SelectedFilesHost))
                            {
                                DataGridFiles.Rows.Add(webFile.Type, webFile.Name, StringExtensions.BytesToPrefix(webFile.Size), StringExtensions.TimeSpanAge(webFile.DateUploaded), webFile.Host, webFile.URL);
                                if (!(ComboBoxHost.Items.Contains(webFile.Host)))
                                    ComboBoxHost.Items.Add(webFile.Host);
                            }

                        LabelStatus.Text = "Loaded";

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
            if (ComboBoxType.SelectedIndex == -1) SelectedFilesType = Types.All;
            else if (ComboBoxType.SelectedIndex == 0) SelectedFilesType = Types.All;
            else if (ComboBoxType.SelectedIndex == 1) SelectedFilesType = Types.Video;
            else if (ComboBoxType.SelectedIndex == 2) SelectedFilesType = Types.Audio;
            else if (ComboBoxType.SelectedIndex == 3) SelectedFilesType = Types.Image;
            else if (ComboBoxType.SelectedIndex == 4) SelectedFilesType = Types.Book;
            else if (ComboBoxType.SelectedIndex == 5) SelectedFilesType = Types.Subtitle;
            else if (ComboBoxType.SelectedIndex == 6) SelectedFilesType = Types.Torrent;
            else if (ComboBoxType.SelectedIndex == 7) SelectedFilesType = Types.Software;
            else if (ComboBoxType.SelectedIndex == 8) SelectedFilesType = Types.Other;
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort.SelectedIndex == 0) SelectedFilesSort = Query.SortBy.Name;
            else if (ComboBoxSort.SelectedIndex == 1) SelectedFilesSort = Query.SortBy.Size;
            else if (ComboBoxSort.SelectedIndex == 2) SelectedFilesSort = Query.SortBy.Date;
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

        private void DataGridFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                MainForm.Form.ShowFileDetails(Database.WebFile(DataGridFiles.CurrentRow.Cells[5].Value.ToString()), DataGridFiles);
        }

        private void DataGridFiles_SelectionChanged(object sender, EventArgs e)
        {
            ButtonRemoveFile.Enabled = (DataGridFiles.SelectedRows.Count > 0);
        }

        private void DataGridFiles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Note: This will remove all of your bookmarked files. You can't undo this. Continue?", "Clear Bookmarks", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                UserBookmarks.ClearBookmarks();
                LoadBookmarks();
            }
        }
    }
}