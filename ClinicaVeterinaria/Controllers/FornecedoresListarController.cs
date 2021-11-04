using ClinicaVeterinaria.Models;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    public class FornecedoresListarController : BaseNotifyPropertyChanged
    {
        private List<Fornecedor> _fornecedoresCadastrados;
        public List<Fornecedor> FornecedoresCadastrados
        {
            get { return _fornecedoresCadastrados; }
            set { SetField(ref _fornecedoresCadastrados, value); }
        }

        public void CarregarFornecedoresAtivos()
        {
            FornecedoresCadastrados = null;
            FornecedoresCadastrados = Fornecedor.BuscarFornecedoresAtivos();
        }

        public void CarregarFornecedoresAtivos(string fornecedor)
        {
            FornecedoresCadastrados = null;
            FornecedoresCadastrados = Fornecedor.BuscarFornecedorPorRazaoSocialENomeFantasia(fornecedor);
        }
    }
}
