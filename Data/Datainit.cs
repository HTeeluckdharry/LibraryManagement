using LibraryManagement.mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagement.Data
{
    public static class Datainit
    {
        public static void InitialiseData(LibraryDbContext dbContext)
        {
            // Only seed if the database is empty, Dummy Data
            if (dbContext.Books.Any() || dbContext.Authors.Any() || dbContext.Customers.Any())
                return;
            // Authors
            var author1 = new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "George",
                LastName = "Orwell"
            };
            var author2 = new Author
            {
                AuthorId = Guid.NewGuid(),
                FirstName = "Jane",
                LastName = "Austen"
            };

            // Books
            var book1 = new Book
            {
                BookId = Guid.NewGuid(),
                Title = "1984",
                Year = 1949,
                Genre = "Dystopian",
                ImageLink = "Resources\\Images\\1984.jpg"
            };
            var book2 = new Book
            {
                BookId = Guid.NewGuid(),
                Title = "Pride and Prejudice",
                Year = 1813,
                Genre = "Romance",
                ImageLink = "Resources\\Images\\PrideAndPrejudice.jpg"
            };

            // Customers
            var customer1 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                FirstName = "Alicia",
                LastName = "Blanche",
                Phone = "51234567",
                Address = "123 Street, Hawkins",
                Email = "alicia@gmail.com"
            };
            var customer2 = new Customer
            {
                CustomerId = Guid.NewGuid(),
                FirstName = "El",
                LastName = "Jane",
                Phone = "59876543",
                Address = "456  Street, Springfield",
                Email = "El@gmail.com"
            };

            // Book-Author relationships
            var ba1 = new BookAuthorCrossReference
            {
                BookId = book1.BookId,
                Book = book1,
                AuthorId = author1.AuthorId,
                Author = author1
            };
            var ba2 = new BookAuthorCrossReference
            {
                BookId = book2.BookId,
                Book = book2,
                AuthorId = author2.AuthorId,
                Author = author2
            };
            dbContext.Authors.AddRange(author1, author2);
            dbContext.Books.AddRange(book1, book2);
            dbContext.Customers.AddRange(customer1, customer2);
            dbContext.BookAuthorCrossReferences.AddRange(ba1, ba2);

            dbContext.SaveChanges();
        }
     }
}

