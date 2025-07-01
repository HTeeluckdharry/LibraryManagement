using LibraryManagement.mvvm.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BorrowBook> BorrowBooks { get; set; }
        public DbSet<BookAuthorCrossReference> BookAuthorCrossReferences { get; set; }

        public string ConnectionString { get; }
        public LibraryDbContext() {
            ConnectionString = "Data Source=(local);Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthorCrossReference>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });

            modelBuilder.Entity<BookAuthorCrossReference>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthorCrossReference)
                .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<BookAuthorCrossReference>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthorCrossReference)
                .HasForeignKey(ba => ba.AuthorId);

            modelBuilder.Entity<BorrowBook>()
                .HasKey(bc => new { bc.BookId, bc.CustomerId, bc.BorrowDate });

            modelBuilder.Entity<BorrowBook>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BorrowBook)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BorrowBook>()
                .HasOne(bc => bc.Customer)
                .WithMany(c => c.BorrowBook)
                .HasForeignKey(bc => bc.CustomerId);

        }
    }
}