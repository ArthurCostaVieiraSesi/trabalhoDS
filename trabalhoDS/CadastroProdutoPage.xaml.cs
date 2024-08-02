using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class CadastroProdutoPage : ContentPage
    {
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
            string nome = NomeEntry.Text;
            string estoque = EstoqueEntry.Text;
            string preco = PrecoEntry.Text;
            string custoProducao = CustoProducaoEntry.Text;
            string materiais = MateriaisEditor.Text;

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
