using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroClientePage : ContentPage
    {
        ClienteControle clienteControle = new ClienteControle();
        public CadastroClientePage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarClientesPage();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(TelefoneEntry.Text) ||
                string.IsNullOrWhiteSpace(CpfEntry.Text) ||
                string.IsNullOrWhiteSpace(EmailEntry.Text))
            {
                ErrorFrame.IsVisible = true;
            }
            else
            {
                var c = new Cliente();
                c.nome = NomeEntry.Text;
                c.telefone = TelefoneEntry.Text;
                c.cpf = CpfEntry.Text;
                c.email = EmailEntry.Text;
                clienteControle.CriarOuAtualizar(c);

            ErrorFrame.IsVisible = false;
            Application.Current.MainPage = new GerenciarClientesPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }

    }
}
