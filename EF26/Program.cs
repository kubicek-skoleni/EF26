using Data;
using EF26;
using Model;

var db = new PeopleDbContext();

var count_persons = db.Persons.Count();

Console.WriteLine($"v databazi je {count_persons} lidi");

