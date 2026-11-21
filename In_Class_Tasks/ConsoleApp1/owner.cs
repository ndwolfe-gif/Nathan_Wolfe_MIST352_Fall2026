using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class owner
    {
        //fields
        private string name;
        private string phone;

        //constructors
        public owner()
        {
            this.name = "unknown";
            this.phone = "not provided";
        }
        public owner(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        //methods
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                this.name = name;
        }
        public string GetPhone()
        {
            return this.phone;
        }
        public void SetPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                this.phone = "Unknown phone number";
            else
                this.phone = phone;
        }
        public string BuildContactCard()
        {
            return $"{name} — {phone}";
        }
        public bool MatchesPhone(string searchPhone)
        {
            return phone == searchPhone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(BuildContactCard());
        }
    }
}
