using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
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
