using Microsoft.Maui.Controls;
using Modelos;
using System.Collections.ObjectModel;

namespace trabalhoDS
{
    public partial class EditarFornecedoresPage : ContentPage
    {

        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();

        public EditarFornecedoresPage()
        {
            InitializeComponent();

            ProductsListView.ItemsSource = fornecedorControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
        var page = new CadastroFornecedorPage();
        page.fornecedor = e.SelectedItem as Fornecedor;
        Application.Current.MainPage = page;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarFornecedoresPage();
        }

    }

    
}
