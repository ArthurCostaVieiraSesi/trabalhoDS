using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class CadastroClientePage : ContentPage
    {
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
            string nome = NomeEntry.Text;
            string telefone = TelefoneEntry.Text;
            string cpf = CpfEntry.Text;
            string email = EmailEntry.Text;

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
