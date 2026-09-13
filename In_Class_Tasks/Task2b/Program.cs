namespace Task2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Nathan 
             * Wolfe
             * MIST 352 11:30 
             * Fall 2026
             * Task 2b
             * 9/3/2026
             */
            /*
             Pseudo Code: 
            Display "Event Profit Estimator"
            Set processing fee rate to 0.03
            Display "Enter the event name: "
            Read event name
            Display "Enter the number of tickets sold: "
            Read number of tickets sold
            Convert number of tickets sold to integer
            Display "Enter the price of a ticket: "
            Read price of a ticket
            Convert price of a ticket to decimal

                        Display "Enter the cost of the event: "
                        Read cost of the event
             convert cost of the event to decimal
                        Calculate total revenue = number of tickets sold * price of a ticket
                        Calculate processing fee = total revenue * processing fee rate
                        Calculate profit = total revenue - processing fee - cost of the event
                         Display ""
                        Display "Event Name: " + event name
                        Display total revenue as a currency value
                        Display processing fee as a currency value
                        Display cost of the event as a currency value
                        Display profit as a currency value
                    */
            Console.WriteLine("Event Profit Estimator");

            double processingFeeRate = 0.03;

            Console.WriteLine("Enter the event name: ");

            string eventName = Console.ReadLine();

            Console.WriteLine("Enter the number of tickets sold: ");
            int numberOfTicketsSold = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of a ticket: ");
            double priceOfTicket = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cost of the event: ");
            double costOfEvent = double.Parse(Console.ReadLine());

            double totalRevenue = numberOfTicketsSold * priceOfTicket;

            double processingFee = totalRevenue * processingFeeRate;

            double profit = totalRevenue - processingFee - costOfEvent;
            
            Console.WriteLine("");
            Console.WriteLine($"Event Name: {eventName}");
            Console.WriteLine($"Total Revenue: {totalRevenue:C}");
            Console.WriteLine($"Processing Fee: {processingFee:C}");
            Console.WriteLine($"Cost of Event: {costOfEvent:C}");
            Console.WriteLine($"Profit: {profit:C}");
        }
    }
}


