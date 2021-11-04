using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    public class VendaCadastroController : BaseNotifyPropertyChanged
    {
        private Venda _venda;
        public Venda Venda
        {
            get { return _venda; }
            set { SetField(ref _venda, value); }
        }

        public decimal Troco { get { return CalcularTotalPgto() - CalcularTotalVenda(); } }

        private List<VendaProduto> _vendaProduto;
        public List<VendaProduto> Produtos
        {
            get { return _vendaProduto; }
            set { SetField(ref _vendaProduto, value); }
        }

        private List<VendaPagamento> _vendaPgtos;
        public List<VendaPagamento> Pagamentos
        {
            get { return _vendaPgtos; }
            set { SetField(ref _vendaPgtos, value); }
        }

        private List<Funcionario> _funcionariosCadastrados;
        public List<Funcionario> FuncionariosCadastrados
        {
            get { return _funcionariosCadastrados; }
            set { SetField(ref _funcionariosCadastrados, value); }
        }

        private List<FormasPagamento> _frmsPgto;
        public List<FormasPagamento> FormasPagamentosCadastradas
        {
            get { return _frmsPgto; }
            set { SetField(ref _frmsPgto, value); }
        }

        private int _vendedorIndex;
        public int VendedorIndex
        {
            get
            {
                _vendedorIndex = FuncionariosCadastrados.FindIndex(e => e.Id == Venda.VendedorId);
                return _vendedorIndex;
            }
            set
            {
                SetField(ref _vendedorIndex, value);
                Venda.VendedorId = FuncionariosCadastrados[_vendedorIndex].Id;
            }
        }

        private int _pgtoIndex;
        public int PgtoIndex
        {
            get
            {
                _pgtoIndex = FormasPagamentosCadastradas.FindIndex(e => e.Id == Venda.VendedorId);
                return _pgtoIndex;
            }
            set
            {
                SetField(ref _pgtoIndex, value);
                Venda.VendedorId = FormasPagamentosCadastradas[_pgtoIndex].Id;
            }
        }

        public VendaCadastroController()
        {
            ResetarVenda();
            CarregarListasAuxiliares();
        }

        public void ResetarVenda() {
            Venda = null;
            Produtos = null;
            Pagamentos = null;
            Venda = new Venda();
            Produtos = new List<VendaProduto>();
            Pagamentos = new List<VendaPagamento>();
        }
        
        public void SalvarVenda()
        {
            Venda.Produtos = Produtos;
            Venda.Pagamentos = Pagamentos;
            Venda.ValorTotal = CalcularTotalVenda();
            Venda.Salvar(Venda);
            ResetarVenda();
        }

        public void ValidarDados()
        {
            if (VendedorIndex < 1) throw new Exception("Vendedor é obrigatório.");
            if (Produtos.Count < 1) throw new Exception("Não é possível finalizar a venda sem produtos.");
            if (Pagamentos.Count < 1) throw new Exception("Não é possível finalizar a venda sem pagamentos.");
            if (CalcularTotalPgto() < CalcularTotalVenda()) throw new Exception("Valor de pagamento é inferior ao valor total da venda.");
        }

        public decimal CalcularTotalVenda()
        {
            decimal total = 0;

            for (int i = 0; i < Produtos.Count; i++)
                total += Produtos[i].ValorTotal;

            return total;
        }

        public decimal CalcularTotalPgto()
        {
            decimal total = 0;

            for (int i = 0; i < Pagamentos.Count; i++)
                total += Pagamentos[i].ValorPago;

            return total;
        }

        private void CarregarListasAuxiliares()
        {
            CarregarFuncionarios();
            CarregarFormasPgto();
        }

        private void CarregarFuncionarios()
        {
            FuncionariosCadastrados = null;
            FuncionariosCadastrados = Funcionario.BuscarFuncionariosAtivos();
            FuncionariosCadastrados.Insert(0, new Funcionario() { Usuario = "Selecionar" });
        }

        private void CarregarFormasPgto()
        {
            FormasPagamentosCadastradas = null;
            FormasPagamentosCadastradas = FormasPagamento.BuscarRegistroAtivos();
            FormasPagamentosCadastradas.Insert(0, new FormasPagamento() { Descricao = "Selecionar" });
        }
    }
}
