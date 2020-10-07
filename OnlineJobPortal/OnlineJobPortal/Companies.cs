using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineJobPortal
{
    public partial class Companies : Form
    {
        public Companies()
        {
            InitializeComponent();
        }

        private void headinglbl_Click(object sender, EventArgs e)
        {

        }

        private void Companies_Load(object sender, EventArgs e)
        {
           // headinglbl.BackColor = Color.Transparent;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

        }
    }
}
