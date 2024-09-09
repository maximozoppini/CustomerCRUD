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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
