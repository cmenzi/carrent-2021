namespace CarRent.CustomerManagement.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CarRent.CustomerManagement.Domain;

    public class InMemoryCustomerRepository : ICustomerRepository
    {
        public void Add(Customer entity) => throw new NotImplementedException();
        public IEnumerable<Customer> FindByName(string name) => throw new NotImplementedException();
        public Customer GetById(Guid id) => throw new NotImplementedException();
        public void Remove(Customer entity) => throw new NotImplementedException();
        public void Remove(Guid id) => throw new NotImplementedException();
    }
}
