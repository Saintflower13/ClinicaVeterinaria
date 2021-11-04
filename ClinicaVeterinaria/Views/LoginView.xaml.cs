using ClinicaVeterinaria.Controllers;
using System;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class LoginView : Window
    {
        public LoginViewController Controller { get; set; } = new LoginViewController();
        public LoginView()
        {
            InitializeComponent();
            txbUsuario.Focus();
        }

        private void Logar()
        {
            try
            {
                Controller.Logar(txbUsuario.Text, txbSenha.Password);
                ResetarLogin();
                IniciarPrograma();
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "Atenção");
                txbSenha.Password = "";
                txbSenha.Focus();
            }
        }

        private void ResetarLogin()
        {
            txbSenha.Password = "";
            txbUsuario.Text = "";
            txbUsuario.Focus();
        }

        private void IniciarPrograma()
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Visibility = Visibility.Hidden;
            telaPrincipal.ShowDialog();
            this.Visibility = Visibility.Visible;

        }

        private void txbSenha_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                Logar();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            Logar();
        }
    }
}
