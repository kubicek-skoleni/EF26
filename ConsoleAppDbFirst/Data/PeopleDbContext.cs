using System;
using System.Collections.Generic;
using ConsoleAppDbFirst.Model;
using Microsoft.EntityFrameworkCore;

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
