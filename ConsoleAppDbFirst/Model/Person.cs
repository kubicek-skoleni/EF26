using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppDbFirst.Model;

[Index("AddressId", Name = "IX_Persons_AddressId")]
public partial class Person
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string FirstName { get; set; } = null!;

    [StringLength(100)]
    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int ChildrenCount { get; set; }

    public DateTime DateOfBirth { get; set; }

    public int? AddressId { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("People")]
    public virtual Address? Address { get; set; }

    [InverseProperty("Person")]
    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
