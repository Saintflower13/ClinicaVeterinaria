using System.Windows;
using System.Windows.Input;

namespace ClinicaVeterinaria.Views
{
    public partial class ComprasListarView : Window
    {
        public ComprasListarView()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CompraDetalhesView compraDetalhesView = new CompraDetalhesView();
            compraDetalhesView.ShowDialog();
        }
    }
}
