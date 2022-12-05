using SoftServeAssessment.API.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface ICustomer
    {
        public List<Customer> GetAllCustomers();
        public void AddUser(Customer customer);
        public void UpdateUserDetails(Customer customer);
        public Customer GetAllCustomers(int id);
        public void DeleteCustomer(int id);
    }
}
