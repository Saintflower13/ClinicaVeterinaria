using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.UserControls;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class FuncionariosFuncoesCadastroView : Window
    {
        public FuncionariosFuncoesCadastroController Controller { get; set; } = new FuncionariosFuncoesCadastroController();

        public FuncionariosFuncoesCadastroView()
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
                    "Gerenciamento de Funções",
                    "Funções Cadastradas",
                    "Descrição Funções"
                );

            controlCadastroBasico.SetarDataContext(this);
            controlCadastroBasico.btnSalvar.Click += Controller.BtnSalvar_Click;
            controlCadastroBasico.btnLimpar.Click += Controller.BtnLimpar_Click;
            controlCadastroBasico.btnDeletar.Click += Controller.BtnDeletar_Click;

            grdFuncionariosFuncoesCadastro.Children.Add(controlCadastroBasico);
        }
    }
}
