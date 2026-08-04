using MVCBasicAssignment2.Data;
using MVCBasicAssignment2.Models;

namespace MVCBasicAssignment2.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDBContext _dbContext;
        public CustomerService(AppDBContext dbContext) 
        {
            _dbContext = dbContext; 
        }

        public void AddCustomer(Customer customer) 
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
        }
    }
}
