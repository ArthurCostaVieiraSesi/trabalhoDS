using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class GerenciarVendasPage : ContentPage
    {
        public GerenciarVendasPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarVendasClicked(object sender, EventArgs e)
        {
            // Implementar a navegação ou ação para cadastrar vendas
        }

        private void OnVerVendasTotaisClicked(object sender, EventArgs e)
        {
            // Implementar a navegação ou ação para ver vendas totais
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MenuPage();
        }
    }
}
