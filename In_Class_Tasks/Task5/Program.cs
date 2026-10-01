namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number between 1 and 10");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("good number");
               Console.WriteLine("");
                Console.WriteLine("");
                int introw = 1;
                while (introw <= number)

                {                     int star = 1;
                    for(star = 1; star <= introw; star++)
                    {
                        Console.Write("*");
                    
                    }
                    Console.WriteLine();
                    introw++;
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}
