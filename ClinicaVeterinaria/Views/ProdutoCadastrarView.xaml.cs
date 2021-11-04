using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Utils;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace ClinicaVeterinaria.Views
{
    public partial class ProdutoCadastrarView : Window
    {
        public ProdutoCadastroController Controller { get; set; }

        public ProdutoCadastrarView()
        {
            InitializeComponent();
            Controller = new ProdutoCadastroController();
            ConfigurarTela();
        }

        public ProdutoCadastrarView(object produtoEditar)
        {
            InitializeComponent();
            Controller = new ProdutoCadastroController(produtoEditar);
            ConfigurarTela();
        }

        public void ConfigurarTela()
        {
            this.DataContext = this;
            tglAtivoInativo.IsChecked = !Controller.Produto.Status;
            tglAtivoInativo.IsChecked = Controller.Produto.Status;
            tglTipo.IsChecked = !Controller.Produto.Tipo;
            tglTipo.IsChecked = Controller.Produto.Tipo;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (Controller.BtnSalvar())
                this.Close();
        }

        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            ValidarInput.DecimalApenas_PreviewTextInput(sender, e);
        }

        private void tglAtivoInativo_Checked(object sender, RoutedEventArgs e)
        {
            (sender as ToggleButton).Content = (sender as ToggleButton).IsChecked == true ? "Ativo" : "Inativo";
        }

        private void tglTipo_Checked(object sender, RoutedEventArgs e)
        {
            tglTipo.Content = tglTipo.IsChecked == true ? "Produto" : "Serviço";
        }
    }
}
