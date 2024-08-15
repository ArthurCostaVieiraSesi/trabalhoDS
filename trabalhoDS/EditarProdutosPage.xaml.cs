using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace trabalhoDS
{
    public partial class EditarProdutosPage : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }

        public EditarProdutosPage()
        {
            InitializeComponent();

            // Exemplo de produtos
            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Exemplo de produtos 1" },
                new Product { Name = "Exemplo de produtos 2" },
                new Product { Name = "Exemplo de produtos 3" },
                new Product { Name = "Exemplo de produtos 4" },
                new Product { Name = "Exemplo de produtos 5" },
            };

            ProductsListView.ItemsSource = Products;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarProdutosPage();
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            var product = (Product)((ImageButton)sender).CommandParameter;
            // Implementar a edição do produto
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var product = (Product)((ImageButton)sender).CommandParameter;
            Products.Remove(product);
            // Implementar a remoção do produto
        }
    }

    public class Product
    {
        public string Name { get; set; }
    }
}
