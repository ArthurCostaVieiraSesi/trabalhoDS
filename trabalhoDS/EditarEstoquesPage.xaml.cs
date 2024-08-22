using Microsoft.Maui.Controls;
using Modelos;
using System.Collections.ObjectModel;

namespace trabalhoDS
{
    public partial class EditarEstoquesPage : ContentPage
    {

        Controles.EstoqueControle estoqueControle = new Controles.EstoqueControle();

        public EditarEstoquesPage()
        {
            InitializeComponent();

            ProductsListView.ItemsSource = estoqueControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
        var page = new CadastroEstoquePage();
        page.estoque = e.SelectedItem as Estoque;
        Application.Current.MainPage = page;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarEstoquesPage();
        }

    }

    
}