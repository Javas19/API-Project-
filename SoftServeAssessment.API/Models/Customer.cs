namespace SoftServeAssessment.API.Models
{
    public class Customer
    {
        public string CustomerId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public int Age { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }
        public bool IsDeleted { get; set; }

    }
}
