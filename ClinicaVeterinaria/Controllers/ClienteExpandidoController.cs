using ClinicaVeterinaria.Models;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    public class ClienteExpandidoController 
    {
        public Cliente Cliente { get; set; }

        public ClienteExpandidoController(object cliente)
        {
            Cliente = (Cliente)cliente;
        }

        public void AtualizarCliente()
        {
            Cliente = Cliente.BuscarPorId(Cliente.Id);
        }

        public List<Animal> BuscarAnimaisCliente() => Animal.BuscarPorClienteId(Cliente.Id);
    }
}
