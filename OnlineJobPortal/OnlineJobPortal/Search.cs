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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            Image img = Image.FromFile("E:/Night_Fury/Sem 4/C#.Net/Online Job Portal//bg1.jpg");
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {


                    control.BackgroundImageLayout = ImageLayout.Stretch;
                    control.BackgroundImage = System.Drawing.Image.FromFile("E:/Night_Fury/Sem 4/C#.Net/Online Job Portal//bg1.jpg");
                    break;
                }
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void degreeWiseSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Degree_wise_search form9 = new Degree_wise_search();
            form9.Show();
        }

        private void companyWiseSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_Search form12 = new Company_Search();
            form12.Show();

        }
    }
}
