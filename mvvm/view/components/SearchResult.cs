using LibraryManagement.mvvm.model;

namespace LibraryManagement.mvvm.view.components
{
    public partial class SearchResult : UserControl
    {
        public SearchResult(Result result)
        {
            InitializeComponent();

            title.Text = result.Title;
            subtitle.Text = result.Subtitle;
            note.Text = result.Note;
            
            if (result.Image != null)
            {
                pictureBox.ImageLocation = result.Image;
            } else
            {
                pictureBox.Width = 0;
                title.Location = new Point(title.Location.X - 50, title.Location.Y);
                subtitle.Location = new Point(title.Location.X - 50, title.Location.Y);
            }
        }
    }
}
