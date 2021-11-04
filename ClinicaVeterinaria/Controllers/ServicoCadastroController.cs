using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace ClinicaVeterinaria.Controllers
{
    public class ServicoCadastroController : BaseNotifyPropertyChanged
    {
        public Servico Servico { get; set; } = new Servico();

        private List<Funcionario> _funcionariosCadastrados;
        public List<Funcionario> FuncionariosCadastrados {
            get { return _funcionariosCadastrados; }
            set { SetField(ref _funcionariosCadastrados, value);  }
        }

        public List<Animal> AnimaisCadastrados;

        private List<Cliente> _clientes;
        public List<Cliente> ClientesCadastrados {
            get { return _clientes; }
            set { SetField(ref _clientes, value); }
        }

        private List<Produto> _servicosCadastrados;

        public List<Produto> ServicosCadastrados
        {
            get { return _servicosCadastrados; }
            set { SetField(ref _servicosCadastrados, value); }
        }

        private int _atendenteIndex;
        public int AtendenteIndex
        {
            get
            {
                _atendenteIndex = FuncionariosCadastrados.FindIndex(e => e.Id == Servico.AtendenteId);
                return _atendenteIndex;
            }
            set
            {
                SetField(ref _atendenteIndex, value);
                Servico.AtendenteId = FuncionariosCadastrados[_atendenteIndex].Id;
            }
        }

        private int _responsavelIndex;
        public int ResponsavelIndex
        {
            get
            {
                _responsavelIndex = FuncionariosCadastrados.FindIndex(e => e.Id == Servico.FuncionarioId);
                return _responsavelIndex;
            }
            set
            {
                SetField(ref _responsavelIndex, value);
                Servico.FuncionarioId = FuncionariosCadastrados[_responsavelIndex].Id;
            }
        }

        private int _clienteIndex;
        public int ClienteIndex
        {
            get
            {
                _clienteIndex = ClientesCadastrados.FindIndex(e => e.Id == Servico.ClienteId);
                return _clienteIndex;
            }
            set
            {
                SetField(ref _clienteIndex, value);
                Servico.ClienteId = ClientesCadastrados[_clienteIndex].Id;
            }
        }

        private int _animalIndex = 0;
        public int AnimalIndex
        {
            get
            {
                _animalIndex =  AnimaisCadastrados.FindIndex(e => e.Id == Servico.AnimalId);
                return _animalIndex;
            }
            set
            {
                SetField(ref _animalIndex, value);
                Servico.AnimalId = 0;

                if (value == -1)
                {
                    if (AnimaisCadastrados != null && AnimaisCadastrados.Count > 0)
                        _animalIndex = 0;
                }

                if (_animalIndex > -1)
                    Servico.AnimalId = AnimaisCadastrados[_animalIndex].Id;
            }
        }

        private int _servicoIndex;
        public int ServicoIndex
        {
            get
            {
                _servicoIndex = ServicosCadastrados.FindIndex(e => e.Id == Servico.ProdutoId);
                return _servicoIndex;
            }
            set
            {
                SetField(ref _servicoIndex, value);
                Servico.ProdutoId = ServicosCadastrados[_servicoIndex].Id;
            }
        }

        public ServicoCadastroController()
        {
            CarregarListasAuxiliares();
        }

        public ServicoCadastroController(object servico)
        {
            Servico = (Servico)servico;
            CarregarListasAuxiliares();
        }

        public bool BtnSalvar()
        {
            try
            {
                ValidarDados();
                Servico.Salvar(Servico);

                MessageBox.Show("Serviço salvo com sucesso.", "Sucesso");
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
            if (Servico.AtendenteId <= 0)
                throw new Exception("Atendente é obrigatório.");

            if (Servico.AnimalId <= 0)
                throw new Exception("Animal é obrigatório.");

            if (Servico.ProdutoId <= 0)
                throw new Exception("Serviço é obrigatório.");

            if (Servico.FuncionarioId <= 0)
                throw new Exception("Responsável é obrigatório.");

            if (Servico.DataInicio == null)
                throw new Exception("Data de início é obrigatório.");

            if (Servico.HoraInicio.Length != 5)
                throw new Exception("Horário de início é obrigatório.");
        }

        private void CarregarListasAuxiliares()
        {
            CarregarFuncionarios();
            CarregarClientes();
            CarregarTiposServicos();
        }

        private void CarregarFuncionarios()
        {
            FuncionariosCadastrados = null;
            FuncionariosCadastrados = Funcionario.BuscarFuncionariosAtivos();
            FuncionariosCadastrados.Insert(0, new Funcionario() { Usuario = "Selecionar" });
        }

        private void CarregarClientes()
        {
            ClientesCadastrados = null;
            ClientesCadastrados = Cliente.BuscarClientesAtivos();
            ClientesCadastrados.Insert(0, new Cliente() { Nome = "Selecionar" });
        }

        public List<Animal> BuscarAnimais() 
        {
            if (Servico.ClienteId > 0)
                AnimaisCadastrados = Animal.BuscarPorClienteId(Servico.ClienteId);
            else
                AnimaisCadastrados = Animal.BuscarAnimaisAtivos();

            return AnimaisCadastrados;
        }

        private void CarregarTiposServicos()
        {
            ServicosCadastrados = null;
            ServicosCadastrados = Produto.BuscarServicosAtivos();
            ServicosCadastrados.Insert(0, new Produto() { Descricao = "Selecionar" });
        }
    }
}
