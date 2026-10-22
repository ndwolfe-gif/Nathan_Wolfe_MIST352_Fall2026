namespace HW2
{
    internal class Program
    {// Nathan Wolfe HW2
        static void Main(string[] args)
        {
            string[] students = File.ReadAllLines("data.txt");
            if (File.Exists("data.txt"))
                Console.WriteLine("Data read successfully.");
            
            Console.WriteLine("Menu\n A) Display Student Table\n B) Count Students by Letter Grade\n C) Show GPA Average\n D) Show Highest GPA Student\n X) Exit.");

            char chrChoice = Console.ReadLine().ToUpper()[0];

            while (!chrChoice.Equals('X'))
            {
                switch (chrChoice)
                {
                    case 'A':
                        PrintStudentTable(students);
                        
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
                        TopStudent(students);
                        break;
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("Invalid");

                        break;
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Menu\n A) Display Student Table\n B) Count Students by Letter Grade\n C) Show GPA Average\n D) Show Highest GPA Student\n X) Exit.");

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
     static void TopStudent(string[] students)
        {
             
            string TopStudentID = "";
            string topName = "";
            double HighestGPA = 0;
            
                for (int i = 0; i < students.Length; i++)
            {
                string[] data = students[i].Split(',');
                double gpa = double.Parse(data[2]);
                if (gpa > HighestGPA)
                {
                  HighestGPA = gpa;
                    topName = data[1];
                    TopStudentID = data[0];
                      }

                }
            Console.WriteLine($"Student {TopStudentID} {topName} has the highest gpa in the class of {HighestGPA}");
        }
        }
    }


