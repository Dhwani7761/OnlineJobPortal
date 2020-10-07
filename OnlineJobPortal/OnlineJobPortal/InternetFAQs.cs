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
using System.Data.Sql;

namespace OnlineJobPortal
{
    public partial class InternetFAQs : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public InternetFAQs()
        {
            InitializeComponent();
        }
       
        private void InternetFAQs_Load(object sender, EventArgs e)
        {
            String str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dhwani\Documents\Project_Final.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "Select Questions,Answers from FAQ";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                q_txtbox.Text = dr[0].ToString();
                a_txt.Text = dr[1].ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(""+a);
            }
            headinglbl.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dr.Read();
            if (dr.HasRows)
            {
                q_txtbox.Text = dr[0].ToString();
                a_txt.Text = dr[1].ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           /* con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dhwani\Documents\Project_Final.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Questions from FAQ where Q_id=1";
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            dr.Read();
            q_txtbox.Text = dr.GetString(1);*/
           
        }

        private void headinglbl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dr.Read();
            if (dr.HasRows)
            {
                q_txtbox.Text = dr[0].ToString();
                a_txt.Text = dr[1].ToString();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
