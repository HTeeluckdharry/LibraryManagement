namespace LibraryManagement.mvvm.Models
{
    public class BorrowBook
    {
        public Guid BookId { get; set; }
        public required Book Book { get; set; }
        
        public Guid CustomerId { get; set; }
        public required Customer Customer { get; set; }

        public bool Available { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; }
    }
}
