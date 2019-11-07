using CIS174_TestCoreApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CIS174_TestCoreApp
{
    public class PersonContext : DbContext
    {
        public PersonContext (DbContextOptions<PersonContext> options) : base (options)
        {

        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Accomplishment> Accomplishments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174person.database.windows.net,1433;Initial Catalog=CIS174.10;Persist Security Info=False;User ID=carl;Password=Xukw6774/;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    }
}
