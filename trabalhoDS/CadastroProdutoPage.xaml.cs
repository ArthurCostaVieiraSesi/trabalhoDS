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
            // Implementar a ação do botão salvar
            // Exemplo: Obter os valores dos campos e salvar o produto
            string nome = NomeEntry.Text;
            string estoque = EstoqueEntry.Text;
            string preco = PrecoEntry.Text;
            string custoProducao = CustoProducaoEntry.Text;
            string materiais = MateriaisEditor.Text;

            // Aqui você pode adicionar a lógica para salvar os dados do produto
        }
    }
}
