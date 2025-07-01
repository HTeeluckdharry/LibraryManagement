using LibraryManagement.mvvm.model;

namespace LibraryManagement.mvvm.view.components
{
    public partial class SearchBar : UserControl
    {
        private int MaxItems;
        private int MinSearchLength;
        private Func<string, List<Result>> Search;
        private Action<Result>? OnClick;

        public SearchBar(Func<string, List<Result>> search, Action<Result>? onClick, int maxItems = 5, int minSearchLength = 2)
        {
            InitializeComponent();

            MaxItems = maxItems;
            MinSearchLength = minSearchLength;
            Search = search;
            OnClick = onClick;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length > MinSearchLength)
            {
                List<Result> results = Search(searchBox.Text);
                flowLayoutPanel.Height = results.Count * 50;

                flowLayoutPanel.Controls.Clear();
                for (int i = 0; i < Math.Min(MaxItems, results.Count); i++)
                {
                    SearchResult searchResult = new SearchResult(results[i]);
                    flowLayoutPanel.Controls.Add(searchResult);
                }
            }
            else
            {
                flowLayoutPanel.Controls.Clear();
            }
        }
    }
}
