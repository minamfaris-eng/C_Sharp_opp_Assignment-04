using Assignment4.Models;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // a. Create a Cinema and open it
            Cinema cinema = new Cinema("Cinema City");
            cinema.OpenCinema();

            // b. Create one StandardTicket, one VIPTicket, and one IMAXTicket
            StandardTicket t1 = new StandardTicket("Inception", 100m, "A-5");
            VIPTicket t2 = new VIPTicket("Avengers", 200m, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 180m, false);

            // c. Test both versions of SetPrice on one ticket
            Console.WriteLine("\n========== SetPrice Test ==========");
            t1.SetPrice(150);           // Calls SetPrice(decimal)
            t1.SetPrice(100m, 1.5m);    // Calls SetPrice(decimal, decimal)

            // d. Add all tickets to the Cinema and call PrintAllTickets()
            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);
            cinema.PrintAllTickets();

            // e. Call ProcessTicket() with one of the tickets (demonstrates polymorphism)
            Console.WriteLine("\n========== Process Single Ticket ==========");
            Ticket.ProcessTicket(t2);

            // f. Close the Cinema
            cinema.CloseCinema();
        }
    }
}