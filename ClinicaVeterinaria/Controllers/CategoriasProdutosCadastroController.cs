using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ClinicaVeterinaria.Controllers
{
    public class CategoriasProdutosCadastroController : BaseNotifyPropertyChanged
    {
        private bool ProdutoTipo { get; set; }

        private CategoriaProduto _itemSelecionado;
        public CategoriaProduto ItemSelecionado 
        {
            get { return _itemSelecionado; }
            set { SetField(ref _itemSelecionado, value); }
        }

        private List<CategoriaProduto> _itensCadastrados;
        public List<CategoriaProduto> ItensCadastrados
        {
            get { return _itensCadastrados; }
            set { SetField(ref _itensCadastrados, value); }
        }

        public CategoriasProdutosCadastroController(bool produtoTipo = true)
        {
            this.ProdutoTipo = produtoTipo;
            ResetarItemSelecionado();
        }

        public void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ItemSelecionado.Descricao.Length == 0)
                    throw new Exception("A Descrição é obrigatória.");

                CategoriaProduto.Salvar(ItemSelecionado);
                CarregarItensCadastrados();

                MessageBox.Show($"Categoria [{ItemSelecionado.Descricao}] salva com sucesso.", "Sucesso");
                ResetarItemSelecionado();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Não foi possível salvar Categoria \nErro: {err.Message}", "Atenção");
            }
        }

        public void BtnDeletar_Click(object sender, RoutedEventArgs e)
        {
            int idExcluir = (int)(sender as Button).Tag;
            if (idExcluir <= 0) return;

            CategoriaProduto itemExcluir = CategoriaProduto.BuscarPorId(idExcluir);
            if (itemExcluir == null) return;

            try
            {
                CategoriaProduto.Excluir(itemExcluir);
                CarregarItensCadastrados();

                MessageBox.Show($"Categoria [{itemExcluir.Descricao}] excluída com sucesso.", "Sucesso");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Não foi possível excluir Categoria \nErro: {err.Message}", "Atenção");
            }
        }

        public void CarregarItensCadastrados() => ItensCadastrados = CategoriaProduto.BuscarRegistroAtivos(ProdutoTipo);

        public void BtnLimpar_Click(object sender, RoutedEventArgs e) => ResetarItemSelecionado();

        private void ResetarItemSelecionado()
        {
            ItemSelecionado = null;
            ItemSelecionado = new CategoriaProduto() { Id = 0, Descricao = "", Status = true, TipoProduto = ProdutoTipo };
        }
    }
}
