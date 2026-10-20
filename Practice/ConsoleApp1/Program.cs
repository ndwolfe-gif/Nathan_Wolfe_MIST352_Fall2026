using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int[] intValues = { 1, 2, 3, 4, 5 };
            // Console.WriteLine(intValues.Length);
        //  string strName = "Nathan D Wolfe";
      //    Console.WriteLine(strName.ToUpper());

//          Console.WriteLine("Hello, this is our program!");
  //        Console.WriteLine("Please enter your name: ");
    //      Console.WriteLine("Please enter your age: ");

      // PrintMessages();

//          PrintLastName(strName);
       
            
            double[] dblSalaries = { 50000.00, 60000.00, 70000.00, 80000.00, 90000.00 };
            
            PrintminSalary(dblSalaries);





        }
        public static void PrintminSalary(double[] Allsalaries)
        {
            double dblMin = Allsalaries[0];
            for (int intIndex = 0; intIndex < Allsalaries.Length; intIndex++)
            {
                if (Allsalaries[intIndex] < dblMin)
                {
                    dblMin = Allsalaries[intIndex];
                }
            }
            Console.WriteLine($"Minimum Salary: {dblMin}");
        }
        public static void PrintMessages()
        {
            Console.WriteLine("Hello, this is our program!");
            Console.WriteLine("Please enter your name: ");
            Console.WriteLine("Please enter your age: ");
        }
    public static void PrintLastName(string lastName)
         { 
            String[] nameParts = lastName.Split(' ');
            Console.WriteLine($"Last Name: {nameParts[2].ToUpper()}");
        }   
    }
}
