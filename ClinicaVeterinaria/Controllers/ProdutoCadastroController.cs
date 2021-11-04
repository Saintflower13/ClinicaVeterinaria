using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace ClinicaVeterinaria.Controllers
{
    public class ProdutoCadastroController : BaseNotifyPropertyChanged
    {
        private Produto _produto = new Produto();
        public Produto Produto
        {
            get { return _produto; }
            set { SetField(ref _produto, value); }
        }

        private List<FuncionarioFuncao> _funcionariosFuncoes = new List<FuncionarioFuncao>();
        public List<FuncionarioFuncao> FuncionariosFuncoes
        {
            get { return _funcionariosFuncoes; }
            set { SetField(ref _funcionariosFuncoes, value); }
        }

        private List<UnidadeMedida> _unMedidas = new List<UnidadeMedida>();
        public List<UnidadeMedida> UnidadesMedida
        {
            get { return _unMedidas; }
            set { SetField(ref _unMedidas, value); }
        }

        private List<CategoriaProduto> _categorias = new List<CategoriaProduto>();
        public List<CategoriaProduto> CategoriasProdutos
        {
            get { return _categorias; }
            set { SetField(ref _categorias, value); }
        }

        private List<Fornecedor> _fornecedores = new List<Fornecedor>();
        public List<Fornecedor> Fornecedores
        {
            get { return _fornecedores; }
            set { SetField(ref _fornecedores, value); }
        }

        private int _funcionariosFuncoesIndex;
        public int FuncionariosFuncoesIndex
        {
            get 
            {
                _funcionariosFuncoesIndex = FuncionariosFuncoes.FindIndex(funcao => funcao.Id == Produto.FuncionarioTipoId);
                return  _funcionariosFuncoesIndex; 
            }
            set
            {
                SetField(ref _funcionariosFuncoesIndex, value);
                Produto.FuncionarioTipoId = FuncionariosFuncoes[_funcionariosFuncoesIndex].Id;
            }
        }

        private int _unMedidaIndex;
        public int UnidadesMedidaIndex
        {
            get {
                _unMedidaIndex = UnidadesMedida.FindIndex(unMedida => unMedida.Id == Produto.UnMedidaId);
                return _unMedidaIndex; 
            }
            set
            {
                SetField(ref _unMedidaIndex, value);
                Produto.UnMedidaId = UnidadesMedida[_unMedidaIndex].Id;
            }
        }

        private int _categoriasIndex;
        public int CategoriasIndex
        {
            get {
                _categoriasIndex = CategoriasProdutos.FindIndex(categoria => categoria.Id == Produto.CategoriaId);
                return _categoriasIndex; 
            }
            set
            {
                SetField(ref _categoriasIndex, value);
                Produto.CategoriaId = CategoriasProdutos[_categoriasIndex].Id;
            }
        }

        private int _fornecedorIndex;
        public int FornecedorIndex
        {
            get {
                _fornecedorIndex = Fornecedores.FindIndex(fornecedor => fornecedor.Id == Produto.FornecedorId);
                return _fornecedorIndex; 
            }
            set
            {
                SetField(ref _fornecedorIndex, value);
                Produto.FornecedorId = Fornecedores[_fornecedorIndex].Id;
            }
        }

        public ProdutoCadastroController() 
        {
            CarregarListasAuxiliares();
        }

        public ProdutoCadastroController(object produto)
        {
            CarregarListasAuxiliares();
            Produto = (Produto)produto;
        }

        public bool BtnSalvar()
        {
            try
            {
                ValidarDados();
                Produto.Salvar(Produto);
                ResetarProduto();

                MessageBox.Show("Produto salvo com sucesso.", "Sucesso");
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "Atenção");
                return false;
            }
        }

        private void ValidarDados()
        {
            if (string.IsNullOrEmpty(Produto.Descricao))
                throw new Exception("Descrição é obrigatória.");

            if (Produto.Valor < 0)
                throw new Exception("Valor deve ser um valor positivo.");

            if (Produto.FornecedorId <= 0)
                throw new Exception("Fornecedor é obrigatório");

            if (Produto.CategoriaId <= 0)
                throw new Exception("Categoria é obrigatória.");

            if (Produto.UnMedidaId <= 0)
                throw new Exception("Unidade de Medida é obrigatória.");

            if (Produto.FuncionarioTipoId <= 0)
                throw new Exception("Função do responsável é obrigatória.");
        }

        private void CarregarListasAuxiliares()
        {
            CarregarFuncoesDisponiveis();
            CarregarFornecedoresDisponiveis();
            CarregarUnidadesMedidasDisponiveis();
            CarregarCategoriasProdutosDisponiveis();
        }

        private void CarregarFuncoesDisponiveis()
        {
            FuncionariosFuncoes = FuncionarioFuncao.BuscarRegistroAtivos();
            FuncionariosFuncoes.Insert(0, new FuncionarioFuncao() { Descricao = "Selecionar" });
        }

        private void CarregarUnidadesMedidasDisponiveis()
        {
            UnidadesMedida = UnidadeMedida.BuscarRegistroAtivos();
            UnidadesMedida.Insert(0, new UnidadeMedida() { Descricao = "Selecionar" });
        }

        private void CarregarCategoriasProdutosDisponiveis()
        {
            CategoriasProdutos = CategoriaProduto.BuscarTodosRegistroAtivos();
            CategoriasProdutos.Insert(0, new CategoriaProduto() { Descricao = "Selecionar" });
        }

        private void CarregarFornecedoresDisponiveis()
        {
            Fornecedores = Fornecedor.BuscarFornecedoresAtivos();
            Fornecedores.Insert(0, new Fornecedor() { RazaoSocial = "Selecionar" });
        }

        private void ResetarProduto()
        {
            Produto = null;
            Produto = new Produto();
        }
    }
}
