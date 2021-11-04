using ClinicaVeterinaria.Controllers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClinicaVeterinaria.Views
{
    public partial class ProdutosListarView : Window
    {
        public ProdutosListarController Controller { get; set; } = new ProdutosListarController();

        public ProdutosListarView()
        {
            InitializeComponent();
            this.DataContext = this;
            Controller.CarregarProdutosAtivos();
        }

        private void btnCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            ProdutoCadastrarView produtoCadastrarView = new ProdutoCadastrarView();
            produtoCadastrarView.ShowDialog();
            Controller.CarregarProdutosAtivos();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var produtoEditar = (sender as ListViewItem).Content;

            if (produtoEditar == null) return;

            ProdutoCadastrarView produtoEdicaoView = new ProdutoCadastrarView(produtoEditar);
            produtoEdicaoView.ShowDialog();
            Controller.CarregarProdutosAtivos();
        }

        private void txbProdutoPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                PesquisarProduto();
        }

        private void btnPesquisarProduto_Click(object sender, RoutedEventArgs e)
        {
            PesquisarProduto();
        }

        private void PesquisarProduto()
        {
            Controller.CarregarProdutosAtivos(txbProdutoPesquisar.Text.Trim());
            txbProdutoPesquisar.Text = "";
        }
    }
}
