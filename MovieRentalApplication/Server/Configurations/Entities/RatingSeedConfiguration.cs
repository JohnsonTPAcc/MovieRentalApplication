using Microsoft.EntityFrameworkCore;
using MovieRentalApplication.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Drawing;

namespace MovieRentalApplication.Server.Configurations.Entities
{
    public class RatingSeedConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(
                      new Rating
                      {
                          Id = 1,
                          Name = "PG",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      },
                      new Rating
                      {
                          Id = 2,
                          Name = "PG 13",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      }
                                );
        }
    }
}