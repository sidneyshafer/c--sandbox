using System;
using System.Collections.Generic;
using EntityWithDbs.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityWithDbs.Data;

public partial class EntityPracticeContext : DbContext
{
    public EntityPracticeContext()
    {
    }

    public EntityPracticeContext(DbContextOptions<EntityPracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EntityPractice;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
