using Microsoft.EntityFrameworkCore;
using ExchangeRateMicroservice.Domain.Models;

namespace ExchangeRateMicroservice.Infrastructure.Data
{
    public class RateDbContext : DbContext
    {
        public DbSet<Rate> Rates { get; set; }
        public RateDbContext(DbContextOptions<RateDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
