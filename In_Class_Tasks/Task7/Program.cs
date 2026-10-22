using System.Reflection.Metadata.Ecma335;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats the temperature out?");
            int temperature = int.Parse(Console.ReadLine());


            Console.WriteLine("how many cups were sold?");
            int cups = int.Parse(Console.ReadLine());


            DisplayReport(temperature, cups);
        }
        public static double GetPrice(int temperature)
        {
            if (temperature >= 80)
            {
                return 4.00;
            }
            else
            {
                return 3.00;

            }
           
        }
        public static void DisplayReport(int temperature, int cups)
        {
            double price = GetPrice(temperature);
            double sales = price * cups;
            double cost = 1.50 * cups;
            double profit = sales - cost;
            Console.WriteLine($"sales = ${sales} ");
            Console.WriteLine($"cost = ${cost} ");
            Console.WriteLine($"profit = ${profit}");

        }
    }
}