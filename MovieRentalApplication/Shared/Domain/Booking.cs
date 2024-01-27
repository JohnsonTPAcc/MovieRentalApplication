namespace MovieRentalApplication.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int MovieId { get; set; }
        public virtual Movie? Movie { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}