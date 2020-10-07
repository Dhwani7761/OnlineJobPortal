namespace OnlineJobPortal
{
    partial class Search
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
            this.degreeWiseSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyWiseSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.degreeWiseSearchToolStripMenuItem,
            this.companyWiseSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip_search";
            // 
            // degreeWiseSearchToolStripMenuItem
            // 
            this.degreeWiseSearchToolStripMenuItem.Name = "degreeWiseSearchToolStripMenuItem";
            this.degreeWiseSearchToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.degreeWiseSearchToolStripMenuItem.Text = "Degree wise Search";
            this.degreeWiseSearchToolStripMenuItem.Click += new System.EventHandler(this.degreeWiseSearchToolStripMenuItem_Click);
            // 
            // companyWiseSearchToolStripMenuItem
            // 
            this.companyWiseSearchToolStripMenuItem.Name = "companyWiseSearchToolStripMenuItem";
            this.companyWiseSearchToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.companyWiseSearchToolStripMenuItem.Text = "Company wise Search";
            this.companyWiseSearchToolStripMenuItem.Click += new System.EventHandler(this.companyWiseSearchToolStripMenuItem_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 350);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem degreeWiseSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyWiseSearchToolStripMenuItem;
    }
}