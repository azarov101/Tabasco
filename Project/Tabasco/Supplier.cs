using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabasco
{
    class Supplier
    {
        private string id;
        private string name;
        private string address;
        private string phone;
        private string email;

        public Supplier()
        {
            id = null;
            name = null;
            address = null;
            phone=null;
            email = null;
        }
        public Supplier(string id, string name, string address,string phone,string email)
        {
            setId(id);
            setName(name);
            setAddress(address);
            setPhone(phone);
            setEmail(email);
        }

        public void setId(string id) { this.id = id; }
        public void setName(string name) { this.name = name; }
        public void setAddress(string address) { this.address = address; }
        public void setPhone(string phone) { this.phone = phone; }
        public void setEmail(string email) { this.email = email; }

        public string getId() { return id; }
        public string getName() { return name; }
        public string getAddress() { return address; }
        public string getPhone() { return phone; }
        public string getEmail() { return email; }

        

       

    }
}
