using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Utils;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class FornecedorCadastroView : Window
    {
        public FornecedoresCadastroController Controller { get; set; }

        public FornecedorCadastroView()
        {
            InitializeComponent();
            Controller = new FornecedoresCadastroController();
            ConfigurarTela();
        }

        public FornecedorCadastroView(object fornecedorEditar)
        {
            InitializeComponent();
            Controller = new FornecedoresCadastroController(fornecedorEditar);
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            this.DataContext = this;
        }
        
        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (Controller.BtnSalvar())
                this.Close();
        }

        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            ValidarInput.NumericosApenas_PreviewTextInput(sender, e);
        }
    }
}
