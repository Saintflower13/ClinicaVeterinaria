using System.Windows;
using System.Windows.Input;

namespace ClinicaVeterinaria.Views
{
    public partial class VendasListarView : Window
    {
        public VendasListarView()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            VendaDetalhesView vendaDetalhesView = new VendaDetalhesView();
            vendaDetalhesView.ShowDialog();
        }
    }
}
