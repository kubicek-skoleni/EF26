using Data;
using Model;

var person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    DateOfBirth = new DateTime(1990, 1, 1),
    Email = "test@test.com",
    ChildrenCount = 0,
    Address = new Address
    {
        Street = "1234563 Main Street Avenue Bld",
        City = "Anytown",
        ZipCode = "12345"
    },
};

var db = new PeopleDbContext();

db.Persons.Add(person);

try
{
    int changed = db.SaveChanges();

    Console.WriteLine($"Changes saved successfully. {changed} record(s) affected.");
}
catch(Exception ex)
{
    Console.WriteLine($"Error saving changes: {ex.Message}");
}