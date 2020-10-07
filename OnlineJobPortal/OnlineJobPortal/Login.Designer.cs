namespace OnlineJobPortal
{
    partial class Login
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
            this.emaillbl = new System.Windows.Forms.Label();
            this.mailtxtbox = new System.Windows.Forms.TextBox();
            this.pwdtxtbox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.newherelbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headinglbl
            // 
            this.headinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headinglbl.Location = new System.Drawing.Point(37, 23);
            this.headinglbl.Name = "headinglbl";
            this.headinglbl.Size = new System.Drawing.Size(454, 45);
            this.headinglbl.TabIndex = 0;
            this.headinglbl.Text = "Welcome To Online Job Portal";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(43, 86);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(92, 29);
            this.emaillbl.TabIndex = 1;
            this.emaillbl.Text = "Mail-id:";
            // 
            // mailtxtbox
            // 
            this.mailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailtxtbox.Location = new System.Drawing.Point(200, 86);
            this.mailtxtbox.Name = "mailtxtbox";
            this.mailtxtbox.Size = new System.Drawing.Size(291, 35);
            this.mailtxtbox.TabIndex = 2;
            // 
            // pwdtxtbox
            // 
            this.pwdtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxtbox.Location = new System.Drawing.Point(200, 134);
            this.pwdtxtbox.Name = "pwdtxtbox";
            this.pwdtxtbox.Size = new System.Drawing.Size(291, 35);
            this.pwdtxtbox.TabIndex = 3;
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(97, 236);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(125, 40);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(274, 236);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(125, 40);
            this.resetbtn.TabIndex = 5;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(43, 140);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(126, 29);
            this.passwordlbl.TabIndex = 6;
            this.passwordlbl.Text = "Password:";
            // 
            // newherelbl
            // 
            this.newherelbl.AutoSize = true;
            this.newherelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newherelbl.Location = new System.Drawing.Point(129, 312);
            this.newherelbl.Name = "newherelbl";
            this.newherelbl.Size = new System.Drawing.Size(106, 24);
            this.newherelbl.TabIndex = 7;
            this.newherelbl.Text = "New Here?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineJobPortal.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newherelbl);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pwdtxtbox);
            this.Controls.Add(this.mailtxtbox);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.headinglbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headinglbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox mailtxtbox;
        private System.Windows.Forms.TextBox pwdtxtbox;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label newherelbl;
        private System.Windows.Forms.Button button1;
    }
}