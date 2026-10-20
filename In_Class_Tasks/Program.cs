namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number between 1 and 10");
            int number = int.Parse(Console.ReadLine());

            if (IsValidRows(number) == true)
            {
                PrintStars(number);
                Console.WriteLine("There are " + CountRows(number) + " rows");

            }
            else
            {
                Console.WriteLine("invalid number");
            }


        }
        static bool IsValidRows(int number)
        {
            if (number >= 1 && number <= 10)
                return true;
            else
                return false;
        }
        static int CountRows(int number)
        {
            int count = 0;
            for (int index = 1; index <= number; index++)
            {
                count++;
            }
            return count;
        }
        static void PrintStars(int number)
        {
            int introw = 1;
            while (introw <= number)
            {
                int star = 1;
                while (star <= introw)
                {
                    Console.Write("*");
                    star++;
                }
                Console.WriteLine();
                introw++;
            }
        }
    }
}