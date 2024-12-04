namespace ShellApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToDetailPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DetailPage));
        }
    }

}
