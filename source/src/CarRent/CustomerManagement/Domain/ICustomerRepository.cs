namespace CarRent.CustomerManagement.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CarRent.Common.Domain;

    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
        IEnumerable<Customer> FindByName(string name);
    }
}
