
using LibraryManagement.Data;
using LibraryManagement.mvvm.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement.mvvm.viewModel
{
    public class AddRemoveViewModel: INotifyPropertyChanged
    {
        
        private string? authorLastName;
        private string? authorFirstName;
        private DateTime authorDOB;
        public string? AuthorLastName
        {
            get
            {
                return authorLastName;
            }
            set
            {
                if (value != authorLastName)
                {
                    authorLastName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string? AuthorFirstName
        {
            get
            {
                return authorFirstName;
            }
            set
            {
                if (value != authorFirstName)
                {
                    authorFirstName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public DateTime AuthorDOB
        {
            get
            {
                return authorDOB;
            }
            set
            {
                if (value != authorDOB)
                {
                    authorDOB = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string? customerLastName;
        private string? customerFirstName;
        private string? customerPhoneNumber;
        private string? customerAddress;
        private string? customerEmail;
        private string? customerImage;

        public string? CustomerLastName
        {
            get { return customerLastName; }
            set
            {
                if (value != customerLastName)
                {
                    customerLastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string? CustomerFirstName
        {
            get { return customerFirstName; }
            set
            {
                if (value != customerFirstName)
                {
                    customerFirstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string? CustomerPhoneNumber
        {
            get { return customerPhoneNumber; }
            set
            {
                if (value != customerPhoneNumber)
                {
                    customerPhoneNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string? CustomerAddress
        {
            get { return customerAddress; }
            set
            {
                if (value != customerAddress)
                {
                    customerAddress = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string? CustomerEmail
        {
            get { return customerEmail; }
            set
            {
                if (value != customerEmail)
                {
                    customerEmail = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string? CustomerImage
        {
            get { return customerImage; }
            set
            {
                if (value != customerImage)
                {
                    customerImage = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string? title;
        private string? genre;
        private int year;
        private string? image;

        public string? Title
        {
            get { return title; }
            set
            {
                if (value != title)
                {
                    title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string? Genre
        {
            get { return genre; }
            set
            {
                if (value != genre)
                {
                    genre = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value != year)
                {
                    year = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string? Image
        {
            get { return image; }
            set
            {
                if (value != image)
                {
                    image = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public AddRemoveViewModel()
        {
            Year = DateTime.Now.Year;
            AuthorDOB = DateTime.Now;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        internal void OnBookInsert()
        {
            string newPath = "./images/book/" + Path.GetFileName(Image);
            File.Copy(Image!, newPath, true);
            Image = newPath;

            using (var context = new LibraryDbContext())
            {
                Book book = new Book
                {
                    Title = Title!,
                    Genre = Genre!,
                    Year = Year,
                    ImageLink = Image
                };

                context.Books.Add(book);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    string message = e.InnerException?.Message ?? e.Message;
                    MessageBox.Show(message, "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Title = null;
                    Genre = null;
                    Year = DateTime.Now.Year;
                    Image = null;

                    Console.WriteLine("INSERT: ", Title, Genre, Year, Image);
                }
            }
        }

        internal void OnBookDelete()
        {
            File.Delete(Image!);

            Console.WriteLine("DELETE: ", Title, Genre, Year, Image);
        }

        internal void onCustomerInsert()
        {
            string newPath = "./images/customer/" + Path.GetFileName(CustomerImage);
            File.Copy(CustomerImage!, newPath, true);
            CustomerImage = newPath;

            using (var context = new LibraryDbContext()) 
            {
                Customer customer = new Customer
                {
                    FirstName = CustomerFirstName!,
                    LastName = CustomerLastName!,
                    Phone = CustomerPhoneNumber!,
                    Address = CustomerAddress!,
                    Email = CustomerEmail!,
                    ImageLink = CustomerImage!
                };

                context.Customers.Add(customer);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    string message = e.InnerException?.Message ?? e.Message;
                    MessageBox.Show(message, "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CustomerFirstName = null;
                    CustomerLastName = null;
                    CustomerPhoneNumber = null;
                    CustomerAddress = null;
                    CustomerEmail = null;
                    CustomerImage = null;
                }
            }
        }

        internal void onCustomerDelete()
        {
            throw new NotImplementedException();
        }

        internal void onAuthorInsert()
        {
            using (var context = new LibraryDbContext())
            {
                Author author = new Author
                {
                    FirstName = AuthorFirstName!,
                    LastName = AuthorLastName,
                    DOB = DateOnly.FromDateTime(AuthorDOB)
                };
                context.Authors.Add(author);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    string message;
                    if (e.InnerException != null)
                    {
                        message = e.InnerException.Message;
                    }
                    else
                    {
                        message = e.Message;
                    }

                    MessageBox.Show(message, "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    AuthorFirstName = null;
                    AuthorLastName = null;
                    AuthorDOB = DateTime.Now;
                }
            }
        }

        internal void onAuthorDelete()
        {
            throw new NotImplementedException();
        }
    }
}
