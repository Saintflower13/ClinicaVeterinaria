using ClinicaVeterinaria.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("fornecedores")]
    public class Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public string Telefone { get; set; } = "";
        public string Email { get; set; } = "";
        public bool Status { get; set; } = true;

        private string _cnpj = "";
        public string CNPJ { 
            get { return _cnpj.Replace("-", "").Replace(".", ""); } 
            set { _cnpj = value; } 
        }

        [Column("razao_social")]
        public string RazaoSocial { get; set; } = "";

        [Column("nome_fantasia")]
        public string NomeFantasia { get; set; } = "";

        [Column("inscricao_estadual")]
        public string InscricaoEstadual { get; set; } = "";

        [Column("end_logradouro")]
        public string EndLogradouro { get; set; } = "";

        [Column("end_numero")]
        public string EndNumero { get; set; } = "0";

        [Column("end_bairro")]
        public string EndBairro { get; set; } = "";

        [Column("end_cidade")]
        public string EndCidade { get; set; } = "";

        private string _cep = "";
        [Column("end_cep")]
        public string EndCEP
        {
            get { return _cep.Replace("-", ""); }
            set { _cep = value; }
        }

        [Column("end_estado")]
        public int EndEstadoId { get; set; } = 23; // SP

        public void Salvar(Fornecedor fornecedor)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (fornecedor.Id > 0)
                    context.Fornecedores.Update(fornecedor);
                else
                    context.Fornecedores.Add(fornecedor);

                context.SaveChanges();
            }
        }

        public static Fornecedor BuscarPorId(int id)
        {
            Fornecedor fornecedor;

            using (ClinicaContext context = new ClinicaContext())
                fornecedor = context.Fornecedores.Find(id);

            return fornecedor;
        }

        public static List<Fornecedor> BuscarFornecedoresAtivos()
        {
            List<Fornecedor> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Fornecedores.Where(e => e.Status == true).Take(100).OrderBy(e => e.RazaoSocial).ToList();

            return registrosAtivos;
        }

        public static List<Fornecedor> BuscarFornecedorPorRazaoSocialENomeFantasia(string fornecedorBuscar)
        {
            List<Fornecedor> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
            {
                registrosAtivos = context.Fornecedores
                                    .Where(e => e.Status == true &&
                                        (e.RazaoSocial.Contains(fornecedorBuscar) || e.NomeFantasia.Contains(fornecedorBuscar)))
                                    .Take(100)
                                    .OrderBy(e => e.RazaoSocial)
                                    .ToList();
            }

            return registrosAtivos;
        }
    }
}
