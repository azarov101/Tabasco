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
    public partial class f_Menu : Form
    {
        public f_Menu()
        {
            InitializeComponent();
        }

        private void b_Menu_Click(object sender, EventArgs e)
        {
            f_Menu1 menu = new f_Menu1();
            Hide();//hide the corrent form
            menu.ShowDialog();//show the "menu" form
            Show();//show the corrent form
        }

        private void b_employee_Click(object sender, EventArgs e)
        {
            f_Employee employee = new f_Employee();
            Hide();
            employee.ShowDialog();
            Show();
            
        }
    }
}
