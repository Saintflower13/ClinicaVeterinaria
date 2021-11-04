using ClinicaVeterinaria.Models;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Controllers
{
    public class ProdutosListarController : BaseNotifyPropertyChanged
    {
        private List<Produto> _produtosCadastrados;
        public List<Produto> ProdutosCadastrados
        {
            get { return _produtosCadastrados; }
            set { SetField(ref _produtosCadastrados, value); }
        }

        public void CarregarProdutosAtivos()
        {
            ProdutosCadastrados = null;
            ProdutosCadastrados = Produto.BuscarProdutosAtivos();
        }

        public void CarregarProdutosAtivos(string produto)
        {
            ProdutosCadastrados = null;
            ProdutosCadastrados = Produto.BuscarPorDescricaoEId(produto);
        }
    }
}
