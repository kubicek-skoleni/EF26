using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppDbFirst.Model;

public partial class Address
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Street { get; set; } = null!;

    [StringLength(100)]
    public string City { get; set; } = null!;

    [MaxLength(100)]
    public string? Country { get; set; }

    [StringLength(20)]
    public string ZipCode { get; set; } = null!;

    [InverseProperty("Address")]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
