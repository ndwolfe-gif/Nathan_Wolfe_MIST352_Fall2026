namespace practice_if_statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 220;
            if (total > 200)
            {
                Console.WriteLine("You have more than $200");
            }
            else if (total < 200)
            {
                Console.WriteLine("You have less than $200");
            }
            else
            {
                Console.WriteLine("You have exactly $200");
            }

        }
    }
}
