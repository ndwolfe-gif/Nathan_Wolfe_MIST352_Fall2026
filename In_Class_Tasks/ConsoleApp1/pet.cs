using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1
{
    internal class pet
    {
        //fields
        private string name;
        private int age;
        private owner Owner;

        //constructors
        public pet()
        {
            this.name = "";
            this.age = 0;
            Owner = new owner();
        }
        public pet(string name, int age, owner owner)
        {
            this.name = name;
            this.age = age;
            Owner = owner;
        }

        //methods
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                this.name = "Unknown pet";
            else
                this.name = name;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            if (age >= 0 && age <= 30)
                this.age = age;
        }
        public owner GetOwner()
        {
            return Owner;
        }
        public void SetOwner(owner Owner)
        {
            this.Owner = Owner;
        }
        public void HaveBirthday()
        {
            if (age < 30)
            {
                age++;
            }
        }
        public bool IsSenior()
        {
            if (age >= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Pet name: {name}");
            Console.WriteLine($"Pet age: {age}");
            Console.WriteLine($"Owners name: {Owner.GetName()}");
        }
    }

}
