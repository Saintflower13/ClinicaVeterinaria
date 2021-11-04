using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("formas_pagamento")]
    public class FormasPagamento : ICadastroBasicoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }

        public static void Salvar(FormasPagamento formaPagamento)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (formaPagamento.Id > 0)
                    context.FormasPgto.Update(formaPagamento);
                else
                    context.FormasPgto.Add(formaPagamento);

                context.SaveChanges();
            }
        }

        public static void Excluir(FormasPagamento formaPagamento)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                formaPagamento.Status = false;
                context.FormasPgto.Update(formaPagamento);
                context.SaveChanges();
            }
        }

        public static List<FormasPagamento> BuscarRegistroAtivos()
        {
            List<FormasPagamento> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.FormasPgto.Where(e => e.Status == true).OrderBy(e => e.Id).ToList();

            return registrosAtivos;
        }

        public static FormasPagamento BuscarPorId(int id)
        {
            FormasPagamento frmPgto;

            using (ClinicaContext context = new ClinicaContext())
                frmPgto = context.FormasPgto.Find(id);

            return frmPgto;
        }
    }
}
