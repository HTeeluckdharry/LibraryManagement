using LibraryManagement.mvvm.viewModel;

namespace LibraryManagement.View
{
    public partial class AddRemove : UserControl
    {
        private Stack<Panel> prevPanels;
        private AddRemoveViewModel addRemoveViewModel;

        public AddRemove()
        {
            InitializeComponent();
            prevPanels = new();

            addRemoveViewModel = new AddRemoveViewModel();
            addRemoveViewModelBindingSource.DataSource = addRemoveViewModel;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            prevPanels.Pop().Visible = false;
            if (prevPanels.Count == 0)
            {
                backButton.Visible = false;
            }
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            customerPanel.Visible = true;
            prevPanels.Push(customerPanel);
            backButton.Visible = true;
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            bookPanel.Visible = true;
            prevPanels.Push(bookPanel);
            backButton.Visible = true;
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            authorPanel.Visible = true;
            prevPanels.Push(authorPanel);
            backButton.Visible = true;
        }

        private void ImagePath_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox textBox = (TextBox)sender;
                textBox.Text = openFileDialog.FileName;

                switch (textBox.Name)
                {
                    case "customerImagePath":
                        customerPicture.ImageLocation = openFileDialog.FileName;
                        break;
                    case "bookImagePath":
                        bookPicture.ImageLocation = openFileDialog.FileName;
                        break;
                    default:
                        break;
                }
            }
        }

        private void bookInsertButton_Click(object sender, EventArgs e)
        {
            addRemoveViewModel.OnBookInsert();
        }

        private void bookDeleteButton_Click(object sender, EventArgs e)
        {
            addRemoveViewModel.OnBookDelete();
        }

        private void customerDeleteButton_Click(object sender, EventArgs e)
        {
            addRemoveViewModel.onCustomerDelete();
        }

        private void customerInsertButton_Click(object sender, EventArgs e)
        {
            addRemoveViewModel.onCustomerInsert();
        }

        private void authorInsert_Click(object sender, EventArgs e)
        {
            addRemoveViewModel.onAuthorInsert();
        }

        private void authorDelete_Click(object sender, EventArgs e)
        {
            addRemoveViewModel.onAuthorDelete();
        }

        private void customerImagePath_TextChanged(object sender, EventArgs e)
        {
            if (customerImagePath.Text == null)
            {
                customerPicture.Image = null;
            }
        }
    }
}
