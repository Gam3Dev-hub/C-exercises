using MVCBasicAssignment2.Models;

namespace MVCBasicAssignment2.Services
{
    public interface ICustomerService
    {
        public void AddCustomer(Customer customer);
        public Customer GetCustomerById(int id);

        public IEnumerable<Customer> GetAllCustomers();

        public void UpdateCustomer(Customer customer);

        public void DeleteCustomer(int id);
    }
}
