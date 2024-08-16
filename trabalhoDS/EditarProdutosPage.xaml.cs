using Microsoft.Maui.Controls;
using Modelos;
using System.Collections.ObjectModel;

namespace trabalhoDS
{
    public partial class EditarProdutosPage : ContentPage
    {

        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();

        public EditarProdutosPage()
        {
            InitializeComponent();

            ProductsListView.ItemsSource = produtoControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
        var page = new CadastroProdutoPage();
        page.produto = e.SelectedItem as Produto;
        Application.Current.MainPage = page;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarProdutosPage();
        }

    }

    
}
