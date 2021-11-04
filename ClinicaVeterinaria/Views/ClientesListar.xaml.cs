using ClinicaVeterinaria.Controllers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClinicaVeterinaria.Views
{
    public partial class ClientesListar : Window
    {
        public ClientesListarController Controller { get; set; } = new ClientesListarController();

        public ClientesListar()
        {
            InitializeComponent();
            this.DataContext = this;
            Controller.CarregarClientesAtivos();
        }

        private void Cliente_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var clienteEditar = (sender as ListViewItem).Content;

            if (clienteEditar == null) return;

            ClienteExpandidoView clienteExpandidoView = new ClienteExpandidoView(clienteEditar);
            clienteExpandidoView.ShowDialog();
            Controller.CarregarClientesAtivos();
        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteCadastroView clienteCadastroView = new ClienteCadastroView();
            clienteCadastroView.ShowDialog();
            Controller.CarregarClientesAtivos();
        }

        private void txbClientePesquisar_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                PesquisarCliente();
        }

        private void btnPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {
            PesquisarCliente();
        }

        private void PesquisarCliente()
        {
            Controller.CarregarClientesAtivos(txbClientePesquisar.Text.Trim());
            txbClientePesquisar.Text = "";
        }
    }
}
