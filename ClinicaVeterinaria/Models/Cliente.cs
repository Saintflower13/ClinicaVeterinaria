using ClinicaVeterinaria.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Sobrenome { get; set; } = "";
        public string CPF { get; set; } = "";
        public string RG { get; set; } = "";
        public string Email { get; set; } = "";
        public string Telefone { get; set; } = "";
        public bool Status { get; set; } = true;
        public string NomeCompleto { get { return $"{Nome} {Sobrenome}"; } }

        [Column("end_logradouro")]
        public string EndLogradouro { get; set; } = "";

        [Column("end_numero")]
        public int EndNumero { get; set; } = 0;

        [Column("end_bairro")]
        public string EndBairro { get; set; } = "";

        [Column("end_cidade")]
        public string EndCidade { get; set; } = "";

        [Column("end_cep")]
        public string EndCEP { get; set; } = "";

        [Column("end_estado")]
        public int EndEstadoIndex { get; set; } = 23;

        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public void Salvar(Cliente cliente)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (cliente.Id > 0)
                    context.Clientes.Update(cliente);
                else
                    context.Clientes.Add(cliente);

                context.SaveChanges();
            }
        }

        public static Cliente BuscarPorId(int id)
        {
            Cliente cliente;

            using (ClinicaContext context = new ClinicaContext())
                cliente = context.Clientes.Find(id);

            return cliente;
        }

        public static List<Cliente> BuscarClientesAtivos()
        {
            List<Cliente> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Clientes.Where(e => e.Status == true).Take(100).OrderBy(e => e.Nome).ToList();

            return registrosAtivos;
        }

        public static List<Cliente> BuscarClientesPorNomeECNPJ(string clienteBuscar)
        {
            List<Cliente> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
            {
                registrosAtivos = context.Clientes
                                    .Where(e => e.Status == true &&
                                        (e.Nome.Contains(clienteBuscar) || e.CPF == clienteBuscar))
                                    .Take(100)
                                    .OrderBy(e => e.Nome)
                                    .ToList();
            }

            return registrosAtivos;
        }
    }
}
