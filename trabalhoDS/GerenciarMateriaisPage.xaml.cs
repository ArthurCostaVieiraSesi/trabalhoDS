using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class GerenciarMateriaisPage : ContentPage
    {
        public GerenciarMateriaisPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarProdutosClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroMaterialPage();
        }

        private void OnEditarProdutosClicked(object sender, EventArgs e)
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