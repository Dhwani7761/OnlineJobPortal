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


namespace OnlineJobPortal
{
    public partial class Company_Search : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr; 
        public Company_Search()
        {
            InitializeComponent();
        }

        private void btn_compny_search_Click(object sender, EventArgs e)
        {
            String str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dhwani\Documents\Project_Final.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "Select * from Companies WHERE c_name = '" + txt_search.Text + "'";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                label6.Text = dr[0].ToString();
                label7.Text = dr[1].ToString();
                chk_box_comapny_name.Text = dr[2].ToString();
                label2.Text = dr[3].ToString();
                label3.Text = dr[4].ToString();
                label4.Text = dr[5].ToString();
                label5.Text = dr[6].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            dr.Read();
            if (dr.HasRows)
            {
                chk_box_comapny_name.Text = dr[2].ToString();
                label2.Text = dr[3].ToString();
                label3.Text = dr[4].ToString();
                label4.Text = dr[5].ToString();
                label5.Text = dr[6].ToString();
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Login form13 = new Login();
            form13.Show();
        }
    }
}
