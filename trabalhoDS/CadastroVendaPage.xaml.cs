using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroVendaPage : ContentPage
    {
        Controles.VendaControle vendaControle = new Controles.VendaControle();
        Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public Venda venda { get; set; }
        public CadastroVendaPage()
        {
            InitializeComponent();
            pickerCliente.ItemsSource = clienteControle.LerTodos();
            pickerProduto.ItemsSource = produtoControle.LerTodos();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarVendasPage();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Implementar a ação do botão salvar
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(DataPedidoEntry.Text) ||
                string.IsNullOrWhiteSpace(TotalEntry.Text) ||
                string.IsNullOrWhiteSpace(DescontoEntry.Text) ||
                string.IsNullOrWhiteSpace(DataEntregaEntry.Text))
            {
                // Exibir o Frame de erro
                ErrorFrame.IsVisible = true;
            }
            else
            {
                // Aqui você pode adicionar a lógica para salvar os dados da venda
                string cliente = ClienteEntry.Text;
                v.dataPedido = DataPedidoEntry.Text;
                v.total = TotalEntry.Text;
                v.desconto = DescontoEntry.Text;
                v.dataEntrega = DataEntregaEntry.Text;
                string listaEstoque = ListaEstoqueEntry.Text;

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
