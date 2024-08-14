using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroProdutoPage : ContentPage
    {
        ProdutoControle produtoControle = new ProdutoControle();
        public CadastroProdutoPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarProdutosPage();
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
                p.material = MateriaisEditor.Text;
                produtoControle.CriarOuAtualizar(p);

            ErrorFrame.IsVisible = false;
            Application.Current.MainPage = new GerenciarProdutosPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }
    }
}
