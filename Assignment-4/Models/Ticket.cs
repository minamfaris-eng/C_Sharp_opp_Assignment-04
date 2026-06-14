namespace Assignment4.Models
{
    public class Ticket
    {
        private static int _ticketCounter = 0;
        private decimal _price;

        public string MovieName { get; set; }

        // Price must be > 0 (enforced in setter)
        public decimal Price
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new ArgumentException("Price must be greater than 0.");
            }
        }

        // Read-only, auto-incremented
        public int TicketId { get; }

        // Computed property: 14% tax
        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            TicketId = ++_ticketCounter; // Auto-increment
            MovieName = movieName;
            Price = price; // Triggers validation
        }

        // Static method to get total tickets created
        public static int GetTotalTickets() => _ticketCounter;

        public void SetPrice(decimal price)
        {
            Price = price;
            Console.WriteLine($"Setting price directly: {Price}");
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price}");
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

        public static void ProcessTicket(Ticket t)
        {
            t.PrintTicket(); 
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }
}