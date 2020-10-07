using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OnlineJobPortal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread td = new Thread(new ThreadStart(OnlineJobPortal));
            td.Start();
            Thread.Sleep(5000);
            
            InitializeComponent();
            td.Abort();
        }
        public void OnlineJobPortal()
        {
            Application.Run(new Form2());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contactUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp form2 = new SignUp();
            form2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }

        private void contactUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pankil Anand - +918511318341 \nDhwani Kshatriya - +919429538704 \nKaushiki Nanavati - +919429067048");
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search form3 = new Search();
            form3.Show();
        }

        private void interviewFAQsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternetFAQs form4 = new InternetFAQs();
            form4.Show();
        }

        private void createCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CV form5 = new CV();
            form5.Show();
        }

        private void deleteCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewedcv form6 = new Viewedcv();
            form6.Show();

        }
    }
}
