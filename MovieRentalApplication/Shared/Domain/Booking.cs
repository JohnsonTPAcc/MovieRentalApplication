using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MovieRentalApplication.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
    {
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public int MovieId { get; set; }
        public virtual Movie? Movie { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn != null)
            {
                if (DateIn <= DateOut)
                {
                    yield return new ValidationResult("DateIn must be greater than DateOut", new[] { "DateIn" });
                }
            }    
        }
    }
}