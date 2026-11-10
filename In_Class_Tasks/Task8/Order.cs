using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleApp1
{
    internal class Order
    {
        //fields

        private int OrderNumber;

        private string customerName;
      
     public Order(int orderNumber, string customerName)
        {
            this.OrderNumber = orderNumber;
            this.customerName = customerName;
        }

        //methods

        public int GetOrderNumber()
        {
            return this.OrderNumber;
        }
        public void SetOrderNumber(int orderNumber)
        {
            if (orderNumber < 1)
                this.OrderNumber = 1;
            else
                this.OrderNumber = orderNumber;
        }
        public string GetCustomerName()
        {
            return this.customerName;
        }
        public void SetCustomerName(string customerName)
        {
            if (string.IsNullOrEmpty(customerName))
                this.customerName = "Unknown customer";
            else
                this.customerName = customerName;
        }
    }
}