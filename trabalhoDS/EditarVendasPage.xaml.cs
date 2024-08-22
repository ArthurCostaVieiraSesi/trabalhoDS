using Microsoft.Maui.Controls;
using Modelos;
using System.Collections.ObjectModel;

namespace trabalhoDS
{
    public partial class EditarVendasPage : ContentPage
    {

        Controles.VendaControle vendaControle = new Controles.VendaControle();

        public EditarVendasPage()
        {
            InitializeComponent();

            ProductsListView.ItemsSource = vendaControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
        var page = new CadastroVendaPage();
        page.venda = e.SelectedItem as Venda;
        Application.Current.MainPage = page;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarVendasPage();
        }

    }

    
}