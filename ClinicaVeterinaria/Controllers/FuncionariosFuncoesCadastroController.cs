using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ClinicaVeterinaria.Controllers
{
    public class FuncionariosFuncoesCadastroController : BaseNotifyPropertyChanged
    {
        private FuncionarioFuncao _itemSelecionado = new FuncionarioFuncao() { Id = 0, Descricao = "", Status = true };
        public FuncionarioFuncao ItemSelecionado
        {
            get { return _itemSelecionado; }
            set { SetField(ref _itemSelecionado, value); }
        }

        private List<FuncionarioFuncao> _itensCadastrados;
        public List<FuncionarioFuncao> ItensCadastrados
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

                FuncionarioFuncao.Salvar(ItemSelecionado);
                CarregarItensCadastrados();

                MessageBox.Show($"Função [{ItemSelecionado.Descricao}] salva com sucesso.", "Sucesso");
                ResetarItemSelecionado();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Não foi possível salvar Função \nErro: {err.Message}", "Atenção");
            }
        }

        public void BtnDeletar_Click(object sender, RoutedEventArgs e)
        {
            int idExcluir = (int)(sender as Button).Tag;
            if (idExcluir <= 0) return;

            FuncionarioFuncao itemExcluir = FuncionarioFuncao.BuscarPorId(idExcluir);
            if (itemExcluir == null) return;

            try
            {
                FuncionarioFuncao.Excluir(itemExcluir);
                CarregarItensCadastrados();

                MessageBox.Show($"Função [{itemExcluir.Descricao}] excluída com sucesso.", "Sucesso");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Não foi possível excluir Função \nErro: {err.Message}", "Atenção");
            }
        }

        public void CarregarItensCadastrados() => ItensCadastrados = FuncionarioFuncao.BuscarRegistroAtivos();

        public void BtnLimpar_Click(object sender, RoutedEventArgs e) => ResetarItemSelecionado();

        private void ResetarItemSelecionado()
        {
            ItemSelecionado = null;
            ItemSelecionado = new FuncionarioFuncao() { Id = 0, Descricao = "", Status = true };
        }
    }
}
