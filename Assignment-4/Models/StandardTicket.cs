using Assignment4.Models;

public class StandardTicket : Ticket
{
    public string SeatNumber { get; set; }

    public StandardTicket(string movieName, decimal price, string seatNumber)
        : base(movieName, price)
    {
        SeatNumber = seatNumber;
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"Seat: {SeatNumber}");
    }

    public override string ToString() => base.ToString() + $" | Seat: {SeatNumber}";
}
