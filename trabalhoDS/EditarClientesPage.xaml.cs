using Microsoft.Maui.Controls;
using Modelos;
using System.Collections.ObjectModel;

namespace trabalhoDS
{
    public partial class EditarClientesPage : ContentPage
    {

        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public EditarClientesPage()
        {
            InitializeComponent();

            ProductsListView.ItemsSource = clienteControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
        var page = new CadastroClientePage();
        page.cliente = e.SelectedItem as Cliente;
        Application.Current.MainPage = page;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarClientesPage();
        }

    }

    
}