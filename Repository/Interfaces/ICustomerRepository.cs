using SimpleCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Repositories.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
    }
}
