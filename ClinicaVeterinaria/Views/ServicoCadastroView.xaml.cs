using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Utils;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;

namespace ClinicaVeterinaria.Views
{
    public partial class ServicoCadastroView : Window
    {
        public ServicoCadastroController Controller { get; set; } = new ServicoCadastroController();

        public ServicoCadastroView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void tgbAbertoConcluido_Checked(object sender, RoutedEventArgs e)
        {
            (sender as ToggleButton).Content = (sender as ToggleButton).IsChecked == false ? "Aberto" : "Concluido";
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Controller.Servico.Observacao = new TextRange(rtxbObservacoes.Document.ContentStart, rtxbObservacoes.Document.ContentEnd).Text;
            
            if (Controller.BtnSalvar())
            {
                if (!string.IsNullOrWhiteSpace(Controller.Servico.Observacao))
                    if (MessageBox.Show("Deseja imprimir as Observações para esse serviço?", "Atenção", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        ImprimirServicoObservacao();

                this.Close();
            }
        }

        private void cmbClientesCadastrados_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            List<Animal> animais = Controller.BuscarAnimais();
            animais.Insert(0, new Animal() { Nome = "Selecionar" });

            cmbAnimais.ItemsSource = animais;
            Controller.AnimalIndex = 0;
        }

        private void txtHoraInicio_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            ValidarInput.Horas_PreviewTextInput(sender, e);
        }

        private void txtHoraFim_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            ValidarInput.Horas_PreviewTextInput(sender, e);
        }

        private void btnForeground_Checked(object sender, RoutedEventArgs e)
        {
            if (btnForeground.IsChecked == true)
                rtxbObservacoes.Selection.ApplyPropertyValue(Run.ForegroundProperty, "#FF0000");
            else
                rtxbObservacoes.Selection.ApplyPropertyValue(Run.ForegroundProperty, "#000000");
        }

        private void ImprimirServicoObservacao()
        {
            PrintDialog pd = new PrintDialog();

            if ((pd.ShowDialog() == true))
                pd.PrintDocument((((IDocumentPaginatorSource)rtxbObservacoes.Document).DocumentPaginator), "printing as paginator");
        }
    }
}
