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
    public partial class ViewCV : Form
    {
        public ViewCV()
        {
            InitializeComponent();
        }

        private void ViewCV_Load(object sender, EventArgs e)
        {
            headinglbl.BackColor = Color.Transparent;
            enternamelbl.BackColor = Color.Transparent;
            
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dhwani\Documents\Project_Final.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from  CV WHERE Name ='" +txt_name.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("is there!!!");
                Viewedcv form7 = new Viewedcv();
                form7.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
