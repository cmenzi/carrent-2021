namespace CarRent.CustomerManagement.Infrastructure
{
    using CarRent.CustomerManagement.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _data = new List<Customer>();

        public void Add(Customer customer)
        {
            _data.Add(customer);
        }

        public Customer FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
