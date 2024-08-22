using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroEstoquePage : ContentPage
    {
        Controles.EstoqueControle estoqueControle = new Controles.EstoqueControle();
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        public Estoque estoque { get; set; }
        public CadastroEstoquePage()
        {
            InitializeComponent();
            pickerProduto.ItemsSource = produtoControle.LerTodos();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarEstoquesPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (estoque != null)
            {
                DeleteButton.IsVisible = true;
                IdLabel.Text = estoque.Id.ToString();
                ValorEntry.Text = estoque.valor;
                ObsEntry.Text = estoque.obs;
                QuantidadeEntry.Text = estoque.quantidade;
                pickerProduto.SelectedItem = estoque.Produto;
            }
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Implementar a ação do botão salvar
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(ValorEntry.Text) ||
                string.IsNullOrWhiteSpace(QuantidadeEntry.Text) ||
                string.IsNullOrWhiteSpace(ObsEntry.Text))
            {
                // Exibir o Frame de erro
                ErrorFrame.IsVisible = true;
            
                var es = new Estoque();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                es.Id      = int.Parse(IdLabel.Text);
            else
            
                // Aqui você pode adicionar a lógica para salvar os dados do estoque
                es.Id = 0;
                es.valor = ValorEntry.Text;
                es.quantidade = QuantidadeEntry.Text;
                es.obs = ObsEntry.Text;
                es.Produto = pickerProduto.SelectedItem as Produto;
                estoqueControle.CriarOuAtualizar(es);

                // Lógica para salvar os dados do estoque

                // Esconder o Frame de erro caso esteja visível
                ErrorFrame.IsVisible = false;
                Application.Current.MainPage = new EditarEstoquesPage();
            }
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (estoque == null || estoque.Id < 1)
            await DisplayAlert("Erro", "Nenhum estoque para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse estoque?", "Excluir Estoque","cancelar"))
            {
                produtoControle.Apagar(estoque.Id);
                Application.Current.MainPage = new EditarEstoquesPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            // Esconder o Frame de erro ao clicar em OK
            ErrorFrame.IsVisible = false;
        }
    }
}
