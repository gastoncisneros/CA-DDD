using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearArchitecture.Domain.Customers
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetById(Guid id);
        Task Add(Customer customer);
    }
}
