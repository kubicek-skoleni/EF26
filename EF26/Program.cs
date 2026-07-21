using Data;
using Model;

var db = new PeopleDbContext();

var first = db.Persons.FirstOrDefault();