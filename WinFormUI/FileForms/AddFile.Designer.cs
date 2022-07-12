namespace WinFormUI.FileForms
{
    partial class AddFile
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
            this.FileTypeCombo = new System.Windows.Forms.ComboBox();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FileLocationLabel = new System.Windows.Forms.Label();
            this.FileLocationTextBox = new System.Windows.Forms.TextBox();
            this.FindCustomerButton = new System.Windows.Forms.Button();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.FileCustomerLabel = new System.Windows.Forms.Label();
            this.OpenFileLocation = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FileFormFieldsPanel = new System.Windows.Forms.Panel();
            this.FormLabel = new System.Windows.Forms.Label();
            this.FileFormFieldsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileTypeCombo
            // 
            this.FileTypeCombo.FormattingEnabled = true;
            this.FileTypeCombo.Location = new System.Drawing.Point(79, 3);
            this.FileTypeCombo.Name = "FileTypeCombo";
            this.FileTypeCombo.Size = new System.Drawing.Size(140, 21);
            this.FileTypeCombo.TabIndex = 1;
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Location = new System.Drawing.Point(4, 6);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.FileTypeLabel.TabIndex = 0;
            this.FileTypeLabel.Text = "File Type:";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(3, 33);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(38, 13);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(79, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(192, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.AutoSize = true;
            this.FileLocationLabel.Location = new System.Drawing.Point(3, 59);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(70, 13);
            this.FileLocationLabel.TabIndex = 4;
            this.FileLocationLabel.Text = "File Location:";
            // 
            // FileLocationTextBox
            // 
            this.FileLocationTextBox.Location = new System.Drawing.Point(79, 56);
            this.FileLocationTextBox.Name = "FileLocationTextBox";
            this.FileLocationTextBox.Size = new System.Drawing.Size(460, 20);
            this.FileLocationTextBox.TabIndex = 5;
            // 
            // FindCustomerButton
            // 
            this.FindCustomerButton.Location = new System.Drawing.Point(345, 82);
            this.FindCustomerButton.Name = "FindCustomerButton";
            this.FindCustomerButton.Size = new System.Drawing.Size(86, 23);
            this.FindCustomerButton.TabIndex = 9;
            this.FindCustomerButton.Text = "Find Customer";
            this.FindCustomerButton.UseVisualStyleBackColor = true;
            this.FindCustomerButton.Click += new System.EventHandler(this.FindCustomerButton_Click);
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Location = new System.Drawing.Point(79, 82);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.ReadOnly = true;
            this.CustomerTextBox.Size = new System.Drawing.Size(260, 20);
            this.CustomerTextBox.TabIndex = 8;
            // 
            // FileCustomerLabel
            // 
            this.FileCustomerLabel.AutoSize = true;
            this.FileCustomerLabel.Location = new System.Drawing.Point(3, 87);
            this.FileCustomerLabel.Name = "FileCustomerLabel";
            this.FileCustomerLabel.Size = new System.Drawing.Size(54, 13);
            this.FileCustomerLabel.TabIndex = 7;
            this.FileCustomerLabel.Text = "Customer:";
            // 
            // OpenFileLocation
            // 
            this.OpenFileLocation.Location = new System.Drawing.Point(545, 54);
            this.OpenFileLocation.Name = "OpenFileLocation";
            this.OpenFileLocation.Size = new System.Drawing.Size(27, 23);
            this.OpenFileLocation.TabIndex = 6;
            this.OpenFileLocation.Text = "...";
            this.OpenFileLocation.UseVisualStyleBackColor = true;
            this.OpenFileLocation.Click += new System.EventHandler(this.OpenFileLocation_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFileButton.Location = new System.Drawing.Point(512, 183);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(75, 23);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(431, 183);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FileFormFieldsPanel
            // 
            this.FileFormFieldsPanel.Controls.Add(this.FileTypeCombo);
            this.FileFormFieldsPanel.Controls.Add(this.FileTypeLabel);
            this.FileFormFieldsPanel.Controls.Add(this.FileNameLabel);
            this.FileFormFieldsPanel.Controls.Add(this.FileCustomerLabel);
            this.FileFormFieldsPanel.Controls.Add(this.FileLocationLabel);
            this.FileFormFieldsPanel.Controls.Add(this.FindCustomerButton);
            this.FileFormFieldsPanel.Controls.Add(this.NameTextBox);
            this.FileFormFieldsPanel.Controls.Add(this.OpenFileLocation);
            this.FileFormFieldsPanel.Controls.Add(this.FileLocationTextBox);
            this.FileFormFieldsPanel.Controls.Add(this.CustomerTextBox);
            this.FileFormFieldsPanel.Location = new System.Drawing.Point(9, 43);
            this.FileFormFieldsPanel.Name = "FileFormFieldsPanel";
            this.FileFormFieldsPanel.Size = new System.Drawing.Size(575, 117);
            this.FileFormFieldsPanel.TabIndex = 1;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.Location = new System.Drawing.Point(12, 9);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(102, 20);
            this.FormLabel.TabIndex = 15;
            this.FormLabel.Text = "Add New File";
            // 
            // AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 217);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.FileFormFieldsPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New File";
            this.Load += new System.EventHandler(this.AddFile_Load);
            this.FileFormFieldsPanel.ResumeLayout(false);
            this.FileFormFieldsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FileTypeCombo;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label FileLocationLabel;
        private System.Windows.Forms.TextBox FileLocationTextBox;
        private System.Windows.Forms.Button FindCustomerButton;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.Label FileCustomerLabel;
        private System.Windows.Forms.Button OpenFileLocation;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel FileFormFieldsPanel;
        private System.Windows.Forms.Label FormLabel;
    }
}