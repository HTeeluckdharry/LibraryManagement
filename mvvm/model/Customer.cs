using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LibraryManagement.mvvm.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? ImageLink { get; set; }

        public ICollection<BorrowBook> BorrowBook { get; set; }

    }
}
