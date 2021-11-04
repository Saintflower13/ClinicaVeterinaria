using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Utils;
using System;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class VendaCadastrarView : Window
    {
        public VendaCadastroController Controller { get; set; } = new VendaCadastroController();

        public VendaCadastrarView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void txbQtd_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            ValidarInput.DecimalApenas_PreviewTextInput(sender, e);
        }

        private void LancarProduto()
        {
            int idProd;
            decimal qtdProd;

            try
            {
                if (!decimal.TryParse(txbQtd.Text, out qtdProd)) throw new Exception("Quantidade do produto é inválida.");
                if (!int.TryParse(txbProduto.Text, out idProd)) throw new Exception("Id do produto é inválido.");

                Produto produto = Produto.BuscarPorId(idProd);
                if (produto == null) throw new Exception("Produto não encontrado.");

                lvProdutos.Items.Add(new VendaProduto(produto, qtdProd));
                LimparCamposProdutoLancamento();
                AtualizarTotalVenda();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void LancarPagamento()
        {
            decimal valorPgto;

            try
            {
                if (cmbPgtos.SelectedIndex < 1) throw new Exception("Forma de pagamento é obrigatória.");
                if (!decimal.TryParse(txtValorPago.Text, out valorPgto)) throw new Exception("Valor de pagamento é inválido.");

                FormasPagamento pgto = cmbPgtos.Items[cmbPgtos.SelectedIndex] as FormasPagamento;

                lvPagamentos.Items.Add(new VendaPagamento(pgto, valorPgto));
                LimparCamposPagamentoLancamento();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void AtualizarTotalVenda()
        {
            decimal total = 0;

            for (int i = 0; i < lvProdutos.Items.Count; i++)
                total += (lvProdutos.Items[i] as VendaProduto).ValorTotal;

            txtTotalVenda.Text = $"R$ {total}";
        }

        private void ListViewItem_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o produto da lista?", "Atenção", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                lvProdutos.Items.RemoveAt(lvProdutos.SelectedIndex);
                AtualizarTotalVenda();
            }
        }

        private void btnPesquisarProduto_Click(object sender, RoutedEventArgs e)
        {
            ProdutosListarView produtosListarView = new ProdutosListarView();
            produtosListarView.ShowDialog();
        }

        private void btnListarServicos_Click(object sender, RoutedEventArgs e)
        {
            ServicosListarView servicosListarView = new ServicosListarView();
            servicosListarView.ShowDialog();
        }

        private void txbProduto_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                LancarProduto();
        }

        private void btnLancarProduto_Click(object sender, RoutedEventArgs e)
        {
            LancarProduto();
        }

        private void btnLancarPgto_Click(object sender, RoutedEventArgs e)
        {
            LancarPagamento();
        }

        private void ListViewPagamentos_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o pagamento informado?", "Atenção", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                lvPagamentos.Items.RemoveAt(lvPagamentos.SelectedIndex);
        }

        private void btnFinalizarVenda_Click(object sender, RoutedEventArgs e)
        {
            try {
                CarregarVendaDados();
                Controller.ValidarDados();
                decimal troco = Controller.Troco;
                Controller.SalvarVenda();

                string msgSucesso = troco <= 0 ? "Venda efetuada com sucesso." : $"Venda efetuada com sucesso.\n\n\n* VALOR DE TROCO: R$ {troco}";

                MessageBox.Show(msgSucesso, "Sucesso");
                ResetarVenda();
            } catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção");
            }
        }

        private void CarregarVendaDados()
        {
            CarregarProdutosLancados();
            CarregarPagamentosLancados();
            Controller.Venda.Observacoes = txbObservacoes.Text.Trim();
            Controller.VendedorIndex = cmbVendedor.SelectedIndex;
        }

        private void CarregarProdutosLancados()
        {
            Controller.Produtos.Clear();

            for (int i = 0; i < lvProdutos.Items.Count; i++)
                Controller.Produtos.Add(lvProdutos.Items[i] as VendaProduto);
        }

        private void CarregarPagamentosLancados()
        {
            Controller.Pagamentos.Clear();

            for (int i = 0; i < lvPagamentos.Items.Count; i++)
                Controller.Pagamentos.Add(lvPagamentos.Items[i] as VendaPagamento);
        }

        private void ResetarVenda()
        {
            cmbVendedor.SelectedIndex = 0;
            cmbPgtos.SelectedIndex = 0;
            lvProdutos.Items.Clear();
            lvPagamentos.Items.Clear();
            txbObservacoes.Text = "";
            txtTotalVenda.Text = "R$ 0";
            LimparCamposProdutoLancamento();
            LimparCamposPagamentoLancamento();
        }

        private void LimparCamposProdutoLancamento()
        {
            txbProduto.Text = "";
            txbQtd.Text = "";
        }

        private void LimparCamposPagamentoLancamento()
        {
            cmbPgtos.SelectedIndex = 0;
            txtValorPago.Text = "";
        }

        private void btnResetarVenda_Click(object sender, RoutedEventArgs e)
        {
            Controller.ResetarVenda();
            ResetarVenda();
        }
    }
}
