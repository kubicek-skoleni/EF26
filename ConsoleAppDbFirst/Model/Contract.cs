using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppDbFirst.Model;

[Index("PersonId", Name = "IX_Contracts_PersonId")]
public partial class Contract
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PlateNumber { get; set; } = null!;

    public DateTime Signed { get; set; }

    public int CarBrand { get; set; }

    public string HexColor { get; set; } = null!;

    public int? PersonId { get; set; }

    [ForeignKey("PersonId")]
    [InverseProperty("Contracts")]
    public virtual Person? Person { get; set; }
}
