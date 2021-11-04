using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.UserControls;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class AnimaisEspeciesCadastroView : Window
    {
        public AnimaisEspeciesCadastroController Controller { get; set; } = new AnimaisEspeciesCadastroController();

        public AnimaisEspeciesCadastroView()
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
                    "Gerenciamento de Espécies Animais",
                    "Espécies Cadastradas",
                    "Descrição Espécie"
                );

            controlCadastroBasico.SetarDataContext(this);
            controlCadastroBasico.btnSalvar.Click += Controller.BtnSalvar_Click;
            controlCadastroBasico.btnLimpar.Click += Controller.BtnLimpar_Click;
            controlCadastroBasico.btnDeletar.Click += Controller.BtnDeletar_Click;

            grdEspeciesCadastro.Children.Add(controlCadastroBasico);
        }
    }
}
