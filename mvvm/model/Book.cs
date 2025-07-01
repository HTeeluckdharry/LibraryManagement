namespace LibraryManagement.mvvm.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required string Genre { get; set; }
        public string? ImageLink { get; set; }

        public ICollection<BookAuthorCrossReference> BookAuthorCrossReference { get; set; }
        public ICollection<BorrowBook> BorrowBook { get; set; }
    }
}
