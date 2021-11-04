using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClinicaVeterinaria.Views
{
    public partial class ServicosListarView : Window
    {
        public ServicosListarController Controller { get; set; } = new ServicosListarController();

        public ServicosListarView()
        {
            InitializeComponent();
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            this.DataContext = this;
            dpkDataInicio.SelectedDate = null;
            dpkDataFim.SelectedDate = null;

            cmbClientes.ItemsSource = Controller.ClientesCadastrados;
            cmbResponsavel.ItemsSource = Controller.FuncionariosCadastrados;
            cmbAnimal.ItemsSource = Controller.AnimaisCadastrados;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            object servicoDetalhe = (sender as ListViewItem).Content;

            if (servicoDetalhe == null) return;

            ServicoDetalhesView servicoDetalhesView = new ServicoDetalhesView(servicoDetalhe);
            servicoDetalhesView.ShowDialog();
            Controller.BuscarServicos();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            Servico servico = new Servico();
            servico.AnimalId = Controller.AnimaisCadastrados[cmbAnimal.SelectedIndex].Id;
            servico.DataInicio = dpkDataInicio.SelectedDate != null ? dpkDataInicio.SelectedDate.Value : null;
            servico.DataFim = dpkDataFim.SelectedDate != null ? dpkDataFim.SelectedDate.Value : null;
            servico.ClienteId = Controller.ClientesCadastrados[cmbClientes.SelectedIndex].Id;
            servico.FuncionarioId = Controller.FuncionariosCadastrados[cmbResponsavel.SelectedIndex].Id;

            Controller.BuscarServicos(servico);
        }
    }
}
