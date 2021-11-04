using ClinicaVeterinaria.Models;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    public class FuncionariosListarController : BaseNotifyPropertyChanged
    {
        private List<Funcionario> _funcionariosCadastrados;
        public List<Funcionario> FuncionariosCadastrados
        {
            get { return _funcionariosCadastrados; }
            set { SetField(ref _funcionariosCadastrados, value); }
        }

        public void CarregarFuncionariosAtivos()
        {
            FuncionariosCadastrados = null;
            FuncionariosCadastrados = Funcionario.BuscarFuncionariosAtivos();
        }

        public void CarregarFuncionariosAtivos(string funcionario)
        {
            FuncionariosCadastrados = null;
            FuncionariosCadastrados = Funcionario.BuscarFuncionariosPorNomeEUsuario(funcionario);
        }
    }
}
