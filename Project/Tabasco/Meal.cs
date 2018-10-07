using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabasco
{
    class Meal
    {
        private string code;
        private string category;
        private string price;
        private string name;
        private string details;
        private bool status;
        private float rate;
        private int rateQuantity;
        private bool vegeterian;


        public Meal()
        {
            code = null;
            category = null;
            price = null;
            name = null;
            details = null;
            status = false;
            rate = 0;
            rateQuantity = 0;
            vegeterian = false;
        }
        public Meal(string code,string category,string price,string name,string details,bool status,float rate,int rateQuantity,bool vegeterian)
        {
            setCode(code);
            setCategory(category);
            setPrice(price);
            setName(name);
            setDetails(details);
            setStatus(status);
            setRate(rate);
            setRateQuantitiy(rateQuantity);
            setVegeterian(vegeterian);
        }

        void setCode(string code) { this.code = code; }
        void setCategory(string category) { this.category = category; }
        void setPrice(string price) { this.price = price; }
        void setName(string name) { this.name = name; }
        void setDetails(string details) { this.details = details; }
        void setStatus(bool status) { this.status = status; }
        void setRate(float rate) { this.rate = rate; }
        void setRateQuantitiy(int rateQuantity) { this.rateQuantity = rateQuantity; }
        void setVegeterian(bool vegeterian) { this.vegeterian = vegeterian; }

        string getCode() { return code; }
        string getCategory() {return category; }
        string getPrice() { return price; }
        string getName() { return name; }
        string getDetails() { return details; }
        bool getStatus() { return status; }
        float getRate() { return rate; }
        int getRateQuantitiy() { return rateQuantity; }
        bool getVegeterian() { return vegeterian; }



        


    }
}
