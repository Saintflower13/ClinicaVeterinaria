using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models
{
    [Table("compra")]
    public class Compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal ValorTotal { get; set; }

        [Column("funcionario_id")]
        public int FuncionarioId { get; set; }

        [Column("fornecedor_id")]
        public int FornecedorId { get; set; }

        [Column("data_compra")]
        public DateTime DataCompra { get; set; }
    }
}
