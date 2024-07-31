using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarFornecedoresPage();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Implementar a ação do botão salvar
            // Exemplo: Obter os valores dos campos e salvar o fornecedor
            string nome = NomeEntry.Text;
            string cnpjCpf = CnpjCpfEntry.Text;
            string cep = CepEntry.Text;
            string telefone = TelefoneEntry.Text;
            string materiais = MateriaisEditor.Text;

            // Aqui você pode adicionar a lógica para salvar os dados do fornecedor
        }
    }
}
