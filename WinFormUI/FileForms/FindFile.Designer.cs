namespace WinFormUI.FileForms
{
    partial class FindFile
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
            this.FileSearchPanel = new System.Windows.Forms.Panel();
            this.HintLabel = new System.Windows.Forms.Label();
            this.SearchSubheading = new System.Windows.Forms.Label();
            this.ResultsFilterGroup = new System.Windows.Forms.GroupBox();
            this.FileTypeListBox = new System.Windows.Forms.CheckedListBox();
            this.ClearFiltersButton = new System.Windows.Forms.Button();
            this.FileSearchResultsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameContainsLabel = new System.Windows.Forms.Label();
            this.SearchForAFileLabel = new System.Windows.Forms.Label();
            this.FindFileTextBox = new System.Windows.Forms.TextBox();
            this.FileSearchPanel.SuspendLayout();
            this.ResultsFilterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileSearchPanel
            // 
            this.FileSearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSearchPanel.Controls.Add(this.HintLabel);
            this.FileSearchPanel.Controls.Add(this.SearchSubheading);
            this.FileSearchPanel.Controls.Add(this.ResultsFilterGroup);
            this.FileSearchPanel.Controls.Add(this.FileSearchResultsListBox);
            this.FileSearchPanel.Controls.Add(this.label3);
            this.FileSearchPanel.Controls.Add(this.NameContainsLabel);
            this.FileSearchPanel.Controls.Add(this.SearchForAFileLabel);
            this.FileSearchPanel.Controls.Add(this.FindFileTextBox);
            this.FileSearchPanel.Location = new System.Drawing.Point(12, 12);
            this.FileSearchPanel.Name = "FileSearchPanel";
            this.FileSearchPanel.Size = new System.Drawing.Size(520, 384);
            this.FileSearchPanel.TabIndex = 0;
            this.FileSearchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FileSearchPanel_Paint);
            // 
            // HintLabel
            // 
            this.HintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(3, 360);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(163, 13);
            this.HintLabel.TabIndex = 11;
            this.HintLabel.Text = "Hint: Double-click a file to open it";
            // 
            // SearchSubheading
            // 
            this.SearchSubheading.AutoSize = true;
            this.SearchSubheading.Location = new System.Drawing.Point(3, 15);
            this.SearchSubheading.Name = "SearchSubheading";
            this.SearchSubheading.Size = new System.Drawing.Size(299, 26);
            this.SearchSubheading.TabIndex = 10;
            this.SearchSubheading.Text = "Start typing a search term or unselect/select file types.\r\nSearch results will be" +
    " automatically generated in the below list.";
            // 
            // ResultsFilterGroup
            // 
            this.ResultsFilterGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsFilterGroup.Controls.Add(this.FileTypeListBox);
            this.ResultsFilterGroup.Controls.Add(this.ClearFiltersButton);
            this.ResultsFilterGroup.Location = new System.Drawing.Point(360, 93);
            this.ResultsFilterGroup.Name = "ResultsFilterGroup";
            this.ResultsFilterGroup.Size = new System.Drawing.Size(156, 276);
            this.ResultsFilterGroup.TabIndex = 9;
            this.ResultsFilterGroup.TabStop = false;
            this.ResultsFilterGroup.Text = "Include the following Types";
            // 
            // FileTypeListBox
            // 
            this.FileTypeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTypeListBox.CheckOnClick = true;
            this.FileTypeListBox.FormattingEnabled = true;
            this.FileTypeListBox.Location = new System.Drawing.Point(6, 14);
            this.FileTypeListBox.Name = "FileTypeListBox";
            this.FileTypeListBox.Size = new System.Drawing.Size(144, 214);
            this.FileTypeListBox.TabIndex = 0;
            this.FileTypeListBox.SelectedIndexChanged += new System.EventHandler(this.FileTypeListBox_SelectedIndexChanged);
            // 
            // ClearFiltersButton
            // 
            this.ClearFiltersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearFiltersButton.Location = new System.Drawing.Point(6, 247);
            this.ClearFiltersButton.Name = "ClearFiltersButton";
            this.ClearFiltersButton.Size = new System.Drawing.Size(144, 23);
            this.ClearFiltersButton.TabIndex = 1;
            this.ClearFiltersButton.Text = "Reset Filters";
            this.ClearFiltersButton.UseVisualStyleBackColor = true;
            this.ClearFiltersButton.Click += new System.EventHandler(this.ClearFiltersButton_Click);
            // 
            // FileSearchResultsListBox
            // 
            this.FileSearchResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSearchResultsListBox.FormattingEnabled = true;
            this.FileSearchResultsListBox.Location = new System.Drawing.Point(5, 93);
            this.FileSearchResultsListBox.Name = "FileSearchResultsListBox";
            this.FileSearchResultsListBox.Size = new System.Drawing.Size(349, 264);
            this.FileSearchResultsListBox.TabIndex = 1;
            this.FileSearchResultsListBox.DoubleClick += new System.EventHandler(this.FileSearchResultsListBox_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // NameContainsLabel
            // 
            this.NameContainsLabel.AutoSize = true;
            this.NameContainsLabel.Location = new System.Drawing.Point(2, 70);
            this.NameContainsLabel.Name = "NameContainsLabel";
            this.NameContainsLabel.Size = new System.Drawing.Size(98, 13);
            this.NameContainsLabel.TabIndex = 6;
            this.NameContainsLabel.Text = "File Name Contains";
            // 
            // SearchForAFileLabel
            // 
            this.SearchForAFileLabel.AutoSize = true;
            this.SearchForAFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForAFileLabel.Location = new System.Drawing.Point(3, 0);
            this.SearchForAFileLabel.Name = "SearchForAFileLabel";
            this.SearchForAFileLabel.Size = new System.Drawing.Size(101, 13);
            this.SearchForAFileLabel.TabIndex = 4;
            this.SearchForAFileLabel.Text = "Search for a File";
            // 
            // FindFileTextBox
            // 
            this.FindFileTextBox.Location = new System.Drawing.Point(106, 67);
            this.FindFileTextBox.Name = "FindFileTextBox";
            this.FindFileTextBox.Size = new System.Drawing.Size(236, 20);
            this.FindFileTextBox.TabIndex = 0;
            this.FindFileTextBox.TextChanged += new System.EventHandler(this.FindFileTextBox_TextChanged);
            // 
            // FindFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 401);
            this.Controls.Add(this.FileSearchPanel);
            this.MinimumSize = new System.Drawing.Size(560, 440);
            this.Name = "FindFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find a File";
            this.Load += new System.EventHandler(this.FindFile_Load);
            this.FileSearchPanel.ResumeLayout(false);
            this.FileSearchPanel.PerformLayout();
            this.ResultsFilterGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FileSearchPanel;
        private System.Windows.Forms.ListBox FileSearchResultsListBox;
        private System.Windows.Forms.Label NameContainsLabel;
        private System.Windows.Forms.Label SearchForAFileLabel;
        private System.Windows.Forms.TextBox FindFileTextBox;
        private System.Windows.Forms.GroupBox ResultsFilterGroup;
        private System.Windows.Forms.CheckedListBox FileTypeListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearFiltersButton;
        private System.Windows.Forms.Label SearchSubheading;
        private System.Windows.Forms.Label HintLabel;
    }
}