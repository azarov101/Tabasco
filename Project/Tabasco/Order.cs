using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabasco
{
    abstract class Order
    {
        protected int orderNumber;
        protected string date;
        protected int amount;
        protected double priceForOrder;
        protected string workerID;
        protected string status;

        // Default Ctor
        protected Order() : this(0, null, 0, 0, null, null) { } // call parametric constructor //

        // Parametric Ctor
        protected Order(int orderNumber, string date, int amount, double priceForOrder, string workerID, string status)
        {
            setOrderNumber(orderNumber);
            setDate(date);
            setAmount(amount);
            setPriceForOrder(priceForOrder);
            setWorkerID(workerID);
            setStatus(status);
        }

        // Setters:
        public void setOrderNumber(int orderNumber) { this.orderNumber = orderNumber; }
        public void setDate(string date) { this.date = date; }
        public void setAmount(int amount) { this.amount = amount; }
        public void setPriceForOrder(double priceForOrder) { this.priceForOrder = priceForOrder; }
        public void setWorkerID(string workerID) { this.workerID = workerID; }
        public void setStatus(string status) { this.status = status; }

        // Getters:
        public int getOrderNumber() { return orderNumber; }
        public string getDate() { return date; }
        public int getAmount() { return amount; }
        public double getPriceForOrder() { return priceForOrder; }
        public string getWorkerID() { return workerID; }
        public string getStatus() { return status; }
    }
}
