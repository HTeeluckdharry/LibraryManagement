using LibraryManagement.mvvm.viewModel;

namespace LibraryManagement.mvvm.view
{
    public partial class Borrow : UserControl
    {
        private ReportViewModel reportViewModel;

        public Borrow()
        {
            InitializeComponent();
            reportViewModel = new ReportViewModel();
            reportViewModelBindingSource.DataSource = reportViewModel;
        }
    }
}
