using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria
{
    public static class Sessao
    {
        private static Funcionario _funcionarioLogado = null;
        public static Funcionario FuncionarioLogado { set { _funcionarioLogado = value; } }

        public static bool UsuariologadoEhAdmin()
        {
            if (_funcionarioLogado == null) return false;
            return _funcionarioLogado.Tipo;
        }
    }
}
