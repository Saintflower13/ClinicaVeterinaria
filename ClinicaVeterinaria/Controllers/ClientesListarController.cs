using ClinicaVeterinaria.Models;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    public class ClientesListarController : BaseNotifyPropertyChanged
    {
        private List<Cliente> _clientesCadastrados;
        public List<Cliente> ClientesCadastrados
        {
            get { return _clientesCadastrados; }
            set { SetField(ref _clientesCadastrados, value); }
        }

        public void CarregarClientesAtivos()
        {
            ClientesCadastrados = null;
            ClientesCadastrados = Cliente.BuscarClientesAtivos();
        }

        public void CarregarClientesAtivos(string cliente)
        {
            ClientesCadastrados = null;
            ClientesCadastrados = Cliente.BuscarClientesPorNomeECNPJ(cliente);
        }
    }
}
