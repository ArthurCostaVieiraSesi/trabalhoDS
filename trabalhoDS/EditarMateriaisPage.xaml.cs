using Microsoft.Maui.Controls;
using Modelos;
using System.Collections.ObjectModel;

namespace trabalhoDS
{
    public partial class EditarMateriaisPage : ContentPage
    {

        Controles.MaterialControle materialControle = new Controles.MaterialControle();

        public EditarMateriaisPage()
        {
            InitializeComponent();

            ProductsListView.ItemsSource = materialControle.LerTodos();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
        var page = new CadastroMaterialPage();
        page.material = e.SelectedItem as Material;
        Application.Current.MainPage = page;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarMateriaisPage();
        }

    }

    
}
