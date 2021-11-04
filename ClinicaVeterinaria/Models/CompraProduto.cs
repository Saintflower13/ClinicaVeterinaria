using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models
{
    [Table("compras_produtos")]
    public class CompraProduto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal Quantidade { get; set; }

        [Column("produto_id")]
        public int ProdutoId { get; set; }

        [Column("valor_unitario")]
        public decimal ValorUnitario { get; set; }
    }
}
