using Assignment4.Models;

public class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movieName, decimal price, bool is3D)
        : base(movieName, is3D ? price + 30m : price)
    {
        Is3D = is3D;
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
    }

    public override string ToString() => base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
}
