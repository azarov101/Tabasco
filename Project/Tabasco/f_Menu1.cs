using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabasco
{
    public partial class f_Menu1 : Form
    {
        public f_Menu1()
        {
            InitializeComponent();
        }

        private void b_General_Click(object sender, EventArgs e)
        {
            f_Gmenu menu1 = new f_Gmenu();
            this.Visible = false;
            menu1.Show();
        }

        private void b_Vegeterian_Click(object sender, EventArgs e)
        {


        }
    }
}
