using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.UserControls;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class CategoriasProdutosCadastroView : Window
    {
        public CategoriasProdutosCadastroController Controller { get; set; }

        public CategoriasProdutosCadastroView(bool produtoTipo = ProdutoTipo.Produto)
        {
            InitializeComponent();
            ConfigurarTela(produtoTipo);
        }

        private void ConfigurarTela(bool produtoTipo)
        {
            Controller = new CategoriasProdutosCadastroController(produtoTipo);

            CriarControlCadastroBasico(produtoTipo);
            Controller.CarregarItensCadastrados();
        }

        private void CriarControlCadastroBasico(bool produtoTipo)
        {
            string tipoCategoriaProduto = produtoTipo ? "Produto" : "Serviço";

            ControlCadastroBasico controlCadastroBasico = new ControlCadastroBasico(
                    $"Gerenciamento de Categoria de {tipoCategoriaProduto}s",
                    $"Categoria de {tipoCategoriaProduto}s Cadastradas",
                    $"Descrição Categoria de {tipoCategoriaProduto}"
                );

            controlCadastroBasico.SetarDataContext(this);
            controlCadastroBasico.btnSalvar.Click += Controller.BtnSalvar_Click;
            controlCadastroBasico.btnLimpar.Click += Controller.BtnLimpar_Click;
            controlCadastroBasico.btnDeletar.Click += Controller.BtnDeletar_Click;

            grdCategoriasProdutosCadastro.Children.Add(controlCadastroBasico);
        }
    }
}
