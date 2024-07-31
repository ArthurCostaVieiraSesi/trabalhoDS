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
            // Implementar a ação do botão salvar
            // Exemplo: Obter os valores dos campos e salvar o cliente
            string nome = NomeEntry.Text;
            string telefone = TelefoneEntry.Text;
            string cpf = CpfEntry.Text;
            string email = EmailEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados do cliente
        }
    }
}
