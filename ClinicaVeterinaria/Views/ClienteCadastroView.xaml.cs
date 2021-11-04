using ClinicaVeterinaria.Controllers;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class ClienteCadastroView : Window
    {
        public ClienteCadastroController Controller { get; set; }

        public ClienteCadastroView()
        {
            InitializeComponent();
            Controller = new ClienteCadastroController();
            ConfigurarTela();
        }

        public ClienteCadastroView(object clienteEditar)
        {
            InitializeComponent();
            Controller = new ClienteCadastroController(clienteEditar);
            ConfigurarTela();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (Controller.BtnSalvar())
                this.Close();
        }

        private void ConfigurarTela()
        {
            this.DataContext = this;
        }

        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Utils.ValidarInput.NumericosApenas_PreviewTextInput(sender, e);
        }
    }
}
