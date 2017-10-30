namespace RSS_reader
{
    partial class FolderDialog
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
            this.folderIDLabel = new System.Windows.Forms.Label();
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.folderIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderNameComboBox = new System.Windows.Forms.ComboBox();
            this.folderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rssDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rssDataSet = new RSS_reader.rssDataSet();
            this.rssDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.folderTableAdapter = new RSS_reader.rssDataSetTableAdapters.FolderTableAdapter();
            this.addRadio = new System.Windows.Forms.RadioButton();
            this.editRadio = new System.Windows.Forms.RadioButton();
            this.delRadio = new System.Windows.Forms.RadioButton();
            this.actionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.folderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderIDLabel
            // 
            this.folderIDLabel.AutoSize = true;
            this.folderIDLabel.Location = new System.Drawing.Point(13, 40);
            this.folderIDLabel.Name = "folderIDLabel";
            this.folderIDLabel.Size = new System.Drawing.Size(53, 13);
            this.folderIDLabel.TabIndex = 0;
            this.folderIDLabel.Text = "Folder ID:";
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(13, 185);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(95, 13);
            this.folderNameLabel.TabIndex = 0;
            this.folderNameLabel.Text = "New Folder Name:";
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(116, 181);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.folderNameTextBox.TabIndex = 0;
            this.folderNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.folderNameTextBox_KeyDown);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(116, 227);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // folderIDTextBox
            // 
            this.folderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.folderBindingSource, "FolderID", true));
            this.folderIDTextBox.Enabled = false;
            this.folderIDTextBox.Location = new System.Drawing.Point(116, 37);
            this.folderIDTextBox.Name = "folderIDTextBox";
            this.folderIDTextBox.Size = new System.Drawing.Size(156, 20);
            this.folderIDTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder:";
            // 
            // folderNameComboBox
            // 
            this.folderNameComboBox.DataSource = this.folderBindingSource;
            this.folderNameComboBox.DisplayMember = "FolderName";
            this.folderNameComboBox.FormattingEnabled = true;
            this.folderNameComboBox.Location = new System.Drawing.Point(117, 147);
            this.folderNameComboBox.Name = "folderNameComboBox";
            this.folderNameComboBox.Size = new System.Drawing.Size(156, 21);
            this.folderNameComboBox.TabIndex = 3;
            this.folderNameComboBox.ValueMember = "FolderID";
            // 
            // folderBindingSource
            // 
            this.folderBindingSource.DataMember = "Folder";
            this.folderBindingSource.DataSource = this.rssDataSetBindingSource;
            // 
            // rssDataSetBindingSource
            // 
            this.rssDataSetBindingSource.DataSource = this.rssDataSet;
            this.rssDataSetBindingSource.Position = 0;
            // 
            // rssDataSet
            // 
            this.rssDataSet.DataSetName = "rssDataSet";
            this.rssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rssDataSetBindingSource1
            // 
            this.rssDataSetBindingSource1.DataSource = this.rssDataSet;
            this.rssDataSetBindingSource1.Position = 0;
            // 
            // folderTableAdapter
            // 
            this.folderTableAdapter.ClearBeforeFill = true;
            // 
            // addRadio
            // 
            this.addRadio.AutoSize = true;
            this.addRadio.Location = new System.Drawing.Point(116, 64);
            this.addRadio.Name = "addRadio";
            this.addRadio.Size = new System.Drawing.Size(76, 17);
            this.addRadio.TabIndex = 4;
            this.addRadio.TabStop = true;
            this.addRadio.Text = "Add Folder";
            this.addRadio.UseVisualStyleBackColor = true;
            // 
            // editRadio
            // 
            this.editRadio.AutoSize = true;
            this.editRadio.Location = new System.Drawing.Point(116, 88);
            this.editRadio.Name = "editRadio";
            this.editRadio.Size = new System.Drawing.Size(75, 17);
            this.editRadio.TabIndex = 5;
            this.editRadio.TabStop = true;
            this.editRadio.Text = "Edit Folder";
            this.editRadio.UseVisualStyleBackColor = true;
            // 
            // delRadio
            // 
            this.delRadio.AutoSize = true;
            this.delRadio.Location = new System.Drawing.Point(116, 112);
            this.delRadio.Name = "delRadio";
            this.delRadio.Size = new System.Drawing.Size(88, 17);
            this.delRadio.TabIndex = 6;
            this.delRadio.TabStop = true;
            this.delRadio.Text = "Delete Folder";
            this.delRadio.UseVisualStyleBackColor = true;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(13, 88);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(73, 13);
            this.actionLabel.TabIndex = 0;
            this.actionLabel.Text = "Select Action:";
            // 
            // AddFolderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.delRadio);
            this.Controls.Add(this.editRadio);
            this.Controls.Add(this.addRadio);
            this.Controls.Add(this.folderNameComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.folderIDTextBox);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderNameLabel);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.folderIDLabel);
            this.Name = "AddFolderDialog";
            this.Text = "Folder Properties";
            this.Load += new System.EventHandler(this.FolderDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.folderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderIDLabel;
        private System.Windows.Forms.Label folderNameLabel;
        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox folderIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox folderNameComboBox;
        private System.Windows.Forms.BindingSource rssDataSetBindingSource1;
        private rssDataSet rssDataSet;
        private System.Windows.Forms.BindingSource rssDataSetBindingSource;
        private System.Windows.Forms.BindingSource folderBindingSource;
        private rssDataSetTableAdapters.FolderTableAdapter folderTableAdapter;
        private System.Windows.Forms.RadioButton addRadio;
        private System.Windows.Forms.RadioButton editRadio;
        private System.Windows.Forms.RadioButton delRadio;
        private System.Windows.Forms.Label actionLabel;
    }
}