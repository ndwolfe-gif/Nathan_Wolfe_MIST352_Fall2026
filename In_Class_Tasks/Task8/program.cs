using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("cpu", 499);
            p1.SetName("");
            p1.SetUnitPrice(0);
            Console.WriteLine(p1.GetName());
            Console.WriteLine(p1.GetUnitPrice());


            Product p2 = new Product("gpu", 1200);
            p2.SetName("gpu");
            p2.SetUnitPrice(1200);
            Console.WriteLine(p2.GetName());
            Console.WriteLine(p2.GetUnitPrice());


            Product p3 = new Product("ram", 599);
            p3.SetName("ram");
            p3.SetUnitPrice(599);
            Console.WriteLine(p3.GetName());
    
            Console.WriteLine(p3.GetUnitPrice());

            Order o1 = new Order(101, "james");
            o1.SetOrderNumber(101);
            o1.SetCustomerName("james");
            Console.WriteLine(o1.GetCustomerName());
            Console.WriteLine(o1.GetOrderNumber());


            Order o2 = new Order(104,"martin");
            o2.SetOrderNumber(104);
            o2.SetCustomerName("martin");
            Console.WriteLine(o2.GetCustomerName());
            Console.WriteLine(o2.GetOrderNumber());


            Order o3 = new Order(103, "alex");
            o3.SetOrderNumber(103);
            o3.SetCustomerName("alex");
            Console.WriteLine(o3.GetCustomerName());
            Console.WriteLine(o3.GetOrderNumber());


        }
    }
}
