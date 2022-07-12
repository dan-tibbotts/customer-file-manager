namespace WinFormUI.CustomerForms
{
    partial class FindCustomerModal
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
            this.ClearCustomerSearchButton = new System.Windows.Forms.Button();
            this.CustomerSearchTextBox = new System.Windows.Forms.TextBox();
            this.CustomerSearchLabel = new System.Windows.Forms.Label();
            this.CustomersList = new System.Windows.Forms.ListView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.FormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearCustomerSearchButton
            // 
            this.ClearCustomerSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCustomerSearchButton.Location = new System.Drawing.Point(388, 57);
            this.ClearCustomerSearchButton.Name = "ClearCustomerSearchButton";
            this.ClearCustomerSearchButton.Size = new System.Drawing.Size(54, 23);
            this.ClearCustomerSearchButton.TabIndex = 2;
            this.ClearCustomerSearchButton.Text = "Clear";
            this.ClearCustomerSearchButton.UseVisualStyleBackColor = true;
            this.ClearCustomerSearchButton.Click += new System.EventHandler(this.ClearCustomerSearchButton_Click);
            // 
            // CustomerSearchTextBox
            // 
            this.CustomerSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerSearchTextBox.Location = new System.Drawing.Point(95, 57);
            this.CustomerSearchTextBox.Name = "CustomerSearchTextBox";
            this.CustomerSearchTextBox.Size = new System.Drawing.Size(287, 20);
            this.CustomerSearchTextBox.TabIndex = 1;
            this.CustomerSearchTextBox.TextChanged += new System.EventHandler(this.CustomerSearchTextBox_TextChanged);
            // 
            // CustomerSearchLabel
            // 
            this.CustomerSearchLabel.AutoSize = true;
            this.CustomerSearchLabel.Location = new System.Drawing.Point(12, 60);
            this.CustomerSearchLabel.Name = "CustomerSearchLabel";
            this.CustomerSearchLabel.Size = new System.Drawing.Size(77, 13);
            this.CustomerSearchLabel.TabIndex = 5;
            this.CustomerSearchLabel.Text = "Find Customer:";
            // 
            // CustomersList
            // 
            this.CustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersList.HideSelection = false;
            this.CustomersList.Location = new System.Drawing.Point(12, 83);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.Size = new System.Drawing.Size(430, 303);
            this.CustomersList.TabIndex = 3;
            this.CustomersList.UseCompatibleStateImageBehavior = false;
            this.CustomersList.View = System.Windows.Forms.View.Details;
            this.CustomersList.SelectedIndexChanged += new System.EventHandler(this.CustomersList_SelectedIndexChanged);
            this.CustomersList.DoubleClick += new System.EventHandler(this.CustomersList_DoubleClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(286, 406);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(367, 406);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.Location = new System.Drawing.Point(12, 9);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(113, 20);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "Find Customer";
            // 
            // FindCustomerModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 441);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearCustomerSearchButton);
            this.Controls.Add(this.CustomerSearchTextBox);
            this.Controls.Add(this.CustomerSearchLabel);
            this.Controls.Add(this.CustomersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindCustomerModal";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Customer";
            this.Load += new System.EventHandler(this.FindCustomerModal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearCustomerSearchButton;
        private System.Windows.Forms.TextBox CustomerSearchTextBox;
        private System.Windows.Forms.Label CustomerSearchLabel;
        private System.Windows.Forms.ListView CustomersList;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label FormLabel;
    }
}