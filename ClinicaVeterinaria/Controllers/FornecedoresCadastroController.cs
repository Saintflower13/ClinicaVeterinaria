using ClinicaVeterinaria.Models;
using System;
using System.Windows;

namespace ClinicaVeterinaria.Controllers
{
    public class FornecedoresCadastroController : BaseNotifyPropertyChanged
    {
        private Fornecedor _fornecedor = new Fornecedor();
        public Fornecedor Fornecedor
        {
            get { return _fornecedor; }
            set { SetField(ref _fornecedor, value); }
        }

        public FornecedoresCadastroController(){}

        public FornecedoresCadastroController(object fornecedor)
        {
            Fornecedor = (Fornecedor)fornecedor;
        }

        public bool BtnSalvar()
        {
            try
            {
                ValidarDados();
                Fornecedor.Salvar(Fornecedor);
                ResetarFornecedor();

                MessageBox.Show("Fornecedor salvo com sucesso.", "Sucesso");
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
            if (string.IsNullOrEmpty(Fornecedor.RazaoSocial))
                throw new Exception("Razão social é obrigatória.");

            if (string.IsNullOrEmpty(Fornecedor.CNPJ))
                throw new Exception("CNPJ é obrigatório.");

            if (string.IsNullOrEmpty(Fornecedor.Telefone))
                throw new Exception("Telefone é obrigatório.");
        }

        private void ResetarFornecedor()
        {
            Fornecedor = null;
            Fornecedor = new Fornecedor();
        }
    }
}
