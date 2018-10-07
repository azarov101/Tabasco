using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabasco
{
    class Employee: Human
    {
        private double hourlyWage;
        private bool status;
        private string permission;
        private string email;
        private string userName;
        private string password;

        public Employee() : base()
        {
            hourlyWage = 0;
            status = true;
            permission = "Client";
            email = "";
            userName = "";
            password = "";

        }

        public Employee(string id, string fullname, string hourlyWage, string phoneNumber, string address, string permission, string email, string userName, string password) : base(id, fullname, phoneNumber, address)
        {
            setHourlyWage(hourlyWage);
            setPermission(permission);
            setEmail(email);
            setUserName(userName);
            setPassword(password);
        }
        public Employee(string id, string fullname, string hourlyWage, string phoneNumber, string address, string permission, string email) : base(id, fullname, phoneNumber, address)
        {
            setHourlyWage(hourlyWage);
            setPermission(permission);
            setEmail(email);
            userName = null;
            password = null;
        }

        public double getHourlyWage()
        {
            return hourlyWage;
        }

        public bool getStatus()
        {
            return status;
        }

        public string getPermission()
        {
            return permission;
        }

        public string getEmail()
        {
            return email;
        }

        public string getUserName()
        {
            return userName;
        }

        public string getPassword()
        {
            return password;
        }

        public void setHourlyWage(string hourlyWage)
        {
            if (!double.TryParse(hourlyWage, out this.hourlyWage))//Exception
                throw new Exception("the Hourly wage must be a number");
            if (this.hourlyWage < 0)//Exception
                throw new Exception("The hourly wage must be a positive");
        }

        public void setStatus(bool status)
        {
            this.status = status;
        }

        public void setPermission(string permission)
        {
            if (string.IsNullOrEmpty(permission))//Exception
                throw new Exception("Permission must not be null or empty.");
            this.permission = permission;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setUserName(string userName)
        {
            this.userName = userName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public override string ToString()
        {
            return (base.ToString() + "\nhourly Wage: " + hourlyWage + "\nstatus: " + status + "\npermission: " + permission + "\nemail: " + email + "\nuserName: " + userName + "\npassword: " + password);
        }
    }
}
