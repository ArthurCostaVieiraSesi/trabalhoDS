using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class CadastroMaterialPage : ContentPage
    {
        public CadastroMaterialPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarMateriaisPage();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(DescricaoEntry.Text) ||
                string.IsNullOrWhiteSpace(CustoEntry.Text))
            {
                ErrorFrame.IsVisible = true;
            }
            else
            {
            string nome = NomeEntry.Text;
            string descricao = DescricaoEntry.Text;
            string custo = CustoEntry.Text;

            ErrorFrame.IsVisible = false;
            Application.Current.MainPage = new GerenciarMateriaisPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }
    }
}
