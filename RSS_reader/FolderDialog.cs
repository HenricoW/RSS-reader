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
    public partial class FolderDialog : Form
    {
        private int folderID;
        private string folderName, newFolderName;

        public int FolderID { get => folderID; set => folderID = value; }
        public string FolderName { get => folderName; set => folderName = value; }
        public string NewFolderName { get => newFolderName; set => newFolderName = value; }

        public FolderDialog(string mode)
        {
            InitializeComponent();

            switch (mode)
            {
                case "Add":
                    addRadio.Select();
                    folderNameComboBox.Enabled = false;
                    Text = "Add a Folder";
                    break;
                case "Edit":
                    editRadio.Select();
                    Text = "Edit a Folder";
                    break;
                default:
                    delRadio.Select();
                    folderNameTextBox.Enabled = false;
                    Text = "Delete a Folder";
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e) { handleOKbtn(); }

        private void cancelButton_Click(object sender, EventArgs e) { Close(); }

        private void folderNameTextBox_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { handleOKbtn(); } }

        private void handleOKbtn()
        {
            folderName = folderNameComboBox.Text.Trim();
            newFolderName = folderNameTextBox.Text.Trim();

            // get the folderID
            if (!addRadio.Checked & folderIDTextBox.Text != "0")
            {
                DataRow[] row = rssDataSet.Tables["Folder"].Select($"FolderName = '{folderName}'");
                if(row.Length != 0) { folderID = (int)row[0]["FolderID"]; }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FolderDialog_Load(object sender, EventArgs e)
        {
            folderTableAdapter.Fill(rssDataSet.Folder);
            folderNameComboBox.SelectedIndex = -1;
        }
    }
}
