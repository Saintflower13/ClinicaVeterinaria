using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Controllers
{
    public class LoginViewController
    {
        public void Logar(string usuario, string senha)
        {
            ValidarCampos(usuario, senha);
            Funcionario funcionario = Funcionario.Logar(usuario, senha);

            if (funcionario == null) throw new System.Exception("Login incorreto.");

            Sessao.FuncionarioLogado = funcionario;
        }

        private void ValidarCampos(string usuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(usuario)) throw new System.Exception("Informe o usuário.");
            if (string.IsNullOrWhiteSpace(senha)) throw new System.Exception("Informe a senha.");
        }
    }
}
