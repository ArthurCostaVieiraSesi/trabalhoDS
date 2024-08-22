using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroMaterialPage : ContentPage
    {
        Controles.MaterialControle materialControle = new Controles.MaterialControle();
        public Material material { get; set; }
        public CadastroMaterialPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarMateriaisPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (material != null)
            {
                DeleteButton.IsVisible = true;
                IdLabel.Text = material.Id.ToString();
                NomeEntry.Text = material.nome;
                DescricaoEntry.Text = material.descricao;
                CustoEntry.Text = material.custo;
            }
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                string.IsNullOrWhiteSpace(DescricaoEntry.Text) ||
                string.IsNullOrWhiteSpace(CustoEntry.Text))
            {
                ErrorFrame.IsVisible = true;
            
                var m = new Material();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                m.Id      = int.Parse(IdLabel.Text);
            else
            
                m.Id = 0;
                m.nome = NomeEntry.Text;
                m.descricao = DescricaoEntry.Text;
                m.custo = CustoEntry.Text;
                materialControle.CriarOuAtualizar(m);

            ErrorFrame.IsVisible = false;
            Application.Current.MainPage = new EditarMateriaisPage();
            }
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (material == null || material.Id < 1)
            await DisplayAlert("Erro", "Nenhum material para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse material?", "Excluir Material","cancelar"))
            {
                materialControle.Apagar(material.Id);
                Application.Current.MainPage = new EditarMateriaisPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }
    }
}
