using Microsoft.Maui.Controls;

namespace trabalhoDS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

		void Cadastro(object sender, EventArgs e)
        {
			Application.Current.MainPage = new CadastroPage();
        }

		void Login(object sender, EventArgs e)
        {
			Application.Current.MainPage = new LoginPage();
        }

        void Menu(object sender, EventArgs e)
        {
			Application.Current.MainPage = new MenuPage();
        }
    }
}
