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
    public partial class f_AddEmployee : Form
    {
        public f_AddEmployee()
        {
            InitializeComponent();
            string[] stemp = { "Client", "Kitchen", "Desk", "PurchasingManager", "Manager", "Cleaner" };//for example
            t_Permission.DataSource = stemp;//SQL READ DATABASE PERMISSION

        }

        private void t_Permission_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (t_Permission.SelectedItem.ToString() == "Cleaner" || t_Permission.SelectedItem.ToString() == "Client")
            {
                t_UserName.ResetText();
                t_Password.ResetText();
                t_UserName.Enabled = false;
                t_Password.Enabled = false; 
            }
            // t_Password.Visible = false;
            else
            {
                t_UserName.Enabled = true;
                t_Password.Enabled = true;
            }
        }

        private void b_Cancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void b_Add_Click_1(object sender, EventArgs e)
        {
            try
            {


                //////////Input temp Variables//////////
                string id = t_ID.Text;//must check if the ID allready exist in the Data Base!!
                string fullName = t_FullName.Text;
                string hourlyWage = t_HourlyWage.Text;
                string phoneNumber = t_PhoneNumber.Text;
                string address = t_Address.Text;
                if (t_Permission.SelectedItem == null)//Exeption needed to check before 
                    throw new Exception("Permission must not be null or empty.");
                string permission = t_Permission.SelectedItem.ToString();
                string email = t_Email.Text;
                string userName = t_UserName.Text;
                string password = t_Password.Text;
                ///////////////////////////////////
                //Exception
                if (!(t_Permission.SelectedItem.ToString() == "Cleaner" || t_Permission.SelectedItem.ToString() == "Client"))
                {
                    if (id == "" || fullName == "" || hourlyWage == "" || phoneNumber == "" || address == "" || permission == "" || permission == null || email == "" || userName == "" || password == "")
                        throw new Exception("One or more field is empty");
                    Employee emp = new Employee(id, fullName, hourlyWage, phoneNumber, address, permission, email, userName, password);
                    MessageBox.Show(emp.ToString());
                }
                else
                {
                    if (id == "" || fullName == "" || hourlyWage == "" || phoneNumber == "" || address == "" || permission == "" || permission == null || email == "")
                        throw new Exception("One or more field is empty");
                    Employee emp = new Employee(id, fullName, hourlyWage, phoneNumber, address, permission, email);
                    MessageBox.Show(emp.ToString());
                }

                Hide();

            }
            catch (Exception err)
            {
                MessageBox.Show("\n" + err.Message);
            }
        }
    }
}
