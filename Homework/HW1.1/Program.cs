namespace HW1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               * Author: Nathan Wolfe
               * Class: MIST352- fall 2026
               * HW 1
               This program organizes purchase orders for particular items. 

               */

            /*
             Product 1
             */
            Console.WriteLine("Please enter the name of product: ");
            string productName1 = Console.ReadLine();

            productName1 = char.ToUpper(productName1[0]) + productName1.Substring(1).ToLower();

            Console.WriteLine("Please enter the quantity of product: ");
            int productQuantity1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of product: ");
            double productPrice1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter product serial number: ");
            int productSerial1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter product category : ");
            string productCategory1 = Console.ReadLine();

            productCategory1 = char.ToUpper(productCategory1[0]) + productCategory1.Substring(1).ToLower();

            double totalCost1 = productQuantity1 * productPrice1;
            
            /*
             Product 2
             */
            Console.WriteLine("Please enter the name of product: ");
            string productName2 = Console.ReadLine();

            productName2 = char.ToUpper(productName2[0]) + productName2.Substring(1).ToLower();

            Console.WriteLine("Please enter the quantity of product: ");
            int productQuantity2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of product: ");
            double productPrice2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter product serial number: ");
            int productSerial2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter product category : ");
            string productCategory2 = Console.ReadLine();

            productCategory2 = char.ToUpper(productCategory2[0]) + productCategory2.Substring(1).ToLower();

            double totalCost2 = productQuantity2 * productPrice2;
           

            /*
             Product 3
             */
            Console.WriteLine("Please enter the name of product: ");
            string productName3 = Console.ReadLine();

            productName3 = char.ToUpper(productName3[0]) + productName3.Substring(1).ToLower();

            Console.WriteLine("Please enter the quantity of product: ");
            int productQuantity3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of product: ");
            double productPrice3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter product serial number: ");
            int productSerial3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter product category : ");
            string productCategory3 = Console.ReadLine();

            productCategory3 = char.ToUpper(productCategory3[0]) + productCategory3.Substring(1).ToLower();

            double totalCost3 = productQuantity3 * productPrice3;

            /*
             Product 4
             */
            Console.WriteLine("Please enter the name of product: ");
            string productName4 = Console.ReadLine();

            productName4 = char.ToUpper(productName4[0]) + productName4.Substring(1).ToLower();

            Console.WriteLine("Please enter the quantity of product: ");
            int productQuantity4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of product: ");
                    double productPrice4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter product serial number: ");
            int productSerial4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter product category : ");
            string productCategory4 = Console.ReadLine();

            productCategory4 = char.ToUpper(productCategory4[0]) + productCategory4.Substring(1).ToLower();

            double totalCost4 = productQuantity4 * productPrice4;

            Console.WriteLine();
            Console.WriteLine($"{"Name",-16} {"Serial",-9} {"Price",-10} {"Quantity",-10} {"Category",-13} {"Total Price"}");

            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine($"{productName1,-16} {productSerial1,-9} {productPrice1,-10:C} {productQuantity1,-10} {productCategory1,-13} {totalCost1:C}");
            Console.WriteLine($"{productName2,-16} {productSerial2,-9} {productPrice2,-10:C} {productQuantity2,-10} {productCategory2,-13} {totalCost2:C}");
            Console.WriteLine($"{productName3,-16} {productSerial3,-9} {productPrice3,-10:C} {productQuantity3,-10} {productCategory3,-13} {totalCost3:C}");
            Console.WriteLine($"{productName4,-16} {productSerial4,-9} {productPrice4,-10:C} {productQuantity4,-10} {productCategory4,-13} {totalCost4:C}");


        }
    }
}

