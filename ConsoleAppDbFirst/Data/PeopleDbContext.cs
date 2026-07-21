using System;
using System.Collections.Generic;
using ConsoleAppDbFirst.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleAppDbFirst.Data;

public partial class PeopleDbContext : DbContext
{
    public PeopleDbContext()
    {
    }

    string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=PeopleDb;Trusted_Connection=True;TrustServerCertificate=True;";

    public PeopleDbContext(DbContextOptions<PeopleDbContext> options)
        : base(options)
    {
        connectionString = Environment.GetEnvironmentVariable("CONNECTION") ?? "default";
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
           .UseSqlServer(connectionString)
           .LogTo(Console.WriteLine,LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
