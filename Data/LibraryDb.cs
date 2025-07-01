using LibraryManagement.mvvm.model;
using LibraryManagement.mvvm.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    internal class LibraryDb
    {
        LibraryDbContext context;
        
        public LibraryDb()
        {
            context = new LibraryDbContext();
        }
        // Results to be able to search up the database
        public List<Result> CustomerSearch(string query)
        {
            List<Customer> customers = context.Customers
                .FromSqlInterpolated($@"
                    SELECT * FROM Customers 
                    WHERE LOWER(FirstName) LIKE LOWER({'%' + query + '%'})
                        OR LOWER(LastName) LIKE LOWER({'%' + query + '%'})")
                .ToList();

            return customers.Select(customer => new Result
                {
                    Title = customer.LastName,
                    Subtitle = customer.FirstName,
                    Image = customer.ImageLink,

                }).ToList();
        }
    }
}
