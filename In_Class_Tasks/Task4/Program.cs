using System;
using System.ComponentModel.Design;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {//greeting
            Console.WriteLine("Thank you for shopping with us!");
            Console.WriteLine("");

            Console.WriteLine("Are you a member of our loyalty program? (yes/no)");
            string isMember = Console.ReadLine().ToLower();
            Console.WriteLine("What is your order total?");

            double Ordertotal = Convert.ToDouble(Console.ReadLine());
            double discount = 0.0;
            double discountedTotal = Ordertotal - discount;

            if (isMember == "yes")
            {
                Console.WriteLine("Great! You will receive a discount based on your order total.");
                Console.WriteLine("");
            }
            else if (isMember == "no")
            {
                Console.WriteLine("No worries! You may sign up here.");
                Console.WriteLine("https://www.example.com/loyalty-program");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                return; // brings them back to the start of the program if they input anything other than yes or no
            }

            
            // getting the order total from the user and converting it to be used as a decimal 



            // my if statments on the order total and the discount based on the order total
            // if they put yes to being a member of the loyalty program they will get a discount based on their order total

            if (isMember == "yes")
            {
                if (Ordertotal >= 100)
                {
                    discount = Ordertotal * 0.15;

                    Console.WriteLine($"Congrats you get 15% off! Your discounted total is: ${discountedTotal:F2}");
                }
                else if (Ordertotal < 100)
                {
                    discount = Ordertotal * 0.10;

                    Console.WriteLine($"Congrats you get 10% off! Your discounted total is: ${discountedTotal:F2}");
                }
            }
            else if (isMember == "no" && Ordertotal >= 150)
            {
                discount = Ordertotal * 0.05;

                Console.WriteLine($"Congrats you get 5% off! Your discounted total is: ${discountedTotal:F2}");
                // making space between the output and the order total
                Console.WriteLine("");
                Console.WriteLine($"Your order total is: ${Ordertotal:F2}");

            }
            else if (isMember == "no" && Ordertotal < 150)
            {
                Console.WriteLine("Sorry, you do not qualify for a discount.");
                Console.WriteLine("");
                Console.WriteLine($"Your order total is: ${Ordertotal:F2}");
            }
            if (discountedTotal >= 75)
            {
                Console.WriteLine("You qualify for free shipping!");
            }
            else
            {
                Console.WriteLine("You do not qualify for free shipping.");
                Console.WriteLine("");
                double shippingCost = 8.99;
                Console.WriteLine($"Order Total: ${shippingCost + discountedTotal:F2}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"Original Total: ${Ordertotal:F2}");
                Console.WriteLine($"Discount Amount: ${discount:F2}");
                Console.WriteLine($"Discounted Total: ${discountedTotal:F2}");
                Console.WriteLine($"Shipping Cost: ${shippingCost:F2}");
                Console.WriteLine($"Final Total: ${shippingCost + discountedTotal:F2}");

            }
        }
    }
}


        
           