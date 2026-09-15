using System.Transactions;

namespace psuedo_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Nathan
             * Wolfe
             * 10:30 Mist 352
             * Task2a
             * Date: 09/3/2026
             */
            Console.WriteLine("USB Order Esimator");

            double taxRate = 0.06;
            double ShippingCostPerBox = 4.50;  
            Console.WriteLine("Enter th customer or company name : ");
            string customerName = Console.ReadLine();
            
            Console.WriteLine("Enter the number of usb drives to be ordered: ");
            int numberOfDrives = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per usb drive: ");
            double pricePerDrive = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of usb's that can fit in a box: ");
            int drivesPerBox = int.Parse(Console.ReadLine());

            double subtotal = numberOfDrives * pricePerDrive;

            double numberOfBoxes = Math.Ceiling((double)numberOfDrives / drivesPerBox);

            double shippingCost = numberOfBoxes * ShippingCostPerBox;

            double salesTax = subtotal * taxRate;

            double totalCost = subtotal + shippingCost + salesTax;

            Console.WriteLine();
            Console.WriteLine("Order Summary for: " + customerName);
            Console.WriteLine($"Quantity of USB Drives: {numberOfDrives}");
            Console.WriteLine($"Number of Boxes: {numberOfBoxes}");
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Shipping Cost: {shippingCost:C}");
            Console.WriteLine($"Sales Tax: {salesTax:C}");
            Console.WriteLine($"Total Cost: {totalCost:C}");

        }
    }
}
