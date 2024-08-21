using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroProdutoPage : ContentPage
    {
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        Controles.MaterialControle materialControle = new Controles.MaterialControle();
        public Produto produto { get; set; }
        public CadastroProdutoPage()
        {
            InitializeComponent();
            pickerMaterial.ItemsSource = materialControle.LerTodos();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarProdutosPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (produto != null)
            {
                DeleteButton.IsVisible = true;
                NomeEntry.Text = produto.nome;
                EstoqueEntry.Text = produto.estoque;
                PrecoEntry.Text = produto.preco;
                CustoProducaoEntry.Text = produto.custo;
                pickerMaterial.SelectedItem = produto.Material;
            }
        }

        

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(EstoqueEntry.Text) ||
                string.IsNullOrWhiteSpace(PrecoEntry.Text) ||
                string.IsNullOrWhiteSpace(CustoProducaoEntry.Text))
            {
                ErrorFrame.IsVisible = true;
            }
                var p = new Produto();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                produto.Id      = int.Parse(IdLabel.Text);
            else
            {
                p.Id = 0;
                p.nome = NomeEntry.Text;
                p.estoque = EstoqueEntry.Text;
                p.preco = PrecoEntry.Text;
                p.custo = CustoProducaoEntry.Text;
                p.Material = pickerMaterial.SelectedItem as Material;
                produtoControle.CriarOuAtualizar(p);

            ErrorFrame.IsVisible = false;
            Application.Current.MainPage = new EditarProdutosPage();
            }
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (produto == null || produto.Id < 1)
            await DisplayAlert("Erro", "Nenhum produto para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse produto?", "Excluir Produto","cancelar"))
            {
                produtoControle.Apagar(produto.Id);
                Application.Current.MainPage = new EditarProdutosPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }
    }
}
