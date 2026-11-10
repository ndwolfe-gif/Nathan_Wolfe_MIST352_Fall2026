using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp1
{
    internal class Product
    {
        //fields
        private string name;
        private double unitPrice;


        //CONSTRUCTOR
        public Product(string theName, double thePrice)
        {
            this.name = theName;
            this.unitPrice = thePrice;

        }
        //METHODS
        public string GetName()
        {
            return this.name.ToUpper();
        }
        public void SetName(string theName)
        {
            if (string.IsNullOrEmpty(theName))
                this.name = "Unknown product";
            else
                this.name = theName;
        }
        public double GetUnitPrice()
        {
            return this.unitPrice;
        }
        public void SetUnitPrice(double unitPrice)
        {
            if (double.IsNegative(unitPrice))
                this.unitPrice = 0;
            else
                this.unitPrice = unitPrice;
        }
    }
}
