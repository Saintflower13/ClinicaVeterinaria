using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ClinicaVeterinaria.Controllers
{
    public class AnimaisEspeciesCadastroController : BaseNotifyPropertyChanged
    {
        private AnimalEspecie _itemSelecionado = new AnimalEspecie() { Id = 0, Descricao = "", Status = true };
        public AnimalEspecie ItemSelecionado
        {
            get { return _itemSelecionado; }
            set { SetField(ref _itemSelecionado, value); }
        }

        private List<AnimalEspecie> _itensCadastrados;
        public List<AnimalEspecie> ItensCadastrados
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

                AnimalEspecie.Salvar(ItemSelecionado);
                CarregarItensCadastrados();

                MessageBox.Show($"Espécie de Animal [{ItemSelecionado.Descricao}] salva com sucesso.", "Sucesso");
                ResetarItemSelecionado();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Não foi possível salvar Espécie de Animal \nErro: {err.Message}", "Atenção");
            }
        }

        public void BtnDeletar_Click(object sender, RoutedEventArgs e)
        {
            int idExcluir = (int)(sender as Button).Tag;
            if (idExcluir <= 0) return;

            AnimalEspecie itemExcluir = AnimalEspecie.BuscarPorId(idExcluir);
            if (itemExcluir == null) return;

            try
            {
                AnimalEspecie.Excluir(itemExcluir);
                CarregarItensCadastrados();

                MessageBox.Show($"Espécie de Animal [{itemExcluir.Descricao}] excluída com sucesso.", "Sucesso");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Não foi possível excluir Espécie de Animal \nErro: {err.Message}", "Atenção");
            }
        }

        public void CarregarItensCadastrados() => ItensCadastrados = AnimalEspecie.BuscarRegistroAtivos();

        public void BtnLimpar_Click(object sender, RoutedEventArgs e) => ResetarItemSelecionado();

        private void ResetarItemSelecionado()
        {
            ItemSelecionado = null;
            ItemSelecionado = new AnimalEspecie() { Id = 0, Descricao = "", Status = true };
        }
    }
}
