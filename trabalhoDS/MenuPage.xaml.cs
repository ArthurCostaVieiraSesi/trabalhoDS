using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void OnGerenciarFornecedoresClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarFornecedoresPage();
        }

        private void OnGerenciarMateriaisClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarMateriaisPage();
        }

        private void OnGerenciarClientesClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarClientesPage();
        }

        private void OnGerenciarProdutosClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarProdutosPage();
        }

        private void OnEstoquesClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarEstoquesPage();
        }

        private void OnVendasClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarVendasPage();
        }
    }
}
