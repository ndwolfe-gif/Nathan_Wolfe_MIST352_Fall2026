namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Owners
            owner Owner1 = new owner("Owen", "304-319-1211");
            owner Owner2 = new owner("Christian", "304-692-7587");
            owner Owner3 = new owner();
            Owner3.SetName("Avery");
            Owner3.SetPhone("304-374-7489");

            // Pets
            pet Pet1 = new pet("Hunter", 13, Owner1);
            pet Pet2 = new pet("Boone", 4, Owner2);
            pet Pet3 = new pet();
            Pet3.SetName("Lina");
            Pet3.SetAge(2);
            Pet3.SetOwner(Owner3);

            // Appointments
            appointment appt1 = new appointment("12/01/2026", Pet1, 120);
            appointment appt2 = new appointment("12/02/2026", Pet2, 177.65);
            appointment appt3 = new appointment();
            appt3.SetAppt("12/03/2026");
            appt3.SetPet(Pet3);
            appt3.SetPrice(60);

            
            Owner3.SetPhone("304-376-3757");
            Pet3.SetName("Luna");
            appt3.SetAppt("6/13/2026");

            
            Console.WriteLine($"Contact card: {Owner1.BuildContactCard()}");
            Console.WriteLine($"Phone match: {Owner1.MatchesPhone("304-319-1211")}");
            Console.WriteLine($"Hunter is senior: {Pet1.IsSenior()}");
            Pet2.HaveBirthday();
            appt1.ApplyDiscount(10);
            Console.WriteLine($"Deposit: {appt1.CalcDepo():C}");
            Console.WriteLine();

           
            Owner1.SetName("");
            Pet1.SetAge(-2);
            appt1.SetPrice(-10);

            Console.WriteLine(" Owners ");
            Owner1.DisplayInfo();
            Owner2.DisplayInfo();
            Owner3.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine(" Pets ");
            Pet1.DisplayInfo();
            Console.WriteLine();
            Pet2.DisplayInfo();
            Console.WriteLine();
            Pet3.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine(" Appointments ");
            appt1.DisplayInfo();
            Console.WriteLine();
            appt2.DisplayInfo();
            Console.WriteLine();
            appt3.DisplayInfo();
        }
    }
    }