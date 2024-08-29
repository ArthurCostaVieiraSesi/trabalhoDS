using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalhoDS
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
        Controles.MaterialControle materialControle = new Controles.MaterialControle();
        public Fornecedor fornecedor { get; set; }
        public CadastroFornecedorPage()
        {
            InitializeComponent();
            pickerMaterial.ItemsSource = materialControle.LerTodos();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GerenciarFornecedoresPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (fornecedor != null)
            {
                DeleteButton.IsVisible = true;
                IdLabel.Text = fornecedor.Id.ToString();
                NomeEntry.Text = fornecedor.nome;
                CnpjCpfEntry.Text = fornecedor.cpf;
                CepEntry.Text = fornecedor.cep;
                TelefoneEntry.Text = fornecedor.telefone;
                pickerMaterial.SelectedItem = fornecedor.Material;
            }
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NomeEntry.Text) &&
                !string.IsNullOrWhiteSpace(CnpjCpfEntry.Text) &&
                !string.IsNullOrWhiteSpace(CepEntry.Text) &&
                !string.IsNullOrWhiteSpace(TelefoneEntry.Text))
            {
                ErrorFrame.IsVisible = true;

                var f = new Fornecedor();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    f.Id = int.Parse(IdLabel.Text);
                else

                    f.Id = 0;
                f.nome = NomeEntry.Text;
                f.cpf = CnpjCpfEntry.Text;
                f.cep = CepEntry.Text;
                f.telefone = TelefoneEntry.Text;
                f.Material = pickerMaterial.SelectedItem as Material;
                fornecedorControle.CriarOuAtualizar(f);

                ErrorFrame.IsVisible = false;
                Application.Current.MainPage = new EditarFornecedoresPage();
            }
        }

        private async void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (fornecedor == null || fornecedor.Id < 1)
                await DisplayAlert("Erro", "Nenhum fornecedor para excluir", "ok");
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse fornecedor?", "Excluir Fornecedor", "cancelar"))
            {
                fornecedorControle.Apagar(fornecedor.Id);
                Application.Current.MainPage = new EditarFornecedoresPage();
            }
        }

        private void OnErrorOkButtonClicked(object sender, EventArgs e)
        {
            ErrorFrame.IsVisible = false;
        }

    }
}
