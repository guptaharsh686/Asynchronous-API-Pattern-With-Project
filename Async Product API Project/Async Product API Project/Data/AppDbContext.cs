using Microsoft.EntityFrameworkCore;
using Async_Product_API_Project.Models;

namespace Async_Product_API_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ListingRequest> ListingRequests => Set<ListingRequest>();
    }
}
