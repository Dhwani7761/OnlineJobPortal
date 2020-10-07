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
    public partial class Viewedcv : Form
    {
        public Viewedcv()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            label19.Enabled = true;
            lbl_add.Enabled = true;
            lbl_contact.Enabled = true;
            lbl_dob.Enabled = true;
            lbl_email.Enabled = true;
            lbl_emphist.Enabled = true;
            lbl_gender.Enabled = true;
            lbl_name.Enabled = true;
            lbl_prof_qual.Enabled = true;
            lbl_profQual.Enabled = true;
            lbl_qual.Enabled = true;
            lbl_dislpay_add.Enabled = true;
            lbl_dislpay_contact.Enabled = true;
            lbl_dislpay_dob.Enabled = true;
            lbl_display_email.Enabled = true;
            lbl_display_emphist.Enabled = true;
            lbl_display_gender.Enabled = true;
            lbl_display_qual.Enabled = true;
            lbl_display_name.Enabled = true;
            headinglbl.Enabled = false;
            enternamelbl.Enabled = false;
            txt_name.Enabled = false;
            btn_view.Enabled = false;
            String str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dhwani\Documents\Project_Final.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "Select * from CV WHERE Name = '" + txt_name.Text + "'";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr ;
            dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                lbl_display_name.Text = dr[0].ToString();
                lbl_dislpay_contact.Text = dr[1].ToString();
                lbl_dislpay_add.Text = dr[2].ToString();
                lbl_dislpay_dob.Text = dr[3].ToString();
                lbl_display_gender.Text = dr[4].ToString();
                lbl_display_email.Text = dr[5].ToString();
                lbl_display_emphist.Text = dr[6].ToString();
                lbl_prof_qual.Text = dr[7].ToString();
                lbl_display_qual.Text = dr[8].ToString();

            }
            catch (Exception a)
            {
                MessageBox.Show("Error!!!!" + a);
            }

        }

        private void lbl_dislpay_contact_Click(object sender, EventArgs e)
        {

        }
    }
}
