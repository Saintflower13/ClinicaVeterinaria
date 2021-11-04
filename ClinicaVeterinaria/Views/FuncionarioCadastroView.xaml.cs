using ClinicaVeterinaria.Controllers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace ClinicaVeterinaria.Views
{
    public partial class FuncionarioCadastroView : Window
    {
        public FuncionarioCadastroController Controller { get; set; }

        public FuncionarioCadastroView()
        {
            InitializeComponent();
            Controller = new FuncionarioCadastroController();
            ConfigurarTela();
        }

        public FuncionarioCadastroView(object funcionarioEditar)
        {
            InitializeComponent();
            Controller = new FuncionarioCadastroController(funcionarioEditar);
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            this.DataContext = this;
            dtpDataContratacao.SelectedDate = System.DateTime.Now;
            pswSenha.Password = string.IsNullOrEmpty(Controller.Funcionario.Senha) ? "" : Controller.Funcionario.Senha;
        }

        private void tglOperadorAdmin_Checked(object sender, RoutedEventArgs e)
        {
            (sender as ToggleButton).Content = (sender as ToggleButton).IsChecked == true ? "Admin" : "Operador";
        }

        private void pswSenha_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            txtSenha.Tag = (sender as PasswordBox).Password;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (Controller.BtnSalvar())
                this.Close();
        }
    }
}
