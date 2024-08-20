using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroProdutoPage : ContentPage
    {
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        public Produto produto { get; set; }
        public CadastroProdutoPage()
        {
            InitializeComponent();
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
            }
        }

        

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(EstoqueEntry.Text) ||
                string.IsNullOrWhiteSpace(PrecoEntry.Text) ||
                string.IsNullOrWhiteSpace(CustoProducaoEntry.Text) ||
                string.IsNullOrWhiteSpace(MateriaisEditor.Text))
            {
                ErrorFrame.IsVisible = true;
            }
            else
            {
                var p = new Produto();
                p.nome = NomeEntry.Text;
                p.estoque = EstoqueEntry.Text;
                p.preco = PrecoEntry.Text;
                p.custo = CustoProducaoEntry.Text;
                //p.material = MateriaisEditor.Text;
                produtoControle.CriarOuAtualizar(p);

            ErrorFrame.IsVisible = false;
            Application.Current.MainPage = new EditarProdutosPage();
            }
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (produto == null)
            await DisplayAlert("Erro", "Nenhum produto para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?", "Excluir Cliente","cancelar"))
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
