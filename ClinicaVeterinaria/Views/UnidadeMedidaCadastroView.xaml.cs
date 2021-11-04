using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.UserControls;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class UnidadeMedidaCadastroView : Window
    {
        public UnidadesMedidaCadastroController Controller { get; set; } = new UnidadesMedidaCadastroController();

        public UnidadeMedidaCadastroView()
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
                    "Gerenciamento de Unidades de Medida",
                    "Unidades de Medida Cadastradas",
                    "Descrição Unidades de Medida"
                );

            controlCadastroBasico.SetarDataContext(this);
            controlCadastroBasico.btnSalvar.Click += Controller.BtnSalvar_Click;
            controlCadastroBasico.btnLimpar.Click += Controller.BtnLimpar_Click;
            controlCadastroBasico.btnDeletar.Click += Controller.BtnDeletar_Click;

            grdUnMedidaCadastro.Children.Add(controlCadastroBasico);
        }
    }
}
