using ClinicaVeterinaria.Controllers;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class ServicoDetalhesView : Window
    {
        public ServicoDetalheController Controller { get; set; }

        public ServicoDetalhesView(object servicoDetalhe)
        {
            InitializeComponent();
            this.DataContext = this;

            Controller = new ServicoDetalheController(servicoDetalhe);
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            gridMarcarConcluido.Visibility = Controller.ServicoDetalhado.ServicoDetalhado.Status ? Visibility.Hidden : Visibility.Visible;
            txtDataFim.Text = Controller.ServicoDetalhado.ServicoDetalhado.DataFim == null ? "-" : $"{Controller.ServicoDetalhado.ServicoDetalhado._dataFim }";
            txtDataInicio.Text = Controller.ServicoDetalhado.ServicoDetalhado.DataInicio == null ? "-" : $"{Controller.ServicoDetalhado.ServicoDetalhado._dataInicio }";
            txtDataRegistro.Text = $"{Controller.ServicoDetalhado.ServicoDetalhado.DataCriacao}";

            txtClienteEAnimal.Text = $"{Controller.ServicoDetalhado.ClienteNome.ToUpper()} - {Controller.ServicoDetalhado.AnimalNome}";
            txtObservacoes.Text = string.IsNullOrWhiteSpace(Controller.ServicoDetalhado.ServicoDetalhado.Observacao) ? 
                                    "Sem Observações" : Controller.ServicoDetalhado.ServicoDetalhado.Observacao;
        }

        private void btnConcluirServico_Click(object sender, RoutedEventArgs e)
        {
            if (Controller.ConcluirServico())
                ConfigurarTela();
        }
    }
}
