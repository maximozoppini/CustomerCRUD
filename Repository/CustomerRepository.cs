using SimpleCRUD.Entities;
using SimpleCRUD.Entities.DBContext;
using SimpleCRUD.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Repositories
{
    public class CustomerRepository : Repository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(CustomerAssestmentContext context)
            : base(context) { }


    }
}
