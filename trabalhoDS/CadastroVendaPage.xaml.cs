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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (venda != null)
            {
                DeleteButton.IsVisible = true;
                IdLabel.Text = venda.Id.ToString();
                DescontoEntry.Text = venda.desconto;
                DataPedidoEntry.Text = venda.datap;
                DataEntregaEntry.Text = venda.datae;
                TotalEntry.Text = venda.total;
                pickerCliente.SelectedItem = venda.Cliente;
                pickerProduto.SelectedItem = venda.Produto;
            }
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
            
                var v = new Venda();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                v.Id      = int.Parse(IdLabel.Text);
            else
            
                // Aqui você pode adicionar a lógica para salvar os dados da venda
                v.Id = 0;
                v.datap = DataPedidoEntry.Text;
                v.total = TotalEntry.Text;
                v.desconto = DescontoEntry.Text;
                v.datae = DataEntregaEntry.Text;
                v.Cliente = pickerCliente.SelectedItem as Cliente;
                v.Produto = pickerProduto.SelectedItem as Produto;
                vendaControle.CriarOuAtualizar(v);

                // Esconder o Frame de erro caso esteja visível
                ErrorFrame.IsVisible = false;
                Application.Current.MainPage = new EditarVendasPage();
            }
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (venda == null || venda.Id < 1)
            await DisplayAlert("Erro", "Nenhuma venda para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir essa venda?", "Excluir Venda","cancelar"))
            {
                produtoControle.Apagar(venda.Id);
                Application.Current.MainPage = new EditarVendasPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            // Esconder o Frame de erro ao clicar em OK
            ErrorFrame.IsVisible = false;
        }
    }
}
