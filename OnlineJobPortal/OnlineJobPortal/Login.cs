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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            headinglbl.BackColor = Color.Transparent;
            emaillbl.BackColor = Color.Transparent;
            passwordlbl.BackColor = Color.Transparent;
            loginbtn.BackColor = Color.Transparent;
            resetbtn.BackColor = Color.Transparent;
            newherelbl.BackColor = Color.Transparent;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dhwani\Documents\Project_Final.mdf;Integrated Security=True;Connect Timeout=30"); 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Signup WHERE Email='" + mailtxtbox.Text + "' AND Password='" + pwdtxtbox.Text + "'", con);
            DataTable dt = new DataTable();   
            sda.Fill(dt);
            //sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("You have Applied for the job!!!!");
                    }
                    else
                        MessageBox.Show("Invalid username or password");  
                }
           
        private void button1_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
        }
    }
}
