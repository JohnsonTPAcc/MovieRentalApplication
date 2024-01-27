using MovieRentalApplication.Shared.Domain;
using Microsoft.AspNetCore.Http;
using MovieRentalApplication.Server.IRepository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalApplication.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        
        IGenericRepository<Director> Directors { get; }
        IGenericRepository<Rating> Ratings { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Movie> Movies { get; }
    }
}