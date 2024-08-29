using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroClientePage : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public Cliente cliente { get; set; }
        public CadastroClientePage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarClientesPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                DeleteButton.IsVisible = true;
                IdLabel.Text = cliente.Id.ToString();
                NomeEntry.Text = cliente.nome;
                CpfEntry.Text = cliente.cpf;
                EmailEntry.Text = cliente.email;
                TelefoneEntry.Text = cliente.telefone;
            }
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NomeEntry.Text) &&
                !string.IsNullOrWhiteSpace(TelefoneEntry.Text) &&
                !string.IsNullOrWhiteSpace(CpfEntry.Text) &&
                !string.IsNullOrWhiteSpace(EmailEntry.Text))
            {
                ErrorFrame.IsVisible = true;

                var c = new Cliente();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    c.Id = int.Parse(IdLabel.Text);
                else

                    c.Id = 0;
                c.nome = NomeEntry.Text;
                c.telefone = TelefoneEntry.Text;
                c.cpf = CpfEntry.Text;
                c.email = EmailEntry.Text;
                clienteControle.CriarOuAtualizar(c);

                ErrorFrame.IsVisible = false;
                Application.Current.MainPage = new EditarClientesPage();
            }
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (cliente == null || cliente.Id < 1)
                await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse cliente?", "Excluir Cliente", "cancelar"))
            {
                clienteControle.Apagar(cliente.Id);
                Application.Current.MainPage = new EditarClientesPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }

    }
}
