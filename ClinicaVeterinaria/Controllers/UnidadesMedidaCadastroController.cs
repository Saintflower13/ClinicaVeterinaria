using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ClinicaVeterinaria.Controllers
{
    public class UnidadesMedidaCadastroController : BaseNotifyPropertyChanged
    {
        private UnidadeMedida _itemSelecionado = new UnidadeMedida() { Id = 0, Descricao = "", Status = true };
        public UnidadeMedida ItemSelecionado { 
            get { return _itemSelecionado; } 
            set { SetField(ref _itemSelecionado, value); } 
        }

        private List<UnidadeMedida> _itensCadastrados;
        public List<UnidadeMedida> ItensCadastrados
        {
            get { return _itensCadastrados; }
            set { SetField(ref _itensCadastrados, value); }
        }

        public void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ItemSelecionado.Descricao.Length == 0)
                    throw new Exception("A Descrição é obrigatória.");

                UnidadeMedida.Salvar(ItemSelecionado);
                CarregarItensCadastrados();

                MessageBox.Show($"Unidade de Medida [{ItemSelecionado.Descricao}] salva com sucesso.", "Sucesso");
                ResetarItemSelecionado();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Não foi possível salvar Unidade de Medida \nErro: {err.Message}", "Atenção");
            }
        }

        public void BtnDeletar_Click(object sender, RoutedEventArgs e)
        {
            int idExcluir = (int)(sender as Button).Tag;
            if (idExcluir <= 0) return;

            UnidadeMedida itemExcluir = UnidadeMedida.BuscarPorId(idExcluir);
            if (itemExcluir == null) return;

            try
            {
                UnidadeMedida.Excluir(itemExcluir);
                CarregarItensCadastrados();

                MessageBox.Show($"Unidade de Medida [{itemExcluir.Descricao}] excluída com sucesso.", "Sucesso");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Não foi possível excluir Unidade de Medida \nErro: {err.Message}", "Atenção");
            }
        }

        public void CarregarItensCadastrados() => ItensCadastrados = UnidadeMedida.BuscarRegistroAtivos();

        public void BtnLimpar_Click(object sender, RoutedEventArgs e) => ResetarItemSelecionado();

        private void ResetarItemSelecionado()
        {
            ItemSelecionado = null;
            ItemSelecionado = new UnidadeMedida() { Id = 0, Descricao = "", Status = true };
        }
    }
}
