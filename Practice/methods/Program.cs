namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dblSalaries = { 100000, 200000, 300000, 400000, 500000 };
            string[] strNames = { "John", "Jane", "Jim", "Jill", "Jack" };
        }
        public static int highestSalaryIndex(double[] theSalaries)
        {
            int intHighestSalaryIndex = 0;
            for (int i = 0; i < theSalaries.Length; i++)
            {
                if (theSalaries[i] > theSalaries[intHighestSalaryIndex])
                {
                    intHighestSalaryIndex = i;
                }
            }
            return intHighestSalaryIndex;
        }
        /// <summary>
        /// 
        ///
        /// </summary>
        /// <param name="theSalaries"></param>
        public static void PrintHighiestSalary(double[] theSalaries)
        {
            double dblHighiestSalary = 0;
            for (int i = 0; i < theSalaries.Length; i++)
            {
                if (theSalaries[i] > dblHighiestSalary)
                {
                    dblHighiestSalary = theSalaries[i];
                }
            }
            Console.WriteLine($"The highest salary is: {dblHighiestSalary}");

        }

    }

}
