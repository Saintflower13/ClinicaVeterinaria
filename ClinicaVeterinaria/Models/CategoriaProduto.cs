using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("categorias_produtos")]
    public class CategoriaProduto : ICadastroBasicoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }

        [Column("tipo_produto")]
        public bool TipoProduto { get; set; }

        public CategoriaProduto()
        {
            TipoProduto = ProdutoTipo.Produto;
        }

        public CategoriaProduto(bool produtoTipo)
        {
            TipoProduto = produtoTipo;
        }

        public static void Salvar(CategoriaProduto categoriaProduto)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (categoriaProduto.Id > 0)
                    context.CategoriaProdutos.Update(categoriaProduto);
                else
                    context.CategoriaProdutos.Add(categoriaProduto);

                context.SaveChanges();
            }
        }

        public static void Excluir(CategoriaProduto categoriaProduto)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                categoriaProduto.Status = false;
                context.CategoriaProdutos.Update(categoriaProduto);
                context.SaveChanges();
            }
        }

        public static List<CategoriaProduto> BuscarRegistroAtivos(bool produtoTipo = ProdutoTipo.Produto)
        {
            List<CategoriaProduto> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.CategoriaProdutos
                                    .Where(e => e.Status == true && e.TipoProduto == produtoTipo)
                                    .OrderBy(e => e.Descricao)
                                    .ToList();

            return registrosAtivos;
        }

        public static CategoriaProduto BuscarPorId(int id)
        {
            CategoriaProduto CategoriaProduto;

            using (ClinicaContext context = new ClinicaContext())
                CategoriaProduto = context.CategoriaProdutos.Find(id);

            return CategoriaProduto;
        }
    }
}
