// See https://aka.ms/new-console-template for more information
using ConsoleAppDbFirst.Model;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

// Scaffold-DbContext "Server=(localdb)\\mssqllocaldb;Database=PeopleDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model -ContextDir Data -Context PeopleDbContext

var db = new ConsoleAppDbFirst.Data.PeopleDbContext();


var p = db.Persons
   .AsNoTracking() //read only
   .Where(x => x.Id > 500)
   .Select(x => new { x.FirstName, x.LastName })
   .FirstOrDefault();

if (p != null)
{
    Console.WriteLine(p.FirstName);
}