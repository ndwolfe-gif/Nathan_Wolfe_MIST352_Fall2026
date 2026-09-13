namespace Task2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USB Drive Order Estimator");

            const double taxRate = 0.06;
            const double shippingCostPerBox = 4.50;

            Console.WriteLine("Enter the customer or company name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter the number of USB drives ordered:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of one USB drive:");
            double unitPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of USB drives that fit in one box:");
            int unitsPerBox = Convert.ToInt32(Console.ReadLine());

            double merchandiseSubtotal = quantity * unitPrice;

            int numberOfBoxes = (int)Math.Ceiling((double)quantity / unitsPerBox);

            double shippingCost = numberOfBoxes * shippingCostPerBox;

            double salesTax = merchandiseSubtotal * taxRate;

            double finalTotal = merchandiseSubtotal + shippingCost + salesTax;

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine("Customer: " + customerName);
            Console.WriteLine("Quantity Ordered: " + quantity);
            Console.WriteLine("Number of Boxes: " + numberOfBoxes);
            Console.WriteLine("Merchandise Subtotal: " + merchandiseSubtotal.ToString("C"));
            Console.WriteLine("Shipping Cost: " + shippingCost.ToString("C"));
            Console.WriteLine("Sales Tax: " + salesTax.ToString("C"));
            Console.WriteLine("Final Total: " + finalTotal.ToString("C"));
        }
    }
}
