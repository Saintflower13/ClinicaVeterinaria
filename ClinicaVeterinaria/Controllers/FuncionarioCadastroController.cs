using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace ClinicaVeterinaria.Controllers
{
    public class FuncionarioCadastroController : BaseNotifyPropertyChanged
    {
        private Funcionario _funcionario = new Funcionario();
        public Funcionario Funcionario
        {
            get { return _funcionario; }
            set { SetField(ref _funcionario, value); }
        }

        private List<FuncionarioFuncao> _funcoesDisponiveis = new List<FuncionarioFuncao>();
        public List<FuncionarioFuncao> FuncoesDisponiveis
        {
            get { return _funcoesDisponiveis; }
            set { SetField(ref _funcoesDisponiveis, value); }
        }

        public FuncionarioCadastroController()
        {
            CarregarFuncoesDisponiveis();
        }

        public FuncionarioCadastroController(object funcionario)
        {
            CarregarFuncoesDisponiveis();
            Funcionario = (Funcionario)funcionario;
        }

        public bool BtnSalvar()
        {
            try
            {
                ValidarDados();
                Funcionario.Salvar(Funcionario);
                ResetarFuncionario();

                MessageBox.Show("Funcionário salvo com sucesso.", "Sucesso");
                return true;
            } catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "Atenção");
                return false;
            }
        }

        private void ValidarDados()
        {
            if (string.IsNullOrEmpty(Funcionario.NomeCompleto))
                throw new Exception("Nome completo é obrigatório.");

            if (Funcionario.FuncaoId <= 0)
                throw new Exception("Função é obrigatória.");

            if (string.IsNullOrEmpty(Funcionario.Usuario))
                throw new Exception("Usuario é obrigatório.");

            if (string.IsNullOrEmpty(Funcionario.Senha))
                throw new Exception("Senha é obrigatória.");
        }

        private void CarregarFuncoesDisponiveis()
        {
            FuncoesDisponiveis = FuncionarioFuncao.BuscarRegistroAtivos();
            FuncoesDisponiveis.Insert(0, new FuncionarioFuncao() { Descricao = "Selecionar Função" });
        }

        private void ResetarFuncionario()
        {
            Funcionario = null;
            Funcionario = new Funcionario();
        }
    }
}
