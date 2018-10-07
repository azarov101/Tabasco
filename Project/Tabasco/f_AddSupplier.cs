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
    public partial class f_AddSupplier : Form
    {
        public f_AddSupplier()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_Submit_Click(object sender, EventArgs e)
        {
            string id = t_ID.Text;
            string name = t_FullName.Text;
            string address = t_Address.Text;
            string phone = t_PhoneNumber.Text;
            string email = t_Email.Text;

            

            if (string.IsNullOrWhiteSpace(t_ID.Text) || string.IsNullOrWhiteSpace(t_FullName.Text) || string.IsNullOrWhiteSpace(t_Address.Text) || string.IsNullOrWhiteSpace(t_ID.Text) || string.IsNullOrWhiteSpace(t_PhoneNumber.Text) || string.IsNullOrWhiteSpace(t_Email.Text))
                MessageBox.Show("Please fill all the fields");
            else
            {
                MessageBox.Show("Supplier added to the data base");
                Supplier add = new Supplier(id, name, address, phone, email);
            }
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f_AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void t_FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_PhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
