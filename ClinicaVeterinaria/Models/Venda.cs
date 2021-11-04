using ClinicaVeterinaria.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models
{
    [Table("vendas")]
    public class Venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Observacoes { get; set; }

        [Column("vendedor_id")]
        public int VendedorId { get; set; }

        [Column("valor_total")]
        public decimal ValorTotal { get; set; }

        [Column("data_emissao")]
        public DateTime DataEmissao { get; set; } = DateTime.Now;

        public List<VendaProduto> Produtos { get; set; }

        public List<VendaPagamento> Pagamentos { get; set; }

        public void Salvar(Venda venda)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                context.Vendas.Add(venda);
                context.SaveChanges();
            }
        }
    }
}
