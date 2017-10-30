using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSS_reader
{
    public partial class ChannelDialog : Form
    {
        private int folderID, channelID;
        private string newTitle, url, channelTitle;
        private DateTime lastUpdate;
        private string modeKey;

        public int ChannelID { get => channelID; set => channelID = value; }
        public string NewTitle { get => newTitle; set => newTitle = value; }
        public string URL { get => url; set => url = value; }
        public DateTime LastUpdate { get => lastUpdate; set => lastUpdate = value; }
        public int FolderID { get => folderID; set => folderID = value; }
        public string ChannelTitle { get => channelTitle; set => channelTitle = value; }

        public ChannelDialog(string mode)
        {
            InitializeComponent();

            switch (mode)
            {
                case "Add":
                    //channelIDTextBox.Enabled = false;
                    channelComboBox.Enabled = false;
                    Text = "Add a Channel";
                    modeKey = mode;
                    break;
                case "Del":
                    TitleTextBox.Enabled = false;
                    urlTextBox.Enabled = false;
                    Text = "Delete a Channel";
                    modeKey = mode;
                    break;
                default:
                    Text = "Edit a Channel";
                    modeKey = mode;
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            NewTitle = TitleTextBox.Text;
            URL = urlTextBox.Text;
            FolderID = (int)folderComboBox.SelectedValue;
            ChannelID = modeKey == "Add" ? 0 : (int)channelComboBox.SelectedValue;
            ChannelTitle = channelComboBox.SelectedText;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) { Close(); }

        private void ChannelDialog_Load(object sender, EventArgs e)
        {
            channelTableAdapter.Fill(rssDataSet.Channel);
            folderTableAdapter.Fill(rssDataSet.Folder);

            if (folderComboBox.SelectedValue != null) { channelBindingSource.Filter = "FolderID = " + folderComboBox.SelectedValue; }
        }

        private void folderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            channelBindingSource.Filter = "FolderID = " + folderComboBox.SelectedValue;
        }

        // to delete
        private void channelComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
