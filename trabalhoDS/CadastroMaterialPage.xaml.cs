using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroMaterialPage : ContentPage
    {
        MaterialControle materialControle = new MaterialControle();
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
                var m = new Material();
                m.nome = NomeEntry.Text;
                m.descricao = DescricaoEntry.Text;
                m.custo = CustoEntry.Text;
                materialControle.CriarOuAtualizar(m);

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
