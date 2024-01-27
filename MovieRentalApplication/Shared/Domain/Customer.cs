using System.ComponentModel.DataAnnotations;

namespace MovieRentalApplication.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name is too long.")]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string? LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? ContactNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }
        public string? Address { get; set; }
        public List<Booking>? Bookings { get; set; }
    }
}
