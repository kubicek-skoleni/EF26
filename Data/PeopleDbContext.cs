using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model;

namespace Data;
public class PeopleDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; } 

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Contract> Contracts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PeopleDb;Trusted_Connection=True;");
             //.LogTo(Console.WriteLine,
             //      LogLevel.Information);
    }
}
