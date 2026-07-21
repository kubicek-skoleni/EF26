// See https://aka.ms/new-console-template for more information
using ConsoleAppDbFirst.Model;

Console.WriteLine("Hello, World!");

// Scaffold-DbContext "Server=(localdb)\\mssqllocaldb;Database=PeopleDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model -ContextDir Data -Context PeopleDbContext

var db = new ConsoleAppDbFirst.Data.PeopleDbContext();
var p = db.Persons.FirstOrDefault();

if (p != null)
{
    p.Email = "xx";
}