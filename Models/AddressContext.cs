using Microsoft.EntityFrameworkCore;

namespace CourierAPI.Models
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions<AddressContext> options) : base(options) {}

        public DbSet<Address> Addresses { get; set; }
    }
}
