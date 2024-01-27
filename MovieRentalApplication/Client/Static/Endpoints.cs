using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalApplication.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string DirectorsEndpoint = $"{Prefix}/directors";
        public static readonly string CategoryEndpoint = $"{Prefix}/categories";
        public static readonly string RatingsEndpoint = $"{Prefix}/ratings";
        public static readonly string MoviesEndpoint = $"{Prefix}/movies";
        public static readonly string CustomerEndpoint = $"{Prefix}/customers";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
    }
}
