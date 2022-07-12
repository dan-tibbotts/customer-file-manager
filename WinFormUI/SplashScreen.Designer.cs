namespace WinFormUI
{
    partial class SplashScreen
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
            this.DanielTibbottsLink = new System.Windows.Forms.LinkLabel();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.DeveloperLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DanielTibbottsLink
            // 
            this.DanielTibbottsLink.AutoSize = true;
            this.DanielTibbottsLink.Location = new System.Drawing.Point(299, 366);
            this.DanielTibbottsLink.Name = "DanielTibbottsLink";
            this.DanielTibbottsLink.Size = new System.Drawing.Size(78, 13);
            this.DanielTibbottsLink.TabIndex = 0;
            this.DanielTibbottsLink.TabStop = true;
            this.DanielTibbottsLink.Text = "Daniel Tibbotts";
            this.DanielTibbottsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DanielTibbottsLink_LinkClicked);
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.Location = new System.Drawing.Point(235, 366);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(58, 13);
            this.CreatedByLabel.TabIndex = 2;
            this.CreatedByLabel.Text = "Created by";
            // 
            // DeveloperLogo
            // 
            this.DeveloperLogo.Image = global::WinFormUI.Properties.Resources.danzcode_logos__transparent;
            this.DeveloperLogo.Location = new System.Drawing.Point(254, 265);
            this.DeveloperLogo.Name = "DeveloperLogo";
            this.DeveloperLogo.Size = new System.Drawing.Size(95, 98);
            this.DeveloperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeveloperLogo.TabIndex = 3;
            this.DeveloperLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(105, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 397);
            this.Controls.Add(this.DeveloperLogo);
            this.Controls.Add(this.CreatedByLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DanielTibbottsLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel DanielTibbottsLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CreatedByLabel;
        private System.Windows.Forms.PictureBox DeveloperLogo;
    }
}