/*************************************************************************/
/*  ExceptionWindow.cs                                                   */
/*************************************************************************/
/*                       This file is part of:                           */
/*                            openTheare                                 */
/*************************************************************************/
/* Copyright (c) 2017-2017 Badr Azizi.                                   */
/*                                                                       */
/* Permission is hereby granted, free of charge, to any person obtaining */
/* a copy of this software and associated documentation files (the       */
/* "Software"), to deal in the Software without restriction, including   */
/* without limitation the rights to use, copy, modify, merge, publish,   */
/* distribute, sublicense, and/or sell copies of the Software, and to    */
/* permit persons to whom the Software is furnished to do so, subject to */
/* the following conditions:                                             */
/*                                                                       */
/* The above copyright notice and this permission notice shall be        */
/* included in all copies or substantial portions of the Software.       */
/*                                                                       */
/* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,       */
/* EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF    */
/* MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.*/
/* IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY  */
/* CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,  */
/* TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE     */
/* SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.                */
/*************************************************************************/

using Octokit;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UnhandledExceptions
{
    public partial class ExceptionWindow : Form
    {

        public string GithubLink { get; set; }

        public ExceptionWindow()
        {
            InitializeComponent();
            ReportBtn.Click += ReportBtnClick;
            GithubIssuesLink.Visible = false;
        }

        private async void ReportBtnClick(object sender, EventArgs e)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("opentheatre"));
                var tokenAuth = new Credentials("9d24b1902caa5024f078fd3ae0013eb4d4d3fb64"); // see this link to create a personal access token -- https://help.github.com/articles/creating-a-personal-access-token-for-the-command-line/ --
                client.Credentials = tokenAuth;
                var createIssue = new NewIssue(BugTitleBox.Text);
                createIssue.Body = BugDetailBox.Text;
                Issue issue = await client.Issue.Create("invu", "opentheatre", createIssue);
                if (issue.Number > 0)
                    if (!string.IsNullOrEmpty(GithubLink) || !string.IsNullOrWhiteSpace(GithubLink))
                        MessageBox.Show("Thank you for reporting this bug\nYou can follow this bug in\n" + GithubLink + issue.Number);
                    else
                        MessageBox.Show("Thank you for reporting this bug");
                this.Dispose();
            }
            catch (Exception ex) { MessageBox.Show("Unable to report bug, try again later.\n\n" + ex.Message); }
        }

        public ExceptionWindow(string title, string body, string link)
        {
            InitializeComponent();
            ReportBtn.Click += ReportBtnClick;
            GithubIssuesLink.Visible = true;
            GithubLink = link;
            GithubIssuesLink.Click += (s, e) => { Process.Start(link); };
            BugTitleBox.Text = title;
            BugDetailBox.Text = body;
        }
    }
}
