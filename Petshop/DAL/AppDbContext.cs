using Microsoft.EntityFrameworkCore;

namespace Petshop.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){}
    }
}
