using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.UserControls;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class FormasPagamentoCadastroView : Window
    {
        public FormasPagamentoCadastroController Controller { get; set; } = new FormasPagamentoCadastroController();

        public FormasPagamentoCadastroView()
        {
            InitializeComponent();
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            CriarControlCadastroBasico();
            Controller.CarregarItensCadastrados();
        }

        private void CriarControlCadastroBasico()
        {
            ControlCadastroBasico controlCadastroBasico = new ControlCadastroBasico(
                    "Gerenciamento de Formas de Pagamento",
                    "Formas de Pagamento Cadastradas",
                    "Descrição Forma de Pagamento"
                );

            controlCadastroBasico.SetarDataContext(this);
            controlCadastroBasico.btnSalvar.Click += Controller.BtnSalvar_Click;
            controlCadastroBasico.btnLimpar.Click += Controller.BtnLimpar_Click;
            controlCadastroBasico.btnDeletar.Click += Controller.BtnDeletar_Click;

            grdFrmsPgtoCadastro.Children.Add(controlCadastroBasico);
        }
    }
}
