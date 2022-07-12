namespace WinFormUI.CustomerForms
{
    partial class ViewCustomer
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
            this.FormLabel = new System.Windows.Forms.Label();
            this.CustomerFieldsPanel = new System.Windows.Forms.Panel();
            this.SendEmailLink = new System.Windows.Forms.LinkLabel();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.StatisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalImagesLabelValue = new System.Windows.Forms.Label();
            this.TotalFilesLabelValue = new System.Windows.Forms.Label();
            this.CustomerIDLabelValue = new System.Windows.Forms.Label();
            this.TotalImagesLabel = new System.Windows.Forms.Label();
            this.TotalFilesLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CustomerTabs = new System.Windows.Forms.TabControl();
            this.AllFilesTab = new System.Windows.Forms.TabPage();
            this.AllFilesListView = new System.Windows.Forms.ListView();
            this.ImagesTab = new System.Windows.Forms.TabPage();
            this.ImagesListView = new System.Windows.Forms.ListView();
            this.MissingFilesTab = new System.Windows.Forms.TabPage();
            this.MissingFilesListView = new System.Windows.Forms.ListView();
            this.MissingFilesLabel = new System.Windows.Forms.Label();
            this.FileActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.EditFileButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.CustomerFieldsPanel.SuspendLayout();
            this.StatisticsGroupBox.SuspendLayout();
            this.CustomerTabs.SuspendLayout();
            this.AllFilesTab.SuspendLayout();
            this.ImagesTab.SuspendLayout();
            this.MissingFilesTab.SuspendLayout();
            this.FileActionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.Location = new System.Drawing.Point(12, 9);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(223, 20);
            this.FormLabel.TabIndex = 4;
            this.FormLabel.Text = "Customer #0: Customer Name";
            // 
            // CustomerFieldsPanel
            // 
            this.CustomerFieldsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerFieldsPanel.Controls.Add(this.SendEmailLink);
            this.CustomerFieldsPanel.Controls.Add(this.EmailLabel);
            this.CustomerFieldsPanel.Controls.Add(this.PhoneLabel);
            this.CustomerFieldsPanel.Controls.Add(this.NameLabel);
            this.CustomerFieldsPanel.Controls.Add(this.EmailTextBox);
            this.CustomerFieldsPanel.Controls.Add(this.PhoneTextBox);
            this.CustomerFieldsPanel.Controls.Add(this.NameTextBox);
            this.CustomerFieldsPanel.Location = new System.Drawing.Point(16, 56);
            this.CustomerFieldsPanel.Name = "CustomerFieldsPanel";
            this.CustomerFieldsPanel.Size = new System.Drawing.Size(449, 113);
            this.CustomerFieldsPanel.TabIndex = 1;
            // 
            // SendEmailLink
            // 
            this.SendEmailLink.AutoSize = true;
            this.SendEmailLink.Location = new System.Drawing.Point(56, 78);
            this.SendEmailLink.Name = "SendEmailLink";
            this.SendEmailLink.Size = new System.Drawing.Size(60, 13);
            this.SendEmailLink.TabIndex = 5;
            this.SendEmailLink.TabStop = true;
            this.SendEmailLink.Text = "Send Email";
            this.SendEmailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SendEmailLink_LinkClicked);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(3, 58);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(3, 32);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 1;
            this.PhoneLabel.Text = "Phone:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(59, 55);
            this.EmailTextBox.MaxLength = 500;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(370, 20);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(59, 29);
            this.PhoneTextBox.MaxLength = 25;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(279, 20);
            this.PhoneTextBox.TabIndex = 3;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(59, 3);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(370, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteCustomerButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(12, 547);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(101, 23);
            this.DeleteCustomerButton.TabIndex = 6;
            this.DeleteCustomerButton.Text = "Delete Customer";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCustomerButton.Location = new System.Drawing.Point(636, 547);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(98, 23);
            this.EditCustomerButton.TabIndex = 4;
            this.EditCustomerButton.Text = "Edit Customer";
            this.EditCustomerButton.UseVisualStyleBackColor = true;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // StatisticsGroupBox
            // 
            this.StatisticsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatisticsGroupBox.Controls.Add(this.TotalImagesLabelValue);
            this.StatisticsGroupBox.Controls.Add(this.TotalFilesLabelValue);
            this.StatisticsGroupBox.Controls.Add(this.CustomerIDLabelValue);
            this.StatisticsGroupBox.Controls.Add(this.TotalImagesLabel);
            this.StatisticsGroupBox.Controls.Add(this.TotalFilesLabel);
            this.StatisticsGroupBox.Controls.Add(this.CustomerIDLabel);
            this.StatisticsGroupBox.Controls.Add(this.GenerateReportButton);
            this.StatisticsGroupBox.Location = new System.Drawing.Point(474, 13);
            this.StatisticsGroupBox.Name = "StatisticsGroupBox";
            this.StatisticsGroupBox.Size = new System.Drawing.Size(260, 156);
            this.StatisticsGroupBox.TabIndex = 8;
            this.StatisticsGroupBox.TabStop = false;
            this.StatisticsGroupBox.Text = "Customer Statistics";
            // 
            // TotalImagesLabelValue
            // 
            this.TotalImagesLabelValue.AutoSize = true;
            this.TotalImagesLabelValue.Location = new System.Drawing.Point(111, 82);
            this.TotalImagesLabelValue.Name = "TotalImagesLabelValue";
            this.TotalImagesLabelValue.Size = new System.Drawing.Size(13, 13);
            this.TotalImagesLabelValue.TabIndex = 1;
            this.TotalImagesLabelValue.Text = "--";
            // 
            // TotalFilesLabelValue
            // 
            this.TotalFilesLabelValue.AutoSize = true;
            this.TotalFilesLabelValue.Location = new System.Drawing.Point(111, 66);
            this.TotalFilesLabelValue.Name = "TotalFilesLabelValue";
            this.TotalFilesLabelValue.Size = new System.Drawing.Size(13, 13);
            this.TotalFilesLabelValue.TabIndex = 1;
            this.TotalFilesLabelValue.Text = "--";
            // 
            // CustomerIDLabelValue
            // 
            this.CustomerIDLabelValue.AutoSize = true;
            this.CustomerIDLabelValue.Location = new System.Drawing.Point(111, 33);
            this.CustomerIDLabelValue.Name = "CustomerIDLabelValue";
            this.CustomerIDLabelValue.Size = new System.Drawing.Size(13, 13);
            this.CustomerIDLabelValue.TabIndex = 1;
            this.CustomerIDLabelValue.Text = "--";
            // 
            // TotalImagesLabel
            // 
            this.TotalImagesLabel.AutoSize = true;
            this.TotalImagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalImagesLabel.Location = new System.Drawing.Point(17, 82);
            this.TotalImagesLabel.Name = "TotalImagesLabel";
            this.TotalImagesLabel.Size = new System.Drawing.Size(88, 13);
            this.TotalImagesLabel.TabIndex = 1;
            this.TotalImagesLabel.Text = "Total Images: ";
            // 
            // TotalFilesLabel
            // 
            this.TotalFilesLabel.AutoSize = true;
            this.TotalFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFilesLabel.Location = new System.Drawing.Point(17, 66);
            this.TotalFilesLabel.Name = "TotalFilesLabel";
            this.TotalFilesLabel.Size = new System.Drawing.Size(70, 13);
            this.TotalFilesLabel.TabIndex = 1;
            this.TotalFilesLabel.Text = "Total Files:";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(17, 33);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(80, 13);
            this.CustomerIDLabel.TabIndex = 1;
            this.CustomerIDLabel.Text = "Customer ID:";
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(6, 127);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(248, 23);
            this.GenerateReportButton.TabIndex = 0;
            this.GenerateReportButton.Text = "Generate Customer Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(555, 547);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CustomerTabs
            // 
            this.CustomerTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerTabs.Controls.Add(this.AllFilesTab);
            this.CustomerTabs.Controls.Add(this.ImagesTab);
            this.CustomerTabs.Controls.Add(this.MissingFilesTab);
            this.CustomerTabs.Location = new System.Drawing.Point(12, 246);
            this.CustomerTabs.Name = "CustomerTabs";
            this.CustomerTabs.SelectedIndex = 0;
            this.CustomerTabs.Size = new System.Drawing.Size(722, 277);
            this.CustomerTabs.TabIndex = 3;
            // 
            // AllFilesTab
            // 
            this.AllFilesTab.Controls.Add(this.AllFilesListView);
            this.AllFilesTab.Location = new System.Drawing.Point(4, 22);
            this.AllFilesTab.Name = "AllFilesTab";
            this.AllFilesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllFilesTab.Size = new System.Drawing.Size(714, 251);
            this.AllFilesTab.TabIndex = 0;
            this.AllFilesTab.Text = "All Files";
            this.AllFilesTab.UseVisualStyleBackColor = true;
            // 
            // AllFilesListView
            // 
            this.AllFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllFilesListView.HideSelection = false;
            this.AllFilesListView.Location = new System.Drawing.Point(6, 6);
            this.AllFilesListView.Name = "AllFilesListView";
            this.AllFilesListView.Size = new System.Drawing.Size(702, 239);
            this.AllFilesListView.TabIndex = 0;
            this.AllFilesListView.UseCompatibleStateImageBehavior = false;
            this.AllFilesListView.View = System.Windows.Forms.View.Details;
            this.AllFilesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllFilesListView_MouseDoubleClick);
            // 
            // ImagesTab
            // 
            this.ImagesTab.Controls.Add(this.ImagesListView);
            this.ImagesTab.Location = new System.Drawing.Point(4, 22);
            this.ImagesTab.Name = "ImagesTab";
            this.ImagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImagesTab.Size = new System.Drawing.Size(714, 251);
            this.ImagesTab.TabIndex = 2;
            this.ImagesTab.Text = "Client Images";
            this.ImagesTab.UseVisualStyleBackColor = true;
            // 
            // ImagesListView
            // 
            this.ImagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagesListView.HideSelection = false;
            this.ImagesListView.Location = new System.Drawing.Point(6, 6);
            this.ImagesListView.Name = "ImagesListView";
            this.ImagesListView.Size = new System.Drawing.Size(702, 242);
            this.ImagesListView.TabIndex = 0;
            this.ImagesListView.UseCompatibleStateImageBehavior = false;
            this.ImagesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ImagesListView_MouseDoubleClick);
            // 
            // MissingFilesTab
            // 
            this.MissingFilesTab.Controls.Add(this.MissingFilesListView);
            this.MissingFilesTab.Controls.Add(this.MissingFilesLabel);
            this.MissingFilesTab.Location = new System.Drawing.Point(4, 22);
            this.MissingFilesTab.Name = "MissingFilesTab";
            this.MissingFilesTab.Padding = new System.Windows.Forms.Padding(3);
            this.MissingFilesTab.Size = new System.Drawing.Size(714, 251);
            this.MissingFilesTab.TabIndex = 3;
            this.MissingFilesTab.Text = "Missing Files";
            this.MissingFilesTab.UseVisualStyleBackColor = true;
            // 
            // MissingFilesListView
            // 
            this.MissingFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MissingFilesListView.HideSelection = false;
            this.MissingFilesListView.Location = new System.Drawing.Point(6, 33);
            this.MissingFilesListView.Name = "MissingFilesListView";
            this.MissingFilesListView.Size = new System.Drawing.Size(702, 212);
            this.MissingFilesListView.TabIndex = 1;
            this.MissingFilesListView.UseCompatibleStateImageBehavior = false;
            // 
            // MissingFilesLabel
            // 
            this.MissingFilesLabel.AutoSize = true;
            this.MissingFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingFilesLabel.Location = new System.Drawing.Point(91, 17);
            this.MissingFilesLabel.Name = "MissingFilesLabel";
            this.MissingFilesLabel.Size = new System.Drawing.Size(436, 13);
            this.MissingFilesLabel.TabIndex = 0;
            this.MissingFilesLabel.Text = "Files in this list are either missing or have been deleted from the file system.";
            // 
            // FileActionsGroupBox
            // 
            this.FileActionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileActionsGroupBox.Controls.Add(this.FindFileButton);
            this.FileActionsGroupBox.Controls.Add(this.EditFileButton);
            this.FileActionsGroupBox.Controls.Add(this.AddFileButton);
            this.FileActionsGroupBox.Location = new System.Drawing.Point(16, 188);
            this.FileActionsGroupBox.Name = "FileActionsGroupBox";
            this.FileActionsGroupBox.Size = new System.Drawing.Size(714, 52);
            this.FileActionsGroupBox.TabIndex = 2;
            this.FileActionsGroupBox.TabStop = false;
            this.FileActionsGroupBox.Text = "FileActions";
            // 
            // FindFileButton
            // 
            this.FindFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindFileButton.Location = new System.Drawing.Point(610, 19);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(91, 23);
            this.FindFileButton.TabIndex = 0;
            this.FindFileButton.Text = "Find File";
            this.FindFileButton.UseVisualStyleBackColor = true;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // EditFileButton
            // 
            this.EditFileButton.Location = new System.Drawing.Point(103, 19);
            this.EditFileButton.Name = "EditFileButton";
            this.EditFileButton.Size = new System.Drawing.Size(168, 23);
            this.EditFileButton.TabIndex = 1;
            this.EditFileButton.Text = "Edit Selected File";
            this.EditFileButton.UseVisualStyleBackColor = true;
            this.EditFileButton.Click += new System.EventHandler(this.EditFileButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(6, 19);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(91, 23);
            this.AddFileButton.TabIndex = 0;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 582);
            this.Controls.Add(this.FileActionsGroupBox);
            this.Controls.Add(this.CustomerTabs);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StatisticsGroupBox);
            this.Controls.Add(this.EditCustomerButton);
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.CustomerFieldsPanel);
            this.Name = "ViewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Customer";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            this.CustomerFieldsPanel.ResumeLayout(false);
            this.CustomerFieldsPanel.PerformLayout();
            this.StatisticsGroupBox.ResumeLayout(false);
            this.StatisticsGroupBox.PerformLayout();
            this.CustomerTabs.ResumeLayout(false);
            this.AllFilesTab.ResumeLayout(false);
            this.ImagesTab.ResumeLayout(false);
            this.MissingFilesTab.ResumeLayout(false);
            this.MissingFilesTab.PerformLayout();
            this.FileActionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Panel CustomerFieldsPanel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button EditCustomerButton;
        private System.Windows.Forms.GroupBox StatisticsGroupBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TabControl CustomerTabs;
        private System.Windows.Forms.TabPage AllFilesTab;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.LinkLabel SendEmailLink;
        private System.Windows.Forms.ListView AllFilesListView;
        private System.Windows.Forms.TabPage ImagesTab;
        private System.Windows.Forms.ListView ImagesListView;
        private System.Windows.Forms.TabPage MissingFilesTab;
        private System.Windows.Forms.ListView MissingFilesListView;
        private System.Windows.Forms.Label MissingFilesLabel;
        private System.Windows.Forms.GroupBox FileActionsGroupBox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.Label TotalImagesLabelValue;
        private System.Windows.Forms.Label TotalFilesLabelValue;
        private System.Windows.Forms.Label CustomerIDLabelValue;
        private System.Windows.Forms.Label TotalImagesLabel;
        private System.Windows.Forms.Label TotalFilesLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Button EditFileButton;
    }
}