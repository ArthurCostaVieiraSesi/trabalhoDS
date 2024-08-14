using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        FornecedorControle fornecedorControle = new FornecedorControle();
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
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(CnpjCpfEntry.Text) ||
                string.IsNullOrWhiteSpace(CepEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text) ||
                string.IsNullOrWhiteSpace(MateriaisEditor.Text))
            {
                ErrorFrame.IsVisible = true;
            }
            else
            {
                var f = new Fornecedor();
                f.nome = NomeEntry.Text;
                f.cnpjCpf = CnpjCpfEntry.Text;
                f.cep = CepEntry.Text;
                f.telefone = TelefoneEntry.Text;
                f.materiais = MateriaisEditor.Text;
                fornecedorControle.CriarOuAtualizar(f);

            ErrorFrame.IsVisible = false;
            Application.Current.MainPage = new GerenciarFornecedoresPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }

    }
}
