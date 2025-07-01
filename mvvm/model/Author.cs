namespace LibraryManagement.mvvm.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly? DOB { get; set; }

        public ICollection<BookAuthorCrossReference> BookAuthorCrossReference { get; set; }
    }
}

