using System.Security.Cryptography.X509Certificates;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hardcode the message 
            string strMsg = "WAKE UP, NEO | Location: Zion |Time: 08:00 PM | Code: #NEO-7 | Pill: Red";
            string[] splittedMsg = strMsg.Split('|');
            string strPart1 = splittedMsg[0];
            string strPart2 = splittedMsg[1];
            string strPart3 = splittedMsg[2];
            string strPart4 = splittedMsg[3];
            string strPart5 = splittedMsg[4];
            Console.WriteLine($"Alert: {strPart1.ToUpper().Replace(", ",",")}");
            Console.WriteLine($"Agent:{strPart1.Split(',')[1]}");
            Console.WriteLine($"Location:{strPart2.Replace("Location: ","")}");
            Console.WriteLine($"Time:{strPart3.Replace("Time: ","")}");
            Console.WriteLine($"Code:{strPart4.Replace("Code: ","")}");
            Console.WriteLine($"Pill:{strPart5.Replace("Pill: ","")}");
        }
    }
}