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
            // Implementar a navegação ou ação para editar produtos
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MenuPage();
        }
    }
}