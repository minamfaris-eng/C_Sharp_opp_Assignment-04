using Assignment4.Models;

public class Cinema
{
    private Ticket[] _tickets = new Ticket[20];
    private int _ticketCount = 0;
    private Projector _projector;

    public string CinemaName { get; set; }

    public Cinema(string cinemaName)
    {
        CinemaName = cinemaName;
        _projector = new Projector();
    }

    public bool AddTicket(Ticket t)
    {
        if (_ticketCount < 20)
        {
            _tickets[_ticketCount++] = t;
            return true;
        }
        return false;
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("\n========== All Tickets ==========");
        for (int i = 0; i < _ticketCount; i++)
        {
            _tickets[i].PrintTicket();
        }
    }

    public void OpenCinema()
    {
        Console.WriteLine("========== Cinema Opened ==========");
        _projector.Start();
    }

    public void CloseCinema()
    {
        Console.WriteLine("\n========== Cinema Closed ==========");
        _projector.Stop();
    }
}