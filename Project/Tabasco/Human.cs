using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabasco
{
    abstract class Human
    {
        private string id;
        private string fullName;
        private string phoneNumber;
        private string address;

        public Human()
        {
            id = null;
            fullName = null;
            phoneNumber = null;
            address = null;
        }

        public Human(string id, string fullName, string phoneNumber, string address)
        {
            setID(id);
            setFullName(fullName);
            setPhoneNumber(phoneNumber);
            setAddress(address);
        }

        public string getID()
        {
            return id;
        }

        public string getFullName()
        {
            return fullName;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public string getAdderss()
        {
            return address;
        }

        public void setID(string id)
        {
            if (string.IsNullOrEmpty(id))//Exception
                throw new Exception("ID must not be null or empty.");
            double temp;//Not used
            if (!double.TryParse(id, out temp))//Exception
                throw new Exception("ID must be a number");

            if (id.Length != 9)//Exception
                throw new Exception("ID must contains 9 digits");
            id.Take(0);
            if (id.Contains("+") || id.Contains("-"))
                throw new Exception("ID must be unsign");
            this.id = id;
        }

        public void setFullName(string fullName)
        {
            this.fullName = fullName;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            double temp;//not for use
            if (!double.TryParse(phoneNumber, out temp))//Exception
                throw new Exception("Phone number must be a number");
            if (phoneNumber.Contains("+") || phoneNumber.Contains("-"))
                throw new Exception("Phone number must be unsign");
            if (!(phoneNumber.Length == 9 || phoneNumber.Length == 10))//Exception
                throw new Exception("Phone number must contain 9 or 10 digit");
            this.phoneNumber = phoneNumber;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public override string ToString()
        {
            return "id: " + id + "\nfull Name: " + fullName + "\nphone Number: " + phoneNumber + "\naddress: " + address;
        }
    }
}
