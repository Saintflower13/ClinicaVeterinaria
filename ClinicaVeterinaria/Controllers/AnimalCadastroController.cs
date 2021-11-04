using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace ClinicaVeterinaria.Controllers
{
    public class AnimalCadastroController : BaseNotifyPropertyChanged
    {
        private Animal _animal = new Animal();
        public Animal Animal
        {
            get { return _animal; }
            set { SetField(ref _animal, value); }
        }

        private List<Cliente> _clientesCadastrados = new List<Cliente>();
        public List<Cliente> ClientesCadastrados
        {
            get { return _clientesCadastrados; }
            set { SetField(ref _clientesCadastrados, value); }
        }

        private List<AnimalEspecie> _especiesCadastradas = new List<AnimalEspecie>();
        public List<AnimalEspecie> EspeciesCadastradas
        {
            get { return _especiesCadastradas; }
            set { SetField(ref _especiesCadastradas, value); }
        }

        private int _clienteSelecionadoIndex = 0;
        public int ClienteSelecionadoIndex
        {
            get
            {
                _clienteSelecionadoIndex = ClientesCadastrados.FindIndex(cliente => cliente.Id == Animal.ClienteId);
                return _clienteSelecionadoIndex;
            }
            set
            {
                SetField(ref _clienteSelecionadoIndex, value);
                Animal.ClienteId = ClientesCadastrados[_clienteSelecionadoIndex].Id;
            }
        }

        private int _especieSelecionadaIndex = 0;
        public int EspecieSelecionadaIndex
        {
            get
            {
                _especieSelecionadaIndex = EspeciesCadastradas.FindIndex(especie => especie.Id == Animal.AnimalEspecieId);
                return _especieSelecionadaIndex;
            }
            set
            {
                SetField(ref _especieSelecionadaIndex, value);
                Animal.AnimalEspecieId = EspeciesCadastradas[_especieSelecionadaIndex].Id;
            }
        }

        public AnimalCadastroController() 
        {
            CarregarListasAuxiliares();
        }

        public AnimalCadastroController(object animal)
        {
            Animal = (Animal)animal;
            CarregarListasAuxiliares();
        }

        public bool BtnSalvar()
        {
            try
            {
                ValidarDados();
                Animal.Salvar(Animal);

                MessageBox.Show("Animal salvo com sucesso.", "Sucesso");
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
            if (Animal.ClienteId <= 0)
                throw new Exception("Cliente é obrigatório.");

            if (string.IsNullOrEmpty(Animal.Nome))
                throw new Exception("Nome é obrigatório.");

            if (Animal.AnimalEspecieId <= 0)
                throw new Exception("Espécie é obrigatório.");
        }

        private void CarregarListasAuxiliares()
        {
            CarregarClientesDisponiveis();
            CarregarEspeciesDisponiveis();
        }

        private void CarregarClientesDisponiveis()
        {
            ClientesCadastrados = Cliente.BuscarClientesAtivos();
            ClientesCadastrados.Insert(0, new Cliente() { Nome = "Selecionar" });
        }

        private void CarregarEspeciesDisponiveis()
        {
            EspeciesCadastradas = AnimalEspecie.BuscarRegistroAtivos();
            EspeciesCadastradas.Insert(0, new AnimalEspecie() { Descricao = "Selecionar" });
        }
    }
}
