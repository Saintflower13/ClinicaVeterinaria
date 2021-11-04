using ClinicaVeterinaria.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace ClinicaVeterinaria.UserControls
{
    public partial class ControlCadastroBasico : UserControl
    {
        public ControlCadastroBasico()
        {
            InitializeComponent();
        }

        public ControlCadastroBasico(string TituloTela, string TituloListView, string TituloAdicionar)
        {
            InitializeComponent();

            txtCadastroDescricao.Text = TituloTela;
            lbCadastrados.Text = TituloListView;
            lbAcaoCadastrarDescricao.Content = TituloAdicionar;
        }

        public void SetarDataContext(object DataContext)
        {
            this.DataContext = DataContext;
        }

        private void btnDeletarCadastro_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            btnDeletar.Tag = (sender as Button).Tag;
            btnDeletar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

        private void lvCadastrados_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ICadastroBasicoModel itemSelecionado = ((sender as ListBox).SelectedItem as ICadastroBasicoModel);

            if (itemSelecionado == null) return;

            txbDescricao.Tag = itemSelecionado.Id;
            txbDescricao.Text = itemSelecionado.Descricao;
        }

        private void txbDescricao_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key ==System.Windows.Input.Key.Back && (int)txbDescricao.Tag > 0 && txbDescricao.Text.Length == 0)
                btnLimpar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }
    }
}
