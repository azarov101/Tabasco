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
    public partial class f_Employee : Form
    {
        public f_Employee()
        {
            InitializeComponent();
        }


        private void b_addEmployee_Click(object sender, EventArgs e)
        {
            f_AddEmployee addEmployee = new f_AddEmployee();//create form
            Hide();//hide the corrent form
            addEmployee.ShowDialog();//show the "addEmployee" form
            Show();//show the corrent form
        }
    }
}
