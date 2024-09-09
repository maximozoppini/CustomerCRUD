using Microsoft.EntityFrameworkCore;
using SimpleCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Entities.DBContext
{
    public class CustomerAssestmentContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerAssestmentContext(DbContextOptions<CustomerAssestmentContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed 20 initial customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 4, FirstName = "Bob", LastName = "Williams", Email = "bob.williams@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 5, FirstName = "Charlie", LastName = "Brown", Email = "charlie.brown@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 6, FirstName = "David", LastName = "Miller", Email = "david.miller@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 7, FirstName = "Emily", LastName = "Davis", Email = "emily.davis@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 8, FirstName = "Frank", LastName = "Garcia", Email = "frank.garcia@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 9, FirstName = "Grace", LastName = "Martinez", Email = "grace.martinez@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 10, FirstName = "Henry", LastName = "Lopez", Email = "henry.lopez@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 11, FirstName = "Irene", LastName = "Gonzalez", Email = "irene.gonzalez@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 12, FirstName = "Jack", LastName = "Wilson", Email = "jack.wilson@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 13, FirstName = "Karen", LastName = "Anderson", Email = "karen.anderson@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 14, FirstName = "Liam", LastName = "Thomas", Email = "liam.thomas@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 15, FirstName = "Mia", LastName = "Taylor", Email = "mia.taylor@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 16, FirstName = "Nathan", LastName = "Moore", Email = "nathan.moore@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 17, FirstName = "Olivia", LastName = "Jackson", Email = "olivia.jackson@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 18, FirstName = "Paul", LastName = "Lee", Email = "paul.lee@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 19, FirstName = "Quincy", LastName = "Harris", Email = "quincy.harris@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow },
                new Customer { Id = 20, FirstName = "Rachel", LastName = "Clark", Email = "rachel.clark@example.com", Created = DateTime.UtcNow, Modify = DateTime.UtcNow }
            );
        }

    }
}
