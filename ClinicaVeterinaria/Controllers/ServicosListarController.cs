using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.Models;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    public class ServicosListarController : BaseNotifyPropertyChanged
    {
        private List<ServicoDetalhes> _servicos;
        public List<ServicoDetalhes> Servicos
        {
            get { return _servicos; }
            set { SetField(ref _servicos, value); }
        }

        private List<Funcionario> _funcionariosCadastrados;
        public List<Funcionario> FuncionariosCadastrados
        {
            get { return _funcionariosCadastrados; }
            set { SetField(ref _funcionariosCadastrados, value); }
        }

        private List<Produto> _servico;
        public List<Produto> servicoCadastrados
        {
            get { return _servico; }
            set { SetField(ref _servico, value); }
        }

        public List<Animal> AnimaisCadastrados;

        private List<Cliente> _clientes;
        public List<Cliente> ClientesCadastrados
        {
            get { return _clientes; }
            set { SetField(ref _clientes, value); }
        }

        public ServicosListarController()
        {
            CarregarListasAuxiliares();
            BuscarServicos();
        }

        private void CarregarListasAuxiliares()
        {
            CarregarFuncionarios();
            CarregarTiposServicos();
            CarregarClientes();
            BuscarAnimais();
        }

        private void CarregarFuncionarios()
        {
            FuncionariosCadastrados = null;
            FuncionariosCadastrados = Funcionario.BuscarFuncionariosAtivos();
            FuncionariosCadastrados.Insert(0, new Funcionario() { Usuario = "Selecionar" });
        }

        private void CarregarTiposServicos()
        {
            servicoCadastrados = null;
           // servicoCadastrados = Produto.BuscarRegistroAtivos(ProdutoTipo.Servico);
           // servicoCadastrados.Insert(0, new CategoriaProduto() { Descricao = "Selecionar" });
        }

        private void CarregarClientes()
        {
            ClientesCadastrados = null;
            ClientesCadastrados = Cliente.BuscarClientesAtivos();
            ClientesCadastrados.Insert(0, new Cliente() { Nome = "Selecionar" });
        }

        public List<Animal> BuscarAnimais(int clienteId = 0)
        {
            if (clienteId > 0)
                AnimaisCadastrados = Animal.BuscarPorClienteId(clienteId);
            else
                AnimaisCadastrados = Animal.BuscarAnimaisAtivos();

            AnimaisCadastrados.Insert(0, new Animal() { Nome = "Selecionar" });
            return AnimaisCadastrados;
        }

        public void BuscarServicos()
        {
            Servicos = null;
            Servicos = Servico.BuscarServicosDetalhados();
        }

        public void BuscarServicos(Servico servico)
        {
            Servicos = null;
            Servicos = Servico.BuscarServicosDetalhados(servico);
        }
    }
}
