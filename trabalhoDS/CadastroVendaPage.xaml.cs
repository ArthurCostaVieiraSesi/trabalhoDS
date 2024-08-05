using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class CadastroVendaPage : ContentPage
    {
        public CadastroVendaPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarVendasPage();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Implementar a ação do botão salvar
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(ClienteEntry.Text) ||
                string.IsNullOrWhiteSpace(DataPedidoEntry.Text) ||
                string.IsNullOrWhiteSpace(TotalEntry.Text) ||
                string.IsNullOrWhiteSpace(DescontoEntry.Text) ||
                string.IsNullOrWhiteSpace(DataEntregaEntry.Text) ||
                string.IsNullOrWhiteSpace(ListaEstoqueEntry.Text))
            {
                // Exibir o Frame de erro
                ErrorFrame.IsVisible = true;
            }
            else
            {
                // Aqui você pode adicionar a lógica para salvar os dados da venda
                string cliente = ClienteEntry.Text;
                string dataPedido = DataPedidoEntry.Text;
                string total = TotalEntry.Text;
                string desconto = DescontoEntry.Text;
                string dataEntrega = DataEntregaEntry.Text;
                string listaEstoque = ListaEstoqueEntry.Text;

                // Lógica para salvar os dados da venda

                // Esconder o Frame de erro caso esteja visível
                ErrorFrame.IsVisible = false;
                Application.Current.MainPage = new GerenciarVendasPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            // Esconder o Frame de erro ao clicar em OK
            ErrorFrame.IsVisible = false;
        }
    }
}
