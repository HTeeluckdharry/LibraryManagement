using LibraryManagement.Data;
using LibraryManagement.View;

namespace LibraryManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            try
            {
                if (!Directory.Exists("./images/customer"))
                {
                    Directory.CreateDirectory("./images/customer");
                }
                if (!Directory.Exists("./images/book"))
                {
                    Directory.CreateDirectory("./images/book");
                }
            }
            catch (Exception)
            {

            }
            
            LibraryDbContext dbContext = new LibraryDbContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            Datainit.InitialiseData(dbContext);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}