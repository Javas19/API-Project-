using Microsoft.EntityFrameworkCore;

namespace SoftServeAssessment.API.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //I seed customers here
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                 CustomerId = "de87cc26-4e31-4b1c-8255-a2c212ccce78",
                FirstName = "John",
                LastName = "Doe",
                UserName = "John Doe",
                EmailAddress = "johndoe@gmailcom",
                DateOfBirth = new DateOnly(1979, 10, 03),
                Age = 25,
                DateCreated = new DateTime(2022, 10, 17, 5, 50, 6),
                DateEdited = new DateTime(2022, 10, 17, 6, 35, 20),
                IsDeleted = false,
            });
            }
    }
}
 