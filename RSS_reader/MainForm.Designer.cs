namespace RSS_reader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.newsItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rssDataSet = new RSS_reader.rssDataSet();
            this.expandLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newsItemsListBox = new System.Windows.Forms.ListBox();
            this.datePostedLabel = new System.Windows.Forms.Label();
            this.newsItemsLabel = new System.Windows.Forms.Label();
            this.descriptionListBox = new System.Windows.Forms.ListBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.channelListBox = new System.Windows.Forms.ListBox();
            this.channelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.channelLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.folderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.folderAddToolButton = new System.Windows.Forms.ToolStripButton();
            this.folderEditToolButton = new System.Windows.Forms.ToolStripButton();
            this.folderDelToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.channelAddToolButton = new System.Windows.Forms.ToolStripButton();
            this.channelEditToolButton = new System.Windows.Forms.ToolStripButton();
            this.channelDelToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RSSRefreshToolButton = new System.Windows.Forms.ToolStripButton();
            this.folderTableAdapter = new RSS_reader.rssDataSetTableAdapters.FolderTableAdapter();
            this.channelTableAdapter = new RSS_reader.rssDataSetTableAdapters.ChannelTableAdapter();
            this.newsItemTableAdapter = new RSS_reader.rssDataSetTableAdapters.NewsItemTableAdapter();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.webBrowser1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.expandLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.newsItemsListBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.datePostedLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.newsItemsLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.descriptionListBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.descriptionLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.channelListBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.channelLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.titleLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.folderComboBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.folderLabel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(598, 414);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(598, 485);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(235, 174);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(351, 218);
            this.webBrowser1.TabIndex = 7;
            // 
            // newsItemBindingSource
            // 
            this.newsItemBindingSource.DataMember = "NewsItem";
            this.newsItemBindingSource.DataSource = this.rssDataSet;
            // 
            // rssDataSet
            // 
            this.rssDataSet.DataSetName = "rssDataSet";
            this.rssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expandLabel
            // 
            this.expandLabel.AutoSize = true;
            this.expandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandLabel.ForeColor = System.Drawing.Color.Blue;
            this.expandLabel.Location = new System.Drawing.Point(518, 146);
            this.expandLabel.Name = "expandLabel";
            this.expandLabel.Size = new System.Drawing.Size(43, 13);
            this.expandLabel.TabIndex = 8;
            this.expandLabel.Text = "Expand";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "DateAcquired", true));
            this.textBox2.Location = new System.Drawing.Point(310, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "Title", true));
            this.textBox1.Location = new System.Drawing.Point(235, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 20);
            this.textBox1.TabIndex = 4;
            // 
            // newsItemsListBox
            // 
            this.newsItemsListBox.DataSource = this.newsItemBindingSource;
            this.newsItemsListBox.DisplayMember = "Title";
            this.newsItemsListBox.FormattingEnabled = true;
            this.newsItemsListBox.Location = new System.Drawing.Point(16, 245);
            this.newsItemsListBox.Name = "newsItemsListBox";
            this.newsItemsListBox.Size = new System.Drawing.Size(201, 147);
            this.newsItemsListBox.TabIndex = 3;
            this.newsItemsListBox.ValueMember = "NewsItemID";
            // 
            // datePostedLabel
            // 
            this.datePostedLabel.AutoSize = true;
            this.datePostedLabel.Location = new System.Drawing.Point(235, 147);
            this.datePostedLabel.Name = "datePostedLabel";
            this.datePostedLabel.Size = new System.Drawing.Size(69, 13);
            this.datePostedLabel.TabIndex = 4;
            this.datePostedLabel.Text = "Date Posted:";
            // 
            // newsItemsLabel
            // 
            this.newsItemsLabel.AutoSize = true;
            this.newsItemsLabel.Location = new System.Drawing.Point(16, 229);
            this.newsItemsLabel.Name = "newsItemsLabel";
            this.newsItemsLabel.Size = new System.Drawing.Size(65, 13);
            this.newsItemsLabel.TabIndex = 4;
            this.newsItemsLabel.Text = "News Items:";
            // 
            // descriptionListBox
            // 
            this.descriptionListBox.DataSource = this.newsItemBindingSource;
            this.descriptionListBox.DisplayMember = "Description";
            this.descriptionListBox.FormattingEnabled = true;
            this.descriptionListBox.Location = new System.Drawing.Point(235, 78);
            this.descriptionListBox.Name = "descriptionListBox";
            this.descriptionListBox.ScrollAlwaysVisible = true;
            this.descriptionListBox.Size = new System.Drawing.Size(351, 56);
            this.descriptionListBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(235, 62);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // channelListBox
            // 
            this.channelListBox.DataSource = this.channelBindingSource;
            this.channelListBox.DisplayMember = "Title";
            this.channelListBox.FormattingEnabled = true;
            this.channelListBox.Location = new System.Drawing.Point(16, 78);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.Size = new System.Drawing.Size(201, 134);
            this.channelListBox.TabIndex = 2;
            this.channelListBox.ValueMember = "ChannelID";
            this.channelListBox.SelectedIndexChanged += new System.EventHandler(this.ChannelListBox_SelectedIndexChanged);
            // 
            // channelBindingSource
            // 
            this.channelBindingSource.DataMember = "Channel";
            this.channelBindingSource.DataSource = this.rssDataSet;
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Location = new System.Drawing.Point(16, 62);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(49, 13);
            this.channelLabel.TabIndex = 2;
            this.channelLabel.Text = "Channel:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(235, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // folderComboBox
            // 
            this.folderComboBox.DataSource = this.folderBindingSource;
            this.folderComboBox.DisplayMember = "FolderName";
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(16, 32);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(201, 21);
            this.folderComboBox.TabIndex = 1;
            this.folderComboBox.ValueMember = "FolderID";
            this.folderComboBox.SelectedIndexChanged += new System.EventHandler(this.FolderComboBox_SelectedIndexChanged);
            // 
            // folderBindingSource
            // 
            this.folderBindingSource.DataMember = "Folder";
            this.folderBindingSource.DataSource = this.rssDataSet;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(16, 15);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(39, 13);
            this.folderLabel.TabIndex = 8;
            this.folderLabel.Text = "Folder:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.newChannelToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.NewFolderToolStripMenuItem_Click);
            // 
            // newChannelToolStripMenuItem
            // 
            this.newChannelToolStripMenuItem.Name = "newChannelToolStripMenuItem";
            this.newChannelToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newChannelToolStripMenuItem.Text = "New Channel";
            this.newChannelToolStripMenuItem.Click += new System.EventHandler(this.NewChannelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderAddToolButton,
            this.folderEditToolButton,
            this.folderDelToolButton,
            this.toolStripSeparator1,
            this.channelAddToolButton,
            this.channelEditToolButton,
            this.channelDelToolButton,
            this.toolStripSeparator2,
            this.RSSRefreshToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(185, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // folderAddToolButton
            // 
            this.folderAddToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.folderAddToolButton.Image = ((System.Drawing.Image)(resources.GetObject("folderAddToolButton.Image")));
            this.folderAddToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.folderAddToolButton.Name = "folderAddToolButton";
            this.folderAddToolButton.Size = new System.Drawing.Size(23, 22);
            this.folderAddToolButton.Text = "folderAddToolButton";
            this.folderAddToolButton.ToolTipText = "Add a folder";
            this.folderAddToolButton.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // folderEditToolButton
            // 
            this.folderEditToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.folderEditToolButton.Image = ((System.Drawing.Image)(resources.GetObject("folderEditToolButton.Image")));
            this.folderEditToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.folderEditToolButton.Name = "folderEditToolButton";
            this.folderEditToolButton.Size = new System.Drawing.Size(23, 22);
            this.folderEditToolButton.Text = "folderEditToolButton";
            this.folderEditToolButton.ToolTipText = "Edit a folder";
            this.folderEditToolButton.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // folderDelToolButton
            // 
            this.folderDelToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.folderDelToolButton.Image = ((System.Drawing.Image)(resources.GetObject("folderDelToolButton.Image")));
            this.folderDelToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.folderDelToolButton.Name = "folderDelToolButton";
            this.folderDelToolButton.Size = new System.Drawing.Size(23, 22);
            this.folderDelToolButton.Text = "folderDelToolButton";
            this.folderDelToolButton.ToolTipText = "Remove a folder";
            this.folderDelToolButton.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // channelAddToolButton
            // 
            this.channelAddToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.channelAddToolButton.Image = ((System.Drawing.Image)(resources.GetObject("channelAddToolButton.Image")));
            this.channelAddToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.channelAddToolButton.Name = "channelAddToolButton";
            this.channelAddToolButton.Size = new System.Drawing.Size(23, 22);
            this.channelAddToolButton.Text = "channelAddToolButton";
            this.channelAddToolButton.ToolTipText = "Add a channel";
            this.channelAddToolButton.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // channelEditToolButton
            // 
            this.channelEditToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.channelEditToolButton.Image = ((System.Drawing.Image)(resources.GetObject("channelEditToolButton.Image")));
            this.channelEditToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.channelEditToolButton.Name = "channelEditToolButton";
            this.channelEditToolButton.Size = new System.Drawing.Size(23, 22);
            this.channelEditToolButton.Text = "channelEditToolButton";
            this.channelEditToolButton.ToolTipText = "Edit a channel";
            this.channelEditToolButton.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // channelDelToolButton
            // 
            this.channelDelToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.channelDelToolButton.Image = ((System.Drawing.Image)(resources.GetObject("channelDelToolButton.Image")));
            this.channelDelToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.channelDelToolButton.Name = "channelDelToolButton";
            this.channelDelToolButton.Size = new System.Drawing.Size(23, 22);
            this.channelDelToolButton.Text = "channelDelToolButton";
            this.channelDelToolButton.ToolTipText = "Remove a channel";
            this.channelDelToolButton.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RSSRefreshToolButton
            // 
            this.RSSRefreshToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RSSRefreshToolButton.Image = ((System.Drawing.Image)(resources.GetObject("RSSRefreshToolButton.Image")));
            this.RSSRefreshToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RSSRefreshToolButton.Name = "RSSRefreshToolButton";
            this.RSSRefreshToolButton.Size = new System.Drawing.Size(23, 22);
            this.RSSRefreshToolButton.Text = "RSSRefreshToolButton";
            this.RSSRefreshToolButton.ToolTipText = "Refresh all feeds";
            this.RSSRefreshToolButton.Click += new System.EventHandler(this.RSSRefreshToolButton_Click);
            // 
            // folderTableAdapter
            // 
            this.folderTableAdapter.ClearBeforeFill = true;
            // 
            // channelTableAdapter
            // 
            this.channelTableAdapter.ClearBeforeFill = true;
            // 
            // newsItemTableAdapter
            // 
            this.newsItemTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 485);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label expandLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox newsItemsListBox;
        private System.Windows.Forms.Label datePostedLabel;
        private System.Windows.Forms.Label newsItemsLabel;
        private System.Windows.Forms.ListBox descriptionListBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ListBox channelListBox;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox folderComboBox;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton folderAddToolButton;
        private System.Windows.Forms.ToolStripButton folderEditToolButton;
        private System.Windows.Forms.ToolStripButton folderDelToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton channelAddToolButton;
        private System.Windows.Forms.ToolStripButton channelEditToolButton;
        private System.Windows.Forms.ToolStripButton channelDelToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RSSRefreshToolButton;
        private rssDataSet rssDataSet;
        private System.Windows.Forms.BindingSource folderBindingSource;
        private rssDataSetTableAdapters.FolderTableAdapter folderTableAdapter;
        private System.Windows.Forms.BindingSource channelBindingSource;
        private rssDataSetTableAdapters.ChannelTableAdapter channelTableAdapter;
        private System.Windows.Forms.BindingSource newsItemBindingSource;
        private rssDataSetTableAdapters.NewsItemTableAdapter newsItemTableAdapter;
    }
}

