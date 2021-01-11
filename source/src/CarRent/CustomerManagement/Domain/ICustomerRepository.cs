namespace CarRent.CustomerManagement.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICustomerRepository
    {
        Customer FindById(int id);

        IEnumerable<Customer> FindByName(string name);

        void Add(Customer customer);

        void Remove(Customer customer);

        void Remove(int id);
    }
}
