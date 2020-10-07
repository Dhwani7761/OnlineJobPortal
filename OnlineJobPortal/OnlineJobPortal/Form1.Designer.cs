namespace OnlineJobPortal
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interviewFAQsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCV = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCV = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createCVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companiesToolStripMenuItem,
            this.interviewFAQsToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.contactUsToolStripMenuItem1,
            this.createCVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.companiesToolStripMenuItem.Text = "Search";
            this.companiesToolStripMenuItem.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // interviewFAQsToolStripMenuItem
            // 
            this.interviewFAQsToolStripMenuItem.Name = "interviewFAQsToolStripMenuItem";
            this.interviewFAQsToolStripMenuItem.Size = new System.Drawing.Size(158, 32);
            this.interviewFAQsToolStripMenuItem.Text = "Interview FAQ\'s";
            this.interviewFAQsToolStripMenuItem.Click += new System.EventHandler(this.interviewFAQsToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCV,
            this.viewCV});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(53, 32);
            this.loginToolStripMenuItem.Text = " CV";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // createCV
            // 
            this.createCV.Name = "createCV";
            this.createCV.Size = new System.Drawing.Size(169, 32);
            this.createCV.Text = "Create CV";
            this.createCV.Click += new System.EventHandler(this.viewCVToolStripMenuItem_Click);
            // 
            // viewCV
            // 
            this.viewCV.Name = "viewCV";
            this.viewCV.Size = new System.Drawing.Size(169, 32);
            this.viewCV.Text = "View CV";
            this.viewCV.Click += new System.EventHandler(this.deleteCVToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem1
            // 
            this.contactUsToolStripMenuItem1.Name = "contactUsToolStripMenuItem1";
            this.contactUsToolStripMenuItem1.Size = new System.Drawing.Size(119, 32);
            this.contactUsToolStripMenuItem1.Text = "Contact Us";
            this.contactUsToolStripMenuItem1.Click += new System.EventHandler(this.contactUsToolStripMenuItem1_Click);
            // 
            // createCVToolStripMenuItem
            // 
            this.createCVToolStripMenuItem.Name = "createCVToolStripMenuItem";
            this.createCVToolStripMenuItem.Size = new System.Drawing.Size(55, 32);
            this.createCVToolStripMenuItem.Text = "Exit";
            this.createCVToolStripMenuItem.Click += new System.EventHandler(this.createCVToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineJobPortal.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(506, 311);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interviewFAQsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createCVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCV;
        private System.Windows.Forms.ToolStripMenuItem viewCV;

    }
}

