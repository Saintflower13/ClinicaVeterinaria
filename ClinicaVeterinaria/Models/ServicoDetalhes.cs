using ClinicaVeterinaria.Data;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    public class ServicoDetalhes
    {
        public Servico ServicoDetalhado { get; set; }

        public string ClienteNome { get; set; } = "";
        public string AnimalNome { get; set; } = "";
        public string FuncionarioNome { get; set; } = "";
        public string ServicoCategoria { get; set; } = "";
        public string Status { get; set; } = "";

        public ServicoDetalhes() {}

        public ServicoDetalhes(Servico servico)
        {
            ServicoDetalhado = servico;
            CarregarServico();
        }

        public void CarregarServico()
        {
            try { 
                Animal animal = Animal.BuscarPorId(ServicoDetalhado.AnimalId);

                ClienteNome = Cliente.BuscarPorId(animal.ClienteId)?.NomeCompleto;
                AnimalNome = animal.Nome;
                FuncionarioNome = Funcionario.BuscarPorId(ServicoDetalhado.FuncionarioId)?.Usuario;
                ServicoCategoria = Produto.BuscarPorId(ServicoDetalhado.ProdutoId)?.Descricao;
                Status = ServicoDetalhado.Status ? "Concluído" : "Aberto";
            }
            catch { }
        }
    }
}
