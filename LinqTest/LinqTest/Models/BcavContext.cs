using Microsoft.EntityFrameworkCore;

namespace LinqTest.Models
{
    public class BcaVContext : DbContext
    {
        public DbSet<UserList> UserLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BcaV;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
