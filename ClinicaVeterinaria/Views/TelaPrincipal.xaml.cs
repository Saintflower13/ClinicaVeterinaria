using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.Views;
using System.Windows;

namespace ClinicaVeterinaria
{
    public partial class TelaPrincipal : Window
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            ConfigurarNivelAcesso();
        }

        private void ConfigurarNivelAcesso()
        {
            mniCadastros.Visibility = Sessao.UsuariologadoEhAdmin() ? Visibility.Visible : Visibility.Hidden;
            mniCompras.Visibility = Sessao.UsuariologadoEhAdmin() ? Visibility.Visible : Visibility.Hidden;
        }

        private void mniListarClientes_Click(object sender, RoutedEventArgs e)
        {
            ClientesListar clientesListarView = new ClientesListar();
            clientesListarView.ShowDialog();
        }

        private void mniCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteCadastroView clienteCadastroView = new ClienteCadastroView();
            clienteCadastroView.ShowDialog();
        }

        private void mniFuncionarioCadastrar_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioCadastroView funcionarioCadastroView = new FuncionarioCadastroView();
            funcionarioCadastroView.ShowDialog();
        }

        private void mniFuncionariosListar_Click(object sender, RoutedEventArgs e)
        {
           FuncionariosListarView funcionarioListarView = new FuncionariosListarView();
           funcionarioListarView.ShowDialog();
        }

        private void mniFuncionariosFuncoes_Click(object sender, RoutedEventArgs e)
        {
            FuncionariosFuncoesCadastroView funcionariosFuncoesCadastroView = new FuncionariosFuncoesCadastroView();
            funcionariosFuncoesCadastroView.ShowDialog();
        }

        private void mniEspeciesAnimaisCadastro_Click(object sender, RoutedEventArgs e)
        {
            AnimaisEspeciesCadastroView animaisEspeciesCadastroView = new AnimaisEspeciesCadastroView();
            animaisEspeciesCadastroView.ShowDialog();
        }

        private void mniFormasPagamentoCadastro_Click(object sender, RoutedEventArgs e)
        {
            FormasPagamentoCadastroView formasPagamentoCadastroView = new FormasPagamentoCadastroView();
            formasPagamentoCadastroView.ShowDialog();
        }

        private void mniFornecedorCadastrar_Click(object sender, RoutedEventArgs e)
        {
            FornecedorCadastroView fornecedorCadastroView = new FornecedorCadastroView();
            fornecedorCadastroView.ShowDialog();
        }

        private void mniFornecedoresListar_Click(object sender, RoutedEventArgs e)
        {
            FornecedoresListarView fornecedoresListarView = new FornecedoresListarView();
            fornecedoresListarView.ShowDialog();
        }

        private void mniProdutoCadastrar_Click(object sender, RoutedEventArgs e)
        {
            ProdutoCadastrarView produtoCadastrarView = new ProdutoCadastrarView();
            produtoCadastrarView.ShowDialog();
        }

        private void mniProdutosListar_Click(object sender, RoutedEventArgs e)
        {
            ProdutosListarView produtosListarView = new ProdutosListarView();
            produtosListarView.ShowDialog();
        }

        private void mniVendaCadastrar_Click(object sender, RoutedEventArgs e)
        {
            VendaCadastrarView vendaCadastrarView = new VendaCadastrarView();
            vendaCadastrarView.ShowDialog();
        }

        private void mniVendasListar_Click(object sender, RoutedEventArgs e)
        {
            VendasListarView vendasListarView = new VendasListarView();
            vendasListarView.ShowDialog();
        }

        private void mniCompraCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CompraCadastrarView compraCadastrarView = new CompraCadastrarView();
            compraCadastrarView.ShowDialog();
        }

        private void mniComprasListar_Click(object sender, RoutedEventArgs e)
        {
            ComprasListarView comprasListarView = new ComprasListarView();
            comprasListarView.ShowDialog();
        }

        private void mniServicoCadastrar_Click(object sender, RoutedEventArgs e)
        {
            ServicoCadastroView servicoCadastroView = new ServicoCadastroView();
            servicoCadastroView.ShowDialog();
        }

        private void mniUnidadeMedidaCadastro_Click(object sender, RoutedEventArgs e)
        {
            UnidadeMedidaCadastroView unidadeMedidaCadastroView = new UnidadeMedidaCadastroView();
            unidadeMedidaCadastroView.ShowDialog();
        }

        private void mniCategoriasProdutosCadastro_Click(object sender, RoutedEventArgs e)
        {
            CategoriasProdutosCadastroView categoriasProdutosCadastroView = new CategoriasProdutosCadastroView();
            categoriasProdutosCadastroView.ShowDialog();
        }

        private void mniServicosListar_Click(object sender, RoutedEventArgs e)
        {
            ServicosListarView servicosListarView = new ServicosListarView();
            servicosListarView.ShowDialog();
        }

        private void mniCategoriasServicosCadastro_Click(object sender, RoutedEventArgs e)
        {
            CategoriasProdutosCadastroView categoriasProdutosCadastroView = new CategoriasProdutosCadastroView(ProdutoTipo.Servico);
            categoriasProdutosCadastroView.ShowDialog();
        }

        private void mniAnimalCadastro_Click(object sender, RoutedEventArgs e)
        {
            AnimalCadastroView animalCadastroView = new AnimalCadastroView();
            animalCadastroView.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
