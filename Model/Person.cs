using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;
public class Person
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string FirstName { get; set; }

    [MaxLength(100)]
    public string LastName { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Range(0, 20)]
    public int ChildrenCount { get; set; }

    public DateTime DateOfBirth { get; set; }

    [NotMapped]
    public int Age 
    { get => DateTime.Now.Year - DateOfBirth.Year; 
        set {
            DateOfBirth = DateTime.Now.AddYears(-value);
        }
    }

    public Address? Address { get; set; }

    public ICollection<Contract> Contracts { get; set; } = new HashSet<Contract>(); // inicializace listu aby nespadl na null pri prochazeni pokud neobsahuje smlouvy
}
