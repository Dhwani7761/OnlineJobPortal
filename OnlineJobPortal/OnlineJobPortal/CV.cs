using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;


namespace OnlineJobPortal
{
    public partial class CV : Form
    {
        public CV()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CV_Load(object sender, EventArgs e)
        {
            lbl_name.BackColor = Color.Transparent;
            lbl_telephone.BackColor = Color.Transparent;
            lbl_address.BackColor = Color.Transparent;
            lbl_dob.BackColor = Color.Transparent;
            lbl_gender.BackColor = Color.Transparent;
            lbl_email.BackColor = Color.Transparent;
            lbl_emphistory.BackColor = Color.Transparent;
            lbl_pq.BackColor = Color.Transparent;
            lbl_qualification.BackColor = Color.Transparent;
            heading_lbl.BackColor = Color.Transparent;
            save_btn.BackColor = Color.Transparent;
            View_btn.BackColor = Color.Transparent;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dhwani\Documents\Project_Final.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            String sql = "insert into CV(Name , Contact , Address , DateOfBirth , Gender , Email ,EmploymentHistory , ProfessionalQualification , Qualification)";
            sql += "VALUES (@name,@contact,@address,@dob,@gender,@email,@emphist,@profqual,@qual)";
            cmd.Parameters.AddWithValue("name", txt_name.Text.Trim());
            cmd.Parameters.AddWithValue("contact", txt_telephone.Text.Trim());
            cmd.Parameters.AddWithValue("address", txt_address.Text.Trim());
            cmd.Parameters.AddWithValue("dob", dateTimePicker1.Text.Trim());
            cmd.Parameters.AddWithValue("gender", txt_gender.Text.Trim());
            cmd.Parameters.AddWithValue("email", txt_email.Text.Trim());
            cmd.Parameters.AddWithValue("emphist", txt_emphis.Text.Trim());
            cmd.Parameters.AddWithValue("profqual", txt_pq.Text.Trim());
            cmd.Parameters.AddWithValue("qual", txt_qualification.Text.Trim());
            

            cmd.Connection = con;
            cmd.CommandText = sql;
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!! Please View your CV");
            }
            catch (Exception a)
            {
                MessageBox.Show("Try again Later!!!" + a);
            }

        }

        private void btn_uploadImange_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                Byte[] bt = new Byte[ms.Length];
                ms.Read(bt, 0, bt.Length);
                 SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update table CV values(@Photo)";
                cmd.Parameters.AddWithValue("@pic", bt);
               
                
               // cmd.Parameters.AddWithValue("@id", 1);
                
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image *.jpg|*.jpg";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
