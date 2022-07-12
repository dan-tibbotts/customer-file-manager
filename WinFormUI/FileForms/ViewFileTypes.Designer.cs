namespace WinFormUI.FileForms
{
    partial class ViewFileTypes
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
            this.FileTypesListBox = new System.Windows.Forms.ListBox();
            this.FormLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AddFileTypeButton = new System.Windows.Forms.Button();
            this.AddFileTypeBoxGroup = new System.Windows.Forms.GroupBox();
            this.FileTypeTextBox = new System.Windows.Forms.TextBox();
            this.AddFileTypeBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileTypesListBox
            // 
            this.FileTypesListBox.FormattingEnabled = true;
            this.FileTypesListBox.Location = new System.Drawing.Point(12, 109);
            this.FileTypesListBox.Name = "FileTypesListBox";
            this.FileTypesListBox.Size = new System.Drawing.Size(273, 264);
            this.FileTypesListBox.TabIndex = 1;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.Location = new System.Drawing.Point(8, 9);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(80, 20);
            this.FormLabel.TabIndex = 16;
            this.FormLabel.Text = "File Types";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(210, 379);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddFileTypeButton
            // 
            this.AddFileTypeButton.Location = new System.Drawing.Point(181, 19);
            this.AddFileTypeButton.Name = "AddFileTypeButton";
            this.AddFileTypeButton.Size = new System.Drawing.Size(86, 23);
            this.AddFileTypeButton.TabIndex = 1;
            this.AddFileTypeButton.Text = " Add File Type";
            this.AddFileTypeButton.UseVisualStyleBackColor = true;
            this.AddFileTypeButton.Click += new System.EventHandler(this.AddFileTypeButton_Click);
            // 
            // AddFileTypeBoxGroup
            // 
            this.AddFileTypeBoxGroup.Controls.Add(this.FileTypeTextBox);
            this.AddFileTypeBoxGroup.Controls.Add(this.AddFileTypeButton);
            this.AddFileTypeBoxGroup.Location = new System.Drawing.Point(12, 50);
            this.AddFileTypeBoxGroup.Name = "AddFileTypeBoxGroup";
            this.AddFileTypeBoxGroup.Size = new System.Drawing.Size(273, 53);
            this.AddFileTypeBoxGroup.TabIndex = 0;
            this.AddFileTypeBoxGroup.TabStop = false;
            // 
            // FileTypeTextBox
            // 
            this.FileTypeTextBox.Location = new System.Drawing.Point(6, 19);
            this.FileTypeTextBox.Name = "FileTypeTextBox";
            this.FileTypeTextBox.Size = new System.Drawing.Size(169, 20);
            this.FileTypeTextBox.TabIndex = 0;
            // 
            // ViewFileTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 407);
            this.Controls.Add(this.AddFileTypeBoxGroup);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.FileTypesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewFileTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/View File Types";
            this.Load += new System.EventHandler(this.ViewFileTypes_Load);
            this.AddFileTypeBoxGroup.ResumeLayout(false);
            this.AddFileTypeBoxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FileTypesListBox;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AddFileTypeButton;
        private System.Windows.Forms.GroupBox AddFileTypeBoxGroup;
        private System.Windows.Forms.TextBox FileTypeTextBox;
    }
}