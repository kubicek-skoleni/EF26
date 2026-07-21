using Data;
using EF26;
using Microsoft.EntityFrameworkCore;
using Model;

var db = new PeopleDbContext();
int id = 6000;

var person = db.Persons
    .Include(x => x.Address)//.ThenInclude(x => ).ThenInclude
    .Include(x => x.Contracts)
    .Where(p => p.Id == id)
    .SingleOrDefault();

if (person != null)
{
    Console.WriteLine($"Osoba: {person.FirstName} {person.LastName}, Email: {person.Email}");
    Console.WriteLine($"Adresa: {person.Address?.Street}, {person.Address?.City}, {person.Address?.ZipCode}");
    foreach(var contract in person.Contracts)
    {
        Console.WriteLine($"Smlouva: {contract?.Name}, Plate Number: {contract?.PlateNumber}, Signed: {contract?.Signed}");
    }
}
else
{
    Console.WriteLine($"Person NOT found with Id = {id}");
}

