using LibraryManagement.Data;
using LibraryManagement.Search;
using System;
using System.Linq;

// SearchEX.RunExamples();
namespace LibraryManagement.Search
{
    public static class SearchEX
    {
        public static void RunExamples()
        {
            using var dbContext = new LibraryDbContext();

            // Example 1: Binary Search by Title
            var allBooks = dbContext.Books.ToList();
            var bookByTitle = BookSearch.BinarySearchByTitle(allBooks, "1984");

            Console.WriteLine("=== Search by Title ===");
            if (bookByTitle != null)
                Console.WriteLine($"Found: {bookByTitle.Title} ({bookByTitle.Year})");
            else
                Console.WriteLine("Book not found by title.");

            // Example 2: Binary Search by Genre
            var bookByGenre = BookSearch.BinarySearchByGenre(allBooks, "Dystopian");

            Console.WriteLine("\n=== Search by Genre ===");
            if (bookByGenre != null)
                Console.WriteLine($"Found: {bookByGenre.Title} - Genre: {bookByGenre.Genre}");
            else
                Console.WriteLine("Book not found by genre.");

            // Example 3: Binary Search by Author
            var bookWithAuthors = BookSearch.GetBooksWithAuthors(dbContext);
            var booksByAuthor = BookSearch.BinarySearchByAuthor(bookWithAuthors, "George Orwell");

            Console.WriteLine("\n=== Search by Author ===");
            if (booksByAuthor.Any())
            {
                foreach (var book in booksByAuthor)
                {
                    Console.WriteLine($"Found: {book.Title} by George Orwell");
                }
            }
            else
            {
                Console.WriteLine("No books found for this author.");
            }
        }
    }
}