using Microsoft.EntityFrameworkCore;
using MovieRentalApplication.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Drawing;

namespace MovieRentalApplication.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                 new Category
                 {
                     Id = 1,
                     Name = "SciFi",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Category
                 {
                     Id = 2,
                     Name = "Horror",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
                           );
        }
    }
}
