namespace MovieRentalApplication.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? Address { get; set; }
        public List<Booking>? Bookings { get; set; }
    }
}