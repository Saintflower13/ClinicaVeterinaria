using ClinicaVeterinaria.Controllers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClinicaVeterinaria.Views
{
    public partial class FornecedoresListarView : Window
    {
        public FornecedoresListarController Controller { get; set; } = new FornecedoresListarController();

        public FornecedoresListarView()
        {
            InitializeComponent();
            this.DataContext = this;
            Controller.CarregarFornecedoresAtivos(); ;
        }

        private void btnCadastrarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            FornecedorCadastroView fornecedorCadastroView = new FornecedorCadastroView();
            fornecedorCadastroView.ShowDialog();
            Controller.CarregarFornecedoresAtivos();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var fornecedorEditar = (sender as ListViewItem).Content;

            if (fornecedorEditar == null) return;

            FornecedorCadastroView fornecedorEdicaoView = new FornecedorCadastroView(fornecedorEditar);
            fornecedorEdicaoView.ShowDialog();
            Controller.CarregarFornecedoresAtivos();
        }

        private void btnPesquisarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            PesquisarFornecedor();
        }

        private void txbFornecedorPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                PesquisarFornecedor();
        }

        private void PesquisarFornecedor()
        {
            Controller.CarregarFornecedoresAtivos(txbFornecedorPesquisar.Text.Trim());
            txbFornecedorPesquisar.Text = "";
        }
    }
}
