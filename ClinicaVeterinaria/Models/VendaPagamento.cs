using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models
{
    [Table("vendas_pagamentos")]
    public class VendaPagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("venda_id")]
        public int VendaId { get; set; }

        [Column("forma_pagamento_id")]
        public int FormaPgtoId { get; set; }

        [Column("valor_pago")]
        public decimal ValorPago { get; set; }

        [NotMapped]
        public FormasPagamento FormaPagamento { get; set; }

        public VendaPagamento() { }

        public VendaPagamento(FormasPagamento formasPagamento, decimal valorPago)
        {
            Id = 0;
            VendaId = 0;
            FormaPgtoId = formasPagamento.Id;
            ValorPago = valorPago;
            FormaPagamento = formasPagamento;
        }
    }
}
