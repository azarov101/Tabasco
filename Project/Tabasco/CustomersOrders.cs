using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tabasco
{
    class CustomersOrders
    {
        private int orderNumber;
        private string date;
        private string mealCode;
        private int amount;
        private double pricePerMeal;
        private double priceForOrder;
        private string name;
        private string workerID;
        private bool delivery;
        private bool toPack;
        private string specialReq;
        private string status;
        private string review;
        private string dealCode;
        private int amountOfDeals;

        // Default Ctor
        public CustomersOrders() : this(0, null, null, 0, 0, 0, null, null, false, false, null, null, null, null, 0) {} // call parametric constructor //
 
        // Parametric Ctor
        public CustomersOrders(int orderNumber, string date, string mealCode, int amount, double pricePerMeal, double priceForOrder, string name, string workerID, bool delivery, bool toPack, string specialReq, string status, string review, string dealCode, int amountOfDeals)
        {
            setOrderNumber(orderNumber);
            setDate(date);
            setMealCode(mealCode);
            setAmount(amount);
            setPricePerMeal(pricePerMeal);
            setPricePerOrder(priceForOrder);
            setName(name);
            setWorkerID(workerID);
            setDelivery(delivery);
            setToPack(toPack);
            setSpecialReq(specialReq);
            setStatus(status);
            setReview(review);
            setDealCode(dealCode);
            setAmountOfDeals(amountOfDeals);
        }

        // Setters:
        public void setOrderNumber(int orderNumber) { this.orderNumber = orderNumber; }
        public void setDate(string date) { this.date = date; }
        public void setMealCode(string mealCode) { this.mealCode = mealCode; }
        public void setAmount(int amount) { this.amount = amount; }
        public void setPricePerMeal(double pricePerMeal) { this.pricePerMeal = pricePerMeal; }
        public void setPriceForOrder(double priceForOrder) { this.priceForOrder = priceForOrder }
        public void setName(string name) { this.name = name; }
        public void setWorkerID(string workerID) { this.workerID = workerID; }
        public void setDelivery(bool delivery) { this.delivery = delivery; }
        public void setToPack(bool toPack) { this.toPack = toPack; }
        public void setSpecialReq(string specialReq) { this.specialReq = specialReq; }
        public void setStatus(string status) { this.status = status; }
        public void setReview(string review) { this.review = review; }
        public void setDealCode(string dealCode) { this.dealCode = dealCode; }
        public void setAmountOfDeals(int amountOfDeals) { this.amountOfDeals = amountOfDeals; }

        // Getters:
        public int getOrderNumber() { return orderNumber; }
        public string getDate() { return date; }
        public string getMealCode() { return mealCode; }
        public int getAmount() { return amount; }
        public double getPricePerMeal() { return pricePerMeal; }
        public double getPriceForOrder() { return priceForOrder }
        public string getName() { return name; }
        public string getWorkerID() { return workerID; }
        public bool getDelivery() { return delivery; }
        public bool getToPack() { return toPack; }
        public string getSpecialReq() { return specialReq; }
        public string getStatus() { return status; }
        public string getReview() { return review; }
        public string getDealCode() { return dealCode; }
        public int getAmountOfDeals() { return amountOfDeals; }

    }
}
