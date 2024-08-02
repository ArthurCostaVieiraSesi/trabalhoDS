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
            if (string.IsNullOrWhiteSpace(CnpjCpfEntry.Text) ||
                string.IsNullOrWhiteSpace(SenhaEntry.Text))
            {
                ErrorFrame.IsVisible = true;
            }
            else
            {
            string cnpjcpf = CnpjCpfEntry.Text;
            string senha = SenhaEntry.Text;

            ErrorFrame.IsVisible = false;
            Application.Current.MainPage = new MenuPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }
    }
}
