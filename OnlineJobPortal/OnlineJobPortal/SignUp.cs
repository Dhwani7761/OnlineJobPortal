using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineJobPortal
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            headinglbl.BackColor = Color.Transparent;
            namelbl.BackColor = Color.Transparent;
            addresslbl.BackColor = Color.Transparent;
            contactlbl.BackColor = Color.Transparent;
            maillbl.BackColor = Color.Transparent;
            passwordlbl.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dhwani\Documents\Project_Final.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            string sql = "INSERT INTO Signup(Name , Address , Contact  , Email , Password)";
            sql += "VALUES (@name,@address,@contact,@email,@password) ";
            cmd.Parameters.AddWithValue("name", nametxtbox.Text.Trim());
            cmd.Parameters.AddWithValue("address", addresstxtbox.Text.Trim());
            cmd.Parameters.AddWithValue("contact", contacttxtbox.Text.Trim());
            cmd.Parameters.AddWithValue("email", mailtxtbox.Text.Trim());
            cmd.Parameters.AddWithValue("password", passwordtxtbox.Text);
            cmd.Connection = con;
            cmd.CommandText = sql;
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!!Please Login");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again!"+ex);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }
    }
}
