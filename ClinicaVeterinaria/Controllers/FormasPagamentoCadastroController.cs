using ClinicaVeterinaria.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ClinicaVeterinaria.Controllers
{
    public class FormasPagamentoCadastroController : BaseNotifyPropertyChanged
    {
        private FormasPagamento _itemSelecionado = new FormasPagamento() { Id = 0, Descricao = "", Status = true };
        public FormasPagamento ItemSelecionado { 
            get { return _itemSelecionado; } 
            set { SetField(ref _itemSelecionado, value); } 
        }

        private List<FormasPagamento> _itensCadastrados;
        public List<FormasPagamento> ItensCadastrados
        {
            get { return _itensCadastrados; }
            set { SetField(ref _itensCadastrados, value); }
        }

        public void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (ItemSelecionado.Descricao.Length == 0)
                    throw new Exception("A Descrição é obrigatória.");

                FormasPagamento.Salvar(ItemSelecionado);
                CarregarItensCadastrados(); 

                MessageBox.Show($"Forma de pagamento [{ItemSelecionado.Descricao}] salva com sucesso.", "Sucesso");
                ResetarItemSelecionado();
            } catch (Exception err)
            {
                MessageBox.Show($"Não foi possível salvar Forma de Pagamento \nErro: {err.Message}", "Atenção");
            }
        }

        public void BtnDeletar_Click(object sender, RoutedEventArgs e)
        {
            int idExcluir = (int)(sender as Button).Tag;
            if (idExcluir <= 0) return;

            FormasPagamento itemExcluir = FormasPagamento.BuscarPorId(idExcluir);
            if (itemExcluir == null) return;

            try { 
                FormasPagamento.Excluir(itemExcluir);
                CarregarItensCadastrados();
            
                MessageBox.Show($"Forma de pagamento [{itemExcluir.Descricao}] excluída com sucesso.", "Sucesso");
            } catch (Exception err)
            {
                MessageBox.Show($"Não foi possível excluir Forma de Pagamento \nErro: {err.Message}", "Atenção");
            }
        }

        public void CarregarItensCadastrados() => ItensCadastrados = FormasPagamento.BuscarRegistroAtivos();
        
        public void BtnLimpar_Click(object sender, RoutedEventArgs e) => ResetarItemSelecionado();

        private void ResetarItemSelecionado()
        {
            ItemSelecionado = null;
            ItemSelecionado = new FormasPagamento() { Id = 0, Descricao = "", Status = true };
        }
    }
}
