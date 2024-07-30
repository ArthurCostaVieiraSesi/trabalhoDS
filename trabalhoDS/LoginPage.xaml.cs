using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MenuPage();
        }
    }
}
