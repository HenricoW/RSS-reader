namespace RSS_reader
{
    partial class ChannelDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.channelIDLabel = new System.Windows.Forms.Label();
            this.channelIDTextBox = new System.Windows.Forms.TextBox();
            this.channelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rssDataSet = new RSS_reader.rssDataSet();
            this.titleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.folderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderLabel = new System.Windows.Forms.Label();
            this.urlLlabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.lastUpdatedLlabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.folderTableAdapter = new RSS_reader.rssDataSetTableAdapters.FolderTableAdapter();
            this.channelTableAdapter = new RSS_reader.rssDataSetTableAdapters.ChannelTableAdapter();
            this.channelComboBox = new System.Windows.Forms.ComboBox();
            this.channelTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.channelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // channelIDLabel
            // 
            this.channelIDLabel.AutoSize = true;
            this.channelIDLabel.Location = new System.Drawing.Point(12, 62);
            this.channelIDLabel.Name = "channelIDLabel";
            this.channelIDLabel.Size = new System.Drawing.Size(63, 13);
            this.channelIDLabel.TabIndex = 0;
            this.channelIDLabel.Text = "Channel ID:";
            // 
            // channelIDTextBox
            // 
            this.channelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.channelBindingSource, "ChannelID", true));
            this.channelIDTextBox.Enabled = false;
            this.channelIDTextBox.Location = new System.Drawing.Point(98, 59);
            this.channelIDTextBox.Name = "channelIDTextBox";
            this.channelIDTextBox.Size = new System.Drawing.Size(174, 20);
            this.channelIDTextBox.TabIndex = 2;
            // 
            // channelBindingSource
            // 
            this.channelBindingSource.DataMember = "Channel";
            this.channelBindingSource.DataSource = this.rssDataSet;
            // 
            // rssDataSet
            // 
            this.rssDataSet.DataSetName = "rssDataSet";
            this.rssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 115);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "New Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(98, 112);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(174, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // folderComboBox
            // 
            this.folderComboBox.DataSource = this.folderBindingSource;
            this.folderComboBox.DisplayMember = "FolderName";
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(98, 32);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(174, 21);
            this.folderComboBox.TabIndex = 1;
            this.folderComboBox.ValueMember = "FolderID";
            this.folderComboBox.SelectedIndexChanged += new System.EventHandler(this.folderComboBox_SelectedIndexChanged);
            // 
            // folderBindingSource
            // 
            this.folderBindingSource.DataMember = "Folder";
            this.folderBindingSource.DataSource = this.rssDataSet;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(12, 35);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(39, 13);
            this.folderLabel.TabIndex = 3;
            this.folderLabel.Text = "Folder:";
            // 
            // urlLlabel
            // 
            this.urlLlabel.AutoSize = true;
            this.urlLlabel.Location = new System.Drawing.Point(12, 141);
            this.urlLlabel.Name = "urlLlabel";
            this.urlLlabel.Size = new System.Drawing.Size(32, 13);
            this.urlLlabel.TabIndex = 0;
            this.urlLlabel.Text = "URL:";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(98, 138);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(174, 20);
            this.urlTextBox.TabIndex = 4;
            // 
            // lastUpdatedLlabel
            // 
            this.lastUpdatedLlabel.AutoSize = true;
            this.lastUpdatedLlabel.Location = new System.Drawing.Point(12, 167);
            this.lastUpdatedLlabel.Name = "lastUpdatedLlabel";
            this.lastUpdatedLlabel.Size = new System.Drawing.Size(74, 13);
            this.lastUpdatedLlabel.TabIndex = 0;
            this.lastUpdatedLlabel.Text = "Last Updated:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(98, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(116, 227);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // folderTableAdapter
            // 
            this.folderTableAdapter.ClearBeforeFill = true;
            // 
            // channelTableAdapter
            // 
            this.channelTableAdapter.ClearBeforeFill = true;
            // 
            // channelComboBox
            // 
            this.channelComboBox.DataSource = this.channelBindingSource;
            this.channelComboBox.DisplayMember = "Title";
            this.channelComboBox.FormattingEnabled = true;
            this.channelComboBox.Location = new System.Drawing.Point(98, 86);
            this.channelComboBox.Name = "channelComboBox";
            this.channelComboBox.Size = new System.Drawing.Size(174, 21);
            this.channelComboBox.TabIndex = 1;
            this.channelComboBox.ValueMember = "ChannelID";
            this.channelComboBox.SelectedIndexChanged += new System.EventHandler(this.channelComboBox_SelectedIndexChanged);
            // 
            // channelTitleLabel
            // 
            this.channelTitleLabel.AutoSize = true;
            this.channelTitleLabel.Location = new System.Drawing.Point(12, 89);
            this.channelTitleLabel.Name = "channelTitleLabel";
            this.channelTitleLabel.Size = new System.Drawing.Size(49, 13);
            this.channelTitleLabel.TabIndex = 3;
            this.channelTitleLabel.Text = "Channel:";
            // 
            // ChannelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.channelTitleLabel);
            this.Controls.Add(this.channelComboBox);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.folderComboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lastUpdatedLlabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.urlLlabel);
            this.Controls.Add(this.channelIDTextBox);
            this.Controls.Add(this.channelIDLabel);
            this.Name = "ChannelDialog";
            this.Text = "Channel Dialog";
            this.Load += new System.EventHandler(this.ChannelDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.channelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label channelIDLabel;
        private System.Windows.Forms.TextBox channelIDTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox folderComboBox;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Label urlLlabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label lastUpdatedLlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private rssDataSet rssDataSet;
        private System.Windows.Forms.BindingSource folderBindingSource;
        private rssDataSetTableAdapters.FolderTableAdapter folderTableAdapter;
        private System.Windows.Forms.BindingSource channelBindingSource;
        private rssDataSetTableAdapters.ChannelTableAdapter channelTableAdapter;
        private System.Windows.Forms.ComboBox channelComboBox;
        private System.Windows.Forms.Label channelTitleLabel;
    }
}