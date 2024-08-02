using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(CnpjCpfEntry.Text) ||
                string.IsNullOrWhiteSpace(SenhaEntry.Text) ||
                string.IsNullOrWhiteSpace(CepEntry.Text))
            {
                ErrorFrame.IsVisible = true;
            }
            else
            {
                string nome = NomeEntry.Text;
                string cnpjcpf = CnpjCpfEntry.Text;
                string senha = SenhaEntry.Text;
                string cep = CepEntry.Text;

                ErrorFrame.IsVisible = false;
                Application.Current.MainPage = new MenuPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }
        
    }
}

