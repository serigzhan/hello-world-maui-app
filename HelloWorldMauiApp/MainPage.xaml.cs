namespace HelloWorldMauiApp
{
    public partial class MainPage : ContentPage
    {
        public bool IsLoggedIn { get; set; } = false;

        public MainPage()
        {
            InitializeComponent();

            LogButton.IsEnabled = false;

            LogResultMessage.IsVisible = false;
            UserNameEntry.IsVisible = true;
        }

        public void OnLogButtonClicked(object sender, EventArgs args)
        {
            if (IsLoggedIn)
            {
                UserNameEntry.Text = null;
                UserNameEntry.IsVisible = true;

                LogResultMessage.IsVisible = false;

                LogButton.Text = "Log";
            }
            else
            {
                var username = UserNameEntry.Text.Trim();

                LogResultMessage.Text = $"Hello, {username}";
                LogResultMessage.IsVisible = true;

                UserNameEntry.IsVisible = false;

                LogButton.Text = "Retry";
            }

            IsLoggedIn = !IsLoggedIn;

        }

        public void OnUsernameEntryChanged(object sender, TextChangedEventArgs e)
        {
            LogButton.IsEnabled = !string.IsNullOrWhiteSpace(UserNameEntry.Text);
        }
    }
}
