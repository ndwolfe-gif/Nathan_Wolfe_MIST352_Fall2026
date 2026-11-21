using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class appointment
    {
        //fields
        private pet Pet;
        private string apptDate;
        private double price;

        //constructors
        public appointment(string apptDate, pet Pet, double price)
        {
            this.apptDate = apptDate;
            this.Pet = Pet;
            this.price = price;
        }
        public appointment()
        {
            apptDate = "";
            Pet = new pet();
            price = 0.0;
        }

        //methods
        public pet GetPet()
        {
            return this.Pet;
        }
        public void SetPet(pet Pet)
        {
            this.Pet = Pet;
        }
        public string GetAppt()
        {
            return this.apptDate;
        }
        public void SetAppt(string apptDate)
        {
            this.apptDate = apptDate;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public void SetPrice(double price)
        {
            if (price >= 0)
                this.price = price;
        }
        public void ApplyDiscount(double percent)
        {
            if (percent >= 0 && percent <= 50)
            {
                price -= price * (percent / 100);
            }
        }
        public double CalcDepo()
        {
            return price * 0.25;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Pets name: {Pet.GetName()}");
            Console.WriteLine($"Appointment date: {apptDate}");
            Console.WriteLine($"Price: {price:C}");
        }

    }
}
