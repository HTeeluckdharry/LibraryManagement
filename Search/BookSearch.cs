using LibraryManagement.Data;
using LibraryManagement.mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Search
{
    public class BookWithAuthor
    {
        public string BookTitle { get; set; }
        public string AuthorFullName { get; set; }
        public Book Book { get; set; }
    }

    public static class BookSearch
    {
        // Binary search by Book Title
        public static Book? BinarySearchByTitle(List<Book> books, string title)
        {
            books = books.OrderBy(b => b.Title).ToList();
            int low = 0;
            int high = books.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparison = string.Compare(books[mid].Title, title, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return books[mid];
                else if (comparison < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return null;
        }

        // Binary search by Genre
        public static Book? BinarySearchByGenre(List<Book> books, string genre)
        {
            books = books.OrderBy(b => b.Genre).ToList();
            int low = 0;
            int high = books.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparison = string.Compare(books[mid].Genre, genre, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return books[mid];
                else if (comparison < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return null;
        }

        // Retrieve a list of BookWithAuthor from the database
        public static List<BookWithAuthor> GetBooksWithAuthors(LibraryDbContext dbContext)
        {
            var data = from book in dbContext.Books
                       join crossRef in dbContext.BookAuthorCrossReferences on book.BookId equals crossRef.BookId
                       join author in dbContext.Authors on crossRef.AuthorId equals author.AuthorId
                       select new BookWithAuthor
                       {
                           BookTitle = book.Title,
                           AuthorFullName = author.FirstName + " " + author.LastName,
                           Book = book
                       };

            return data.ToList();
        }

        // Binary search by Author name (returns all books by the author)
        public static List<Book> BinarySearchByAuthor(List<BookWithAuthor> bookAuthors, string authorName)
        {
            bookAuthors = bookAuthors.OrderBy(ba => ba.AuthorFullName).ToList();
            int low = 0;
            int high = bookAuthors.Count - 1;
            var results = new List<Book>();

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparison = string.Compare(bookAuthors[mid].AuthorFullName, authorName, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    // Collect all matching entries
                    int left = mid;
                    while (left >= 0 && string.Equals(bookAuthors[left].AuthorFullName, authorName, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(bookAuthors[left].Book);
                        left--;
                    }

                    int right = mid + 1;
                    while (right < bookAuthors.Count && string.Equals(bookAuthors[right].AuthorFullName, authorName, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(bookAuthors[right].Book);
                        right++;
                    }

                    break;
                }
                else if (comparison < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return results;
        }
    }
}
