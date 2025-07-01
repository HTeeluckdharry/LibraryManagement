namespace LibraryManagement.mvvm.Models
{
    public class BookAuthorCrossReference
    {
        public Guid BookId { get; set; }
        public required Book Book { get; set; }

        public Guid AuthorId { get; set; }
        public required Author Author { get; set; }
    }
}
