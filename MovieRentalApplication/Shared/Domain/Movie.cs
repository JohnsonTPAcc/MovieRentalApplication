using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalApplication.Shared.Domain
{
    public class Movie : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int DirectorId { get; set; }
        public virtual Director? Director { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set;}
        public virtual List<Booking>? Bookings { get; set; }

        public int RatingId { get; set; }
        public virtual Rating? Rating { get; set; }

        public double RentalRate { get; set; }
    }
}
