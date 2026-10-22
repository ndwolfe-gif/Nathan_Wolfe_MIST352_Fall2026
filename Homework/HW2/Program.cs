namespace HW2
{
    internal class Program
    {// Nathan Wolfe HW2
        static void Main(string[] args)
        {
            string[] students = File.ReadAllLines("data.txt");
            if (File.Exists("data.txt"))
                Console.WriteLine("Data read successfully.");
            
            Console.WriteLine("Menu\n A) Print Student Table\n B) Grade Count\n C) Avg\n D) Highest GPA\n X) Exit.");

            char chrChoice = Console.ReadLine().ToUpper()[0];

            while (!chrChoice.Equals('X'))
            {
                switch (chrChoice)
                {
                    case 'A':
                        Console.WriteLine("ID\tName\t\tGPA");
                        Console.WriteLine("----------------------------");
                        for (int i = 0; i < students.Length; i++)
                        {
                            string[] data = students[i].Split(',');
                            Console.WriteLine($"{data[0]}\t{data[1]}\t{data[2]}");
                        }
                        break;
                    case 'B':
                        int countA = 0;
                        int countB = 0;
                        int countC = 0;
                        int countD = 0;

                        for (int i = 0; i < students.Length; i++)
                        {
                            string[] data = students[i].Split(',');
                            double gpa = double.Parse(data[2]);
                            if (gpa >= 3.75)
                            {
                                countA++;
                            }
                            else if (gpa >= 3.0)
                            {
                                countB++;
                            }
                            else if (gpa >= 2.0)
                            {
                                countC++;
                            }
                            else
                            {
                                countD++;
                            }
                        }

                        Console.WriteLine("Grade Count:");
                        Console.WriteLine($"A: {countA}");
                        Console.WriteLine($"B: {countB}");
                        Console.WriteLine($"C: {countC}");
                        Console.WriteLine($"D: {countD}");

                        break;
                    case 'C':
                        Console.WriteLine("The average GPA is: " + StudentAvg(students));
                        break;
                    case 'D':

                        break;
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("Invalid");

                        break;
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Menu\n A) Print Student Table\n B) Grade Count\n C) Avg\n D) Highest GPA\n X) Exit.");

                chrChoice = Console.ReadLine().ToUpper()[0];

            }
            static void PrintStudentTable(string[] students)
            {
                Console.WriteLine("ID\tName\t\tGPA");
                Console.WriteLine("----------------------------");
                for (int i = 0; i < students.Length; i++)
                {
                    string[] data = students[i].Split(',');
                    Console.WriteLine($"{data[0]}\t{data[1]}\t{data[2]}");
                }

            }
            static double StudentAvg(string[] students)
            {
                double totalGPA = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    string[] data = students[i].Split(',');
                    double gpa = double.Parse(data[2]);
                    totalGPA += gpa;
                }
                double AverageGPA = totalGPA / students.Length;
                return (double)AverageGPA;

            }
        }
    }
}

