using BlazorApp.Server.Interfaces;
using System.Data.Entity;

namespace BlazorApp.Server.Services
{
    public class UserManager : ICustomer
    {
        readonly DatabaseContext _dbContext = new();
        public UserManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all customer details
        public List<Customer> GetAllCustomers()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new customer record
        public void AddUser(Customer customer)
        {
            try
            {
                _dbContext.Users.Add(customer);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar customer
        public void UpdateUserDetails(Customer customer)
        {
            try
            {
                _dbContext.Entry(customer).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular customer
        public Customer GetAllCustomers(int id)
        {
            try
            {
                Customer? customer = _dbContext.Customers.Find(id);
                if (customer != null)
                {
                    return customer;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular customer
        public void DeleteCustomer(int id)
        {
            try
            {
                Customer? customer = _dbContext.Customers.Find(id);
                if (customer != null)
                {
                    _dbContext.Users.Remove(customer);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}