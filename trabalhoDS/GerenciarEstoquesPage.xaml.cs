using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class GerenciarEstoquesPage : ContentPage
    {
        public GerenciarEstoquesPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarVendasClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroEstoquePage();
        }

        private void OnVerVendasTotaisClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = true;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MenuPage();
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            // Esconder o Frame de erro ao clicar em OK
            ErrorFrame.IsVisible = false;
        }
    }
}

