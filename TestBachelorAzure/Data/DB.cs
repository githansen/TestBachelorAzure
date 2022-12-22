using Microsoft.EntityFrameworkCore;

namespace TestBachelorAzure.Data
{
    public class DB : DbContext 
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {
            Database.EnsureCreated();

        }
        public virtual DbSet<Person> personer { get; set;}

    }
}
