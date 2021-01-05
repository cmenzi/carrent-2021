using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
