using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class CadastroEstoquePage : ContentPage
    {
        public CadastroEstoquePage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarEstoquesPage();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Implementar a ação do botão salvar
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(ProdutoEntry.Text) ||
                string.IsNullOrWhiteSpace(ValorEntry.Text) ||
                string.IsNullOrWhiteSpace(DescontoEntry.Text) ||
                string.IsNullOrWhiteSpace(ObsEntry.Text))
            {
                // Exibir o Frame de erro
                ErrorFrame.IsVisible = true;
            }
            else
            {
                // Aqui você pode adicionar a lógica para salvar os dados do estoque
                string produto = ProdutoEntry.Text;
                string valor = ValorEntry.Text;
                string desconto = DescontoEntry.Text;
                string obs = ObsEntry.Text;

                // Lógica para salvar os dados do estoque

                // Esconder o Frame de erro caso esteja visível
                ErrorFrame.IsVisible = false;
                Application.Current.MainPage = new GerenciarEstoquesPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            // Esconder o Frame de erro ao clicar em OK
            ErrorFrame.IsVisible = false;
        }
    }
}
