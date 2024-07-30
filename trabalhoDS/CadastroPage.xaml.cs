using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MenuPage();
        }
    }
}
