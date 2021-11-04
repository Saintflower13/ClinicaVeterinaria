using ClinicaVeterinaria.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models
{
    [Table("vendas_produtos")]
    public class VendaProduto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal Quantidade { get; set; }

        [Column("venda_id")]
        public int VendaId { get; set; }

        [Column("produto_id")]
        public int ProdutoId { get; set; }

        [NotMapped]
        public Produto Produto { get; set; }

        [Column("valor_unitario")]
        public decimal ValorUnitario { get; set; }

        [NotMapped]
        public decimal ValorTotal { get { return Produto.Valor * Quantidade; } }

        public VendaProduto() { }

        public VendaProduto(Produto produto, decimal qtd)
        {
            Id = 0;
            Quantidade = qtd;
            VendaId = 0;
            ProdutoId = produto.Id;
            ValorUnitario = produto.Valor;
            Produto = produto;
        }

        public void Salvar(VendaProduto produto)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (VendaId > 0)
                    context.VendasProdutos.Update(produto);
                else
                    context.VendasProdutos.Add(produto);

                context.SaveChanges();
            }
        }
    }
}
