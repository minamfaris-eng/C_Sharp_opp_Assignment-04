using Assignment4.Models;

public class VIPTicket : Ticket
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; } = 50m;

    public VIPTicket(string movieName, decimal price, bool loungeAccess)
        : base(movieName, price)
    {
        LoungeAccess = loungeAccess;
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
    }

    public override string ToString() => base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
}