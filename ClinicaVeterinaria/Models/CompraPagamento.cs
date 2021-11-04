using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models
{
    [Table("compras_pagamentos")]
    public class CompraPagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("forma_pagamento_id")]
        public int FormaPgtoId { get; set; }
        
        [Column("valor_pago")]
        public decimal ValorPago { get; set; }
    }
}
