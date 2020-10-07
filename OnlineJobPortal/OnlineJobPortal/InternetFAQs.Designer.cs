namespace OnlineJobPortal
{
    partial class InternetFAQs
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
            this.button2 = new System.Windows.Forms.Button();
            this.q_txtbox = new System.Windows.Forms.TextBox();
            this.qst_lbl = new System.Windows.Forms.Label();
            this.ans_lbl = new System.Windows.Forms.Label();
            this.a_txt = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headinglbl
            // 
            this.headinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglbl.Location = new System.Drawing.Point(12, 9);
            this.headinglbl.Name = "headinglbl";
            this.headinglbl.Size = new System.Drawing.Size(514, 76);
            this.headinglbl.TabIndex = 0;
            this.headinglbl.Text = "The Questions Frequently Asked in Interviews!";
            this.headinglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headinglbl.Click += new System.EventHandler(this.headinglbl_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::OnlineJobPortal.Properties.Resources.next;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(187, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 66);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // q_txtbox
            // 
            this.q_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_txtbox.Location = new System.Drawing.Point(121, 124);
            this.q_txtbox.Multiline = true;
            this.q_txtbox.Name = "q_txtbox";
            this.q_txtbox.Size = new System.Drawing.Size(398, 62);
            this.q_txtbox.TabIndex = 6;
            // 
            // qst_lbl
            // 
            this.qst_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.qst_lbl.Location = new System.Drawing.Point(11, 139);
            this.qst_lbl.Name = "qst_lbl";
            this.qst_lbl.Size = new System.Drawing.Size(100, 27);
            this.qst_lbl.TabIndex = 3;
            this.qst_lbl.Text = "Question:";
            // 
            // ans_lbl
            // 
            this.ans_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ans_lbl.Location = new System.Drawing.Point(14, 239);
            this.ans_lbl.Name = "ans_lbl";
            this.ans_lbl.Size = new System.Drawing.Size(87, 31);
            this.ans_lbl.TabIndex = 4;
            this.ans_lbl.Text = "Answer:";
            // 
            // a_txt
            // 
            this.a_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_txt.Location = new System.Drawing.Point(121, 216);
            this.a_txt.Multiline = true;
            this.a_txt.Name = "a_txt";
            this.a_txt.Size = new System.Drawing.Size(398, 178);
            this.a_txt.TabIndex = 7;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_exit.Location = new System.Drawing.Point(369, 423);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 65);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // InternetFAQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 501);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.a_txt);
            this.Controls.Add(this.q_txtbox);
            this.Controls.Add(this.ans_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.qst_lbl);
            this.Controls.Add(this.headinglbl);
            this.Name = "InternetFAQs";
            this.Text = "InternetFAQs";
            this.Load += new System.EventHandler(this.InternetFAQs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headinglbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox q_txtbox;
        private System.Windows.Forms.Label qst_lbl;
        private System.Windows.Forms.Label ans_lbl;
        private System.Windows.Forms.TextBox a_txt;
        private System.Windows.Forms.Button btn_exit;
    }
}