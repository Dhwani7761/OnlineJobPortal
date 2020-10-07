namespace OnlineJobPortal
{
    partial class ViewCV
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
            this.headinglbl = new System.Windows.Forms.Label();
            this.enternamelbl = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headinglbl
            // 
            this.headinglbl.AutoSize = true;
            this.headinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglbl.Location = new System.Drawing.Point(177, 27);
            this.headinglbl.Name = "headinglbl";
            this.headinglbl.Size = new System.Drawing.Size(161, 42);
            this.headinglbl.TabIndex = 0;
            this.headinglbl.Text = "View CV";
            // 
            // enternamelbl
            // 
            this.enternamelbl.AutoSize = true;
            this.enternamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enternamelbl.Location = new System.Drawing.Point(30, 102);
            this.enternamelbl.Name = "enternamelbl";
            this.enternamelbl.Size = new System.Drawing.Size(158, 24);
            this.enternamelbl.TabIndex = 1;
            this.enternamelbl.Text = "Enter your Name:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(223, 102);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(242, 29);
            this.txt_name.TabIndex = 2;
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(223, 196);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(115, 39);
            this.btn_view.TabIndex = 3;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // ViewCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineJobPortal.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 287);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.enternamelbl);
            this.Controls.Add(this.headinglbl);
            this.Name = "ViewCV";
            this.Text = "ViewCV";
            this.Load += new System.EventHandler(this.ViewCV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headinglbl;
        private System.Windows.Forms.Label enternamelbl;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_view;
    }
}