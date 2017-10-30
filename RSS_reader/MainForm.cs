using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RSS_reader
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }

        // Initially fired when the main form starts up
        private void MainForm_Load(object sender, EventArgs e)
        {
            folderTableAdapter.Fill(rssDataSet.Folder);
            folderComboBox.SelectedIndex = 0;
            RefreshChannels();
            RefreshNewsItems();
        }

        // folder-add tool strip button
        private void ToolStripButton1_Click(object sender, EventArgs e) { addFolder(); }

        // folder-edit tool strip button
        private void ToolStripButton2_Click(object sender, EventArgs e) { editFolder(); }

        // folder-del tool strip button
        private void ToolStripButton3_Click(object sender, EventArgs e) { delFolder(); }

        // channel-add tool strip button
        private void ToolStripButton4_Click(object sender, EventArgs e) { addChannel(); }

        // channel-edit tool strip button
        private void ToolStripButton5_Click(object sender, EventArgs e) { editChannel(); }

        // channel-del tool strip button
        private void ToolStripButton6_Click(object sender, EventArgs e) { delChannel(); }

        // channel refresh tool strip button
        private void RSSRefreshToolButton_Click(object sender, EventArgs e)
        {
            QueryChannels();
            RefreshChannels();
            RefreshNewsItems();
        }

        // folder-add menu item
        private void NewFolderToolStripMenuItem_Click(object sender, EventArgs e) { addFolder(); }

        // channel-add menu item
        private void NewChannelToolStripMenuItem_Click(object sender, EventArgs e) { addChannel(); }

        // exit menu item
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) { Close(); }

        // update channels and items when folder changes
        private void FolderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshChannels();
            RefreshNewsItems();
        }

        // update items when channel changes
        private void ChannelListBox_SelectedIndexChanged(object sender, EventArgs e) { RefreshNewsItems(); }


        /// <summary>
        /// helper methods for above code
        /// </summary>

        // cannot move to Utilities: rssDataSet.Folder is not available there
        private void addFolder()
        {
            // instantiate and show the folder dialog box
            FolderDialog f = new FolderDialog("Add");
            DialogResult res = f.ShowDialog();

            if (res == DialogResult.OK)
            {
                if (f.NewFolderName != "")
                {
                    // create, modify and add new folder row
                    rssDataSet.FolderRow frow = rssDataSet.Folder.NewFolderRow();
                    frow.FolderName = f.NewFolderName;
                    rssDataSet.Folder.AddFolderRow(frow);

                    // update the database
                    int rowsAff = folderTableAdapter.Update(frow);
                }
            }

            // garbage collection
            f = null;
        }

        private void editFolder()
        {
            FolderDialog f = new FolderDialog("Edit");
            DialogResult res = f.ShowDialog();

            if (res == DialogResult.OK)
            {
                // select the relevant entry from the dataset
                rssDataSet.FolderRow frow = rssDataSet.Folder.FindByFolderID(f.FolderID);

                // rename the entry
                if (f.NewFolderName == "")
                {
                    MessageBox.Show("New folder name cannot be empty. No changes were made.");
                }
                else
                {
                    frow.BeginEdit();
                    frow.FolderName = f.NewFolderName;
                    frow.EndEdit();
                }

                // commit back to the database
                folderTableAdapter.Update(frow);
            }

            // garbage collection
            f = null;
        }

        private void delFolder()
        {
            FolderDialog f = new FolderDialog("Del");
            DialogResult res = f.ShowDialog();

            if (res == DialogResult.OK)
            {
                // select the relevant entry from the dataset
                rssDataSet.FolderRow frow = rssDataSet.Folder.FindByFolderID(f.FolderID);

                if (f.FolderName == "") { MessageBox.Show("New folder name cannot be empty. No changes were made."); }
                else { frow.Delete(); }

                //rssDataSet.Folder.RemoveFolderRow(frow);                  // did not work for me
                //folderTableAdapter.Delete(f.FolderID, f.FolderName);      // did not work for me
                folderTableAdapter.Update(rssDataSet);
            }

            // garbage collection
            f = null;
        }

        private void addChannel()
        {
            ChannelDialog f = new ChannelDialog("Add");
            DialogResult res = f.ShowDialog();

            string url = f.URL;

            if (res == DialogResult.OK & f.NewTitle != "")
            {
                // sanitize data [varchar(1000)], eliminate single quotes for SQL commands
                string title = f.NewTitle.Length >= 1000 ? f.NewTitle.Substring(0, 999) : f.NewTitle;
                title.Replace("'", "");

                // check if item in database
                string filterExp = "Title = '" + title + "'";
                DataRow[] selectedRow = rssDataSet.Channel.Select(filterExp);

                if (selectedRow.Length == 0)
                {
                    // add new item to NewsItems table
                    //rssDataSet.NewsItem.AddNewsItemRow(title, description, link, publicationDate, currentChannel);        // also works

                    rssDataSet.ChannelRow newRow = rssDataSet.Channel.NewChannelRow();
                    newRow.Title = title;
                    newRow.URL = url;
                    newRow.LastUpdated = DateTime.Now;

                    // folderComboBox.SelectedValue returns an obj so convert to string then to int (there must be a better way, though)
                    int fldrid = f.FolderID;

                    MessageBox.Show($"folder ID is {f.FolderID} for the selected folder name");
                    newRow.FolderID = fldrid;

                    rssDataSet.Channel.AddChannelRow(newRow);

                    channelTableAdapter.Update(newRow);
                }
            }

            f = null;
        }

        private void editChannel()
        {
            ChannelDialog f = new ChannelDialog("Edit");
            DialogResult res = f.ShowDialog();

            if (res == DialogResult.OK)
            {
                // select the relevant entry from the dataset
                rssDataSet.ChannelRow crow = rssDataSet.Channel.FindByChannelID(f.ChannelID);

                // rename the entry
                if (f.NewTitle == "" | f.URL == "")
                {
                    MessageBox.Show("New channel paramaters cannot be empty. No changes were made.");
                }
                else
                {
                    crow.BeginEdit();
                    crow.Title = f.NewTitle;
                    crow.URL = f.URL;
                    crow.EndEdit();
                }

                // commit back to the database
                channelTableAdapter.Update(crow);
            }

            // garbage collection
            f = null;
        }

        private void delChannel()
        {
            ChannelDialog f = new ChannelDialog("Del");
            DialogResult res = f.ShowDialog();

            if (res == DialogResult.OK)
            {
                // select the relevant entry from the dataset
                rssDataSet.ChannelRow crow = rssDataSet.Channel.FindByChannelID(f.ChannelID);

                MessageBox.Show($"channel found is: {crow.Title}");
                crow.Delete();

                //rssDataSet.Folder.RemoveFolderRow(frow);                  // did not work for me
                //folderTableAdapter.Delete(f.FolderID, f.FolderName);      // did not work for me
                channelTableAdapter.Update(rssDataSet);
            }

            // garbage collection
            f = null;
        }

        private void RefreshChannels()
        {
            if (rssDataSet.Channel.Rows.Count == 0) { channelTableAdapter.Fill(rssDataSet.Channel); }
            if (folderComboBox.SelectedValue != null) { channelBindingSource.Filter = "FolderID = " + folderComboBox.SelectedValue; }
        }

        private void RefreshNewsItems()
        {
            if (rssDataSet.NewsItem.Rows.Count == 0) { newsItemTableAdapter.Fill(rssDataSet.NewsItem); }
            if (channelListBox.SelectedValue != null) {
                newsItemBindingSource.Filter = "ChannelID = " + channelListBox.SelectedValue;
            } else
            {
                newsItemBindingSource.Filter = "ChannelID = 0";
            }
        }

        private void QueryChannels()
        {
            // update all items in all channels regardless of folder
            foreach (rssDataSet.ChannelRow currentChannel in rssDataSet.Channel.Rows)
            {
                string rssUrl = currentChannel.URL;

                System.Collections.ArrayList itemsList = Controllers.RefreshRSS(rssUrl);

                //foreach (NewsItem item in itemsList)
                for(int i = 0; i < itemsList.Count; ++i)
                {
                    NewsItem item = (NewsItem) itemsList[i];

                    string title = item.Title;
                    string link = item.Link;
                    string description = item.Description;
                    string pubdate = item.PubDate;

                    DateTime publicationDate = DateTime.Parse(pubdate);

                    // check if item in database
                    string filterExp = "Title = '" + title + "'";
                    DataRow[] selectedRow = rssDataSet.NewsItem.Select(filterExp);

                    if (selectedRow.Length == 0)
                    {
                        // add new item to NewsItems table
                        //rssDataSet.NewsItem.AddNewsItemRow(title, description, link, publicationDate, currentChannel);        // also works
                        rssDataSet.NewsItemRow newRow = rssDataSet.NewsItem.NewNewsItemRow();
                        newRow.Title = title;
                        newRow.Description = description;
                        newRow.Link = link;
                        newRow.DateAcquired = publicationDate;
                        newRow.ChannelID = currentChannel.ChannelID;

                        rssDataSet.NewsItem.AddNewsItemRow(newRow);
                    }
                }
            }

            // update database from dataset
            int rowsAffected = newsItemTableAdapter.Update(rssDataSet);
            DialogResult result = rowsAffected == 0 ? MessageBox.Show("No rows updated in database") : MessageBox.Show($"{rowsAffected} rows updated in database");
        }
    }
}
