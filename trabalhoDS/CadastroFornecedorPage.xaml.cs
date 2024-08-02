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
            
            string nome = NomeEntry.Text;
            string cnpjCpf = CnpjCpfEntry.Text;
            string cep = CepEntry.Text;
            string telefone = TelefoneEntry.Text;
            string materiais = MateriaisEditor.Text;

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
