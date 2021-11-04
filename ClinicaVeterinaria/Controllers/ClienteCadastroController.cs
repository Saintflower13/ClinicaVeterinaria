using ClinicaVeterinaria.Models;
using System;
using System.Windows;

namespace ClinicaVeterinaria.Controllers
{
    public class ClienteCadastroController : BaseNotifyPropertyChanged
    {
        private Cliente _cliente = new Cliente();
        public Cliente Cliente
        {
            get { return _cliente; }
            set { SetField(ref _cliente, value); }
        }

        public ClienteCadastroController() { }

        public ClienteCadastroController(object cliente)
        {
            Cliente = (Cliente)cliente;
        }

        public bool BtnSalvar()
        {
            try
            {
                ValidarDados();
                Cliente.Salvar(Cliente);

                MessageBox.Show("Cliente salvo com sucesso.", "Sucesso");
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
            if (string.IsNullOrEmpty(Cliente.Nome))
                throw new Exception("Nome é obrigatório.");

            if (string.IsNullOrEmpty(Cliente.Sobrenome))
                throw new Exception("Sobrenome é obrigatório.");
        }
    }
}
