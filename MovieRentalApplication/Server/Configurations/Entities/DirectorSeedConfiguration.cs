using Microsoft.EntityFrameworkCore;
using MovieRentalApplication.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Drawing;
namespace MovieRentalApplication.Server.Configurations.Entities
{
    public class DirectorSeedConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasData(
                      new Director
                      {
                          Id = 1,
                          Name = "Christopher Nolan",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      },
                      new Director
                      {
                          Id = 2,
                          Name = "John Carpenter",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          CreatedBy = "System",
                          UpdatedBy = "System"
                      }
                                );
        }
    }
}