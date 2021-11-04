using ClinicaVeterinaria.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("produtos")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public bool Tipo { get; set; } = true;
        public string Descricao { get; set; } = "";
        public decimal Valor { get; set; } = 0;
        public bool Status { get; set; } = true;

        [Column("fornecedor_id")]
        public int FornecedorId { get; set; } = 0;

        [Column("categoria_id")]
        public int CategoriaId { get; set; } = 0;

        [Column("un_medida_id")]
        public int UnMedidaId { get; set; } = 0;

        [Column("funcionario_tipo_id")]
        public int FuncionarioTipoId { get; set; } = 0;

        public void Salvar(Produto produto)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (produto.Id > 0)
                    context.Produtos.Update(produto);
                else
                    context.Produtos.Add(produto);

                context.SaveChanges();
            }
        }

        public static Produto BuscarPorId(int id)
        {
            Produto produto;

            using (ClinicaContext context = new ClinicaContext())
                produto = context.Produtos.Find(id);

            return produto;
        }

        public static List<Produto> BuscarProdutosAtivos()
        {
            List<Produto> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Produtos.Where(e => e.Status == true).Take(100).OrderBy(e => e.Descricao).ToList();

            return registrosAtivos;
        }

        public static List<Produto> BuscarServicosAtivos()
        {
            List<Produto> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Produtos.Where(e => e.Status == true && e.Tipo == false).Take(100).OrderBy(e => e.Descricao).ToList();

            return registrosAtivos;
        }

        public static List<Produto> BuscarPorDescricaoEId(string produtoBuscar)
        {
            List<Produto> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
            {
                registrosAtivos = context.Produtos
                                    .Where(e => e.Status == true &&
                                        (e.Descricao.Contains(produtoBuscar) || e.Id.ToString() == produtoBuscar))
                                    .Take(100)
                                    .OrderBy(e => e.Descricao)
                                    .ToList();
            }

            return registrosAtivos;
        }
    }
}
