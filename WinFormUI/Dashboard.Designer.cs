namespace WinFormUI
{
    partial class Dashboard
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
            this.CustomersGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerListLabel = new System.Windows.Forms.Label();
            this.FindCustomerButton = new System.Windows.Forms.Button();
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.CustomerStatsPanel = new System.Windows.Forms.Panel();
            this.TotalCustomersValue = new System.Windows.Forms.Label();
            this.TotalCustomersLabel = new System.Windows.Forms.Label();
            this.ClearCustomerSearchButton = new System.Windows.Forms.Button();
            this.CustomerSearchTextBox = new System.Windows.Forms.TextBox();
            this.CustomerSearchLabel = new System.Windows.Forms.Label();
            this.CustomersList = new System.Windows.Forms.ListView();
            this.FilesGroup = new System.Windows.Forms.GroupBox();
            this.FilesListLabel = new System.Windows.Forms.Label();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.FilesStatsGroup = new System.Windows.Forms.Panel();
            this.TotalFilesValue = new System.Windows.Forms.Label();
            this.TotalFilesLabel = new System.Windows.Forms.Label();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.DashboardTitle = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CustomersGroup.SuspendLayout();
            this.CustomerStatsPanel.SuspendLayout();
            this.FilesGroup.SuspendLayout();
            this.FilesStatsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGroup
            // 
            this.CustomersGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGroup.Controls.Add(this.label1);
            this.CustomersGroup.Controls.Add(this.CustomerListLabel);
            this.CustomersGroup.Controls.Add(this.FindCustomerButton);
            this.CustomersGroup.Controls.Add(this.CreateCustomerButton);
            this.CustomersGroup.Controls.Add(this.CustomerStatsPanel);
            this.CustomersGroup.Controls.Add(this.ClearCustomerSearchButton);
            this.CustomersGroup.Controls.Add(this.CustomerSearchTextBox);
            this.CustomersGroup.Controls.Add(this.CustomerSearchLabel);
            this.CustomersGroup.Controls.Add(this.CustomersList);
            this.CustomersGroup.Location = new System.Drawing.Point(12, 157);
            this.CustomersGroup.Name = "CustomersGroup";
            this.CustomersGroup.Size = new System.Drawing.Size(476, 431);
            this.CustomersGroup.TabIndex = 0;
            this.CustomersGroup.TabStop = false;
            this.CustomersGroup.Text = "Customers Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Double-click to view Customer";
            // 
            // CustomerListLabel
            // 
            this.CustomerListLabel.AutoSize = true;
            this.CustomerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerListLabel.Location = new System.Drawing.Point(7, 128);
            this.CustomerListLabel.Name = "CustomerListLabel";
            this.CustomerListLabel.Size = new System.Drawing.Size(83, 13);
            this.CustomerListLabel.TabIndex = 6;
            this.CustomerListLabel.Text = "Customer List";
            // 
            // FindCustomerButton
            // 
            this.FindCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindCustomerButton.Location = new System.Drawing.Point(363, 389);
            this.FindCustomerButton.Name = "FindCustomerButton";
            this.FindCustomerButton.Size = new System.Drawing.Size(111, 23);
            this.FindCustomerButton.TabIndex = 3;
            this.FindCustomerButton.Text = "Find Customer";
            this.FindCustomerButton.UseVisualStyleBackColor = true;
            this.FindCustomerButton.Click += new System.EventHandler(this.FindCustomerButton_Click);
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateCustomerButton.Location = new System.Drawing.Point(246, 389);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(111, 23);
            this.CreateCustomerButton.TabIndex = 2;
            this.CreateCustomerButton.Text = "Create Customer";
            this.CreateCustomerButton.UseVisualStyleBackColor = true;
            this.CreateCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // CustomerStatsPanel
            // 
            this.CustomerStatsPanel.Controls.Add(this.TotalCustomersValue);
            this.CustomerStatsPanel.Controls.Add(this.TotalCustomersLabel);
            this.CustomerStatsPanel.Location = new System.Drawing.Point(6, 19);
            this.CustomerStatsPanel.Name = "CustomerStatsPanel";
            this.CustomerStatsPanel.Size = new System.Drawing.Size(470, 62);
            this.CustomerStatsPanel.TabIndex = 4;
            // 
            // TotalCustomersValue
            // 
            this.TotalCustomersValue.AutoSize = true;
            this.TotalCustomersValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCustomersValue.Location = new System.Drawing.Point(145, 21);
            this.TotalCustomersValue.Name = "TotalCustomersValue";
            this.TotalCustomersValue.Size = new System.Drawing.Size(20, 17);
            this.TotalCustomersValue.TabIndex = 0;
            this.TotalCustomersValue.Text = "--";
            // 
            // TotalCustomersLabel
            // 
            this.TotalCustomersLabel.AutoSize = true;
            this.TotalCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCustomersLabel.Location = new System.Drawing.Point(3, 21);
            this.TotalCustomersLabel.Name = "TotalCustomersLabel";
            this.TotalCustomersLabel.Size = new System.Drawing.Size(136, 17);
            this.TotalCustomersLabel.TabIndex = 0;
            this.TotalCustomersLabel.Text = "Total Customers: ";
            // 
            // ClearCustomerSearchButton
            // 
            this.ClearCustomerSearchButton.Location = new System.Drawing.Point(423, 115);
            this.ClearCustomerSearchButton.Name = "ClearCustomerSearchButton";
            this.ClearCustomerSearchButton.Size = new System.Drawing.Size(54, 23);
            this.ClearCustomerSearchButton.TabIndex = 3;
            this.ClearCustomerSearchButton.Text = "Clear";
            this.ClearCustomerSearchButton.UseVisualStyleBackColor = true;
            this.ClearCustomerSearchButton.Click += new System.EventHandler(this.ClearCustomerSearchButton_Click);
            // 
            // CustomerSearchTextBox
            // 
            this.CustomerSearchTextBox.Location = new System.Drawing.Point(224, 116);
            this.CustomerSearchTextBox.Name = "CustomerSearchTextBox";
            this.CustomerSearchTextBox.Size = new System.Drawing.Size(193, 20);
            this.CustomerSearchTextBox.TabIndex = 0;
            this.CustomerSearchTextBox.TextChanged += new System.EventHandler(this.CustomerSearchTextBox_TextChanged);
            // 
            // CustomerSearchLabel
            // 
            this.CustomerSearchLabel.AutoSize = true;
            this.CustomerSearchLabel.Location = new System.Drawing.Point(221, 100);
            this.CustomerSearchLabel.Name = "CustomerSearchLabel";
            this.CustomerSearchLabel.Size = new System.Drawing.Size(91, 13);
            this.CustomerSearchLabel.TabIndex = 1;
            this.CustomerSearchLabel.Text = "Search Customer:";
            // 
            // CustomersList
            // 
            this.CustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersList.HideSelection = false;
            this.CustomersList.Location = new System.Drawing.Point(7, 144);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.Size = new System.Drawing.Size(464, 239);
            this.CustomersList.TabIndex = 1;
            this.CustomersList.UseCompatibleStateImageBehavior = false;
            this.CustomersList.View = System.Windows.Forms.View.Details;
            this.CustomersList.DoubleClick += new System.EventHandler(this.CustomersList_DoubleClick);
            // 
            // FilesGroup
            // 
            this.FilesGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesGroup.Controls.Add(this.FilesListLabel);
            this.FilesGroup.Controls.Add(this.FindFileButton);
            this.FilesGroup.Controls.Add(this.AddFileButton);
            this.FilesGroup.Controls.Add(this.FilesStatsGroup);
            this.FilesGroup.Controls.Add(this.FilesListBox);
            this.FilesGroup.Location = new System.Drawing.Point(494, 157);
            this.FilesGroup.Name = "FilesGroup";
            this.FilesGroup.Size = new System.Drawing.Size(354, 431);
            this.FilesGroup.TabIndex = 1;
            this.FilesGroup.TabStop = false;
            this.FilesGroup.Text = "Files Dashboard";
            // 
            // FilesListLabel
            // 
            this.FilesListLabel.AutoSize = true;
            this.FilesListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesListLabel.Location = new System.Drawing.Point(9, 128);
            this.FilesListLabel.Name = "FilesListLabel";
            this.FilesListLabel.Size = new System.Drawing.Size(57, 13);
            this.FilesListLabel.TabIndex = 6;
            this.FilesListLabel.Text = "Files List";
            // 
            // FindFileButton
            // 
            this.FindFileButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FindFileButton.Location = new System.Drawing.Point(237, 389);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(111, 23);
            this.FindFileButton.TabIndex = 2;
            this.FindFileButton.Text = "Find File";
            this.FindFileButton.UseVisualStyleBackColor = true;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddFileButton.Location = new System.Drawing.Point(120, 389);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(111, 23);
            this.AddFileButton.TabIndex = 1;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // FilesStatsGroup
            // 
            this.FilesStatsGroup.Controls.Add(this.TotalFilesValue);
            this.FilesStatsGroup.Controls.Add(this.TotalFilesLabel);
            this.FilesStatsGroup.Location = new System.Drawing.Point(6, 19);
            this.FilesStatsGroup.Name = "FilesStatsGroup";
            this.FilesStatsGroup.Size = new System.Drawing.Size(342, 62);
            this.FilesStatsGroup.TabIndex = 4;
            // 
            // TotalFilesValue
            // 
            this.TotalFilesValue.AutoSize = true;
            this.TotalFilesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFilesValue.Location = new System.Drawing.Point(103, 21);
            this.TotalFilesValue.Name = "TotalFilesValue";
            this.TotalFilesValue.Size = new System.Drawing.Size(20, 17);
            this.TotalFilesValue.TabIndex = 0;
            this.TotalFilesValue.Text = "--";
            // 
            // TotalFilesLabel
            // 
            this.TotalFilesLabel.AutoSize = true;
            this.TotalFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFilesLabel.Location = new System.Drawing.Point(3, 21);
            this.TotalFilesLabel.Name = "TotalFilesLabel";
            this.TotalFilesLabel.Size = new System.Drawing.Size(94, 17);
            this.TotalFilesLabel.TabIndex = 0;
            this.TotalFilesLabel.Text = "Total Files: ";
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(6, 144);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(342, 238);
            this.FilesListBox.TabIndex = 0;
            this.FilesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FilesListBox_MouseDoubleClick);
            // 
            // Logo
            // 
            this.Logo.Image = global::WinFormUI.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(183, 108);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // DashboardTitle
            // 
            this.DashboardTitle.AutoSize = true;
            this.DashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardTitle.Location = new System.Drawing.Point(349, 37);
            this.DashboardTitle.Name = "DashboardTitle";
            this.DashboardTitle.Size = new System.Drawing.Size(184, 39);
            this.DashboardTitle.TabIndex = 2;
            this.DashboardTitle.Text = "Dashboard";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Green;
            this.TimeLabel.Location = new System.Drawing.Point(708, 50);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(131, 23);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "00:00:00 AM";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DashboardTitle);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.FilesGroup);
            this.Controls.Add(this.CustomersGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(860, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.CustomersGroup.ResumeLayout(false);
            this.CustomersGroup.PerformLayout();
            this.CustomerStatsPanel.ResumeLayout(false);
            this.CustomerStatsPanel.PerformLayout();
            this.FilesGroup.ResumeLayout(false);
            this.FilesGroup.PerformLayout();
            this.FilesStatsGroup.ResumeLayout(false);
            this.FilesStatsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomersGroup;
        private System.Windows.Forms.GroupBox FilesGroup;
        private System.Windows.Forms.ListView CustomersList;
        private System.Windows.Forms.TextBox CustomerSearchTextBox;
        private System.Windows.Forms.Label CustomerSearchLabel;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button ClearCustomerSearchButton;
        private System.Windows.Forms.Button CreateCustomerButton;
        private System.Windows.Forms.Panel CustomerStatsPanel;
        private System.Windows.Forms.Button FindCustomerButton;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Panel FilesStatsGroup;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label DashboardTitle;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CustomerListLabel;
        private System.Windows.Forms.Label FilesListLabel;
        private System.Windows.Forms.Label TotalCustomersLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalCustomersValue;
        private System.Windows.Forms.Label TotalFilesValue;
        private System.Windows.Forms.Label TotalFilesLabel;
    }
}