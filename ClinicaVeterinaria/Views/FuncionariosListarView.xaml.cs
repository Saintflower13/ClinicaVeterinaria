using ClinicaVeterinaria.Controllers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClinicaVeterinaria.Views
{
    public partial class FuncionariosListarView : Window
    {
        public FuncionariosListarController Controller { get; set; } = new FuncionariosListarController();

        public FuncionariosListarView()
        {
            InitializeComponent();
            this.DataContext = this;
            Controller.CarregarFuncionariosAtivos();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var funcionarioEditar = (sender as ListViewItem).Content;

            if (funcionarioEditar == null) return;

            FuncionarioCadastroView funcionarioEdicaoView = new FuncionarioCadastroView(funcionarioEditar); 
            funcionarioEdicaoView.ShowDialog();
            Controller.CarregarFuncionariosAtivos();
        }

        private void btnCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioCadastroView funcionarioCadastrarView = new FuncionarioCadastroView();
            funcionarioCadastrarView.ShowDialog();
            Controller.CarregarFuncionariosAtivos();
        }

        private void txbNomePesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                PesquisarFuncionario();
        }

        private void btnPesquisarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            PesquisarFuncionario();
        }

        private void PesquisarFuncionario()
        {
            Controller.CarregarFuncionariosAtivos(txbNomePesquisar.Text.Trim());
        }
    }
}
