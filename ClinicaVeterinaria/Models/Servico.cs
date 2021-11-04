using ClinicaVeterinaria.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;

namespace ClinicaVeterinaria.Models
{
    [Table("Servicos")]
    public class Servico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public decimal Valor { get; set; } = 0;
        public string Observacao { get; set; } = "";
        public bool Status { get; set; } = false;

        [Column("cliente_id")]
        public int ClienteId { get; set; } = 0;

        [Column("produto_id")]
        public int ProdutoId { get; set; } = 0;

        [Column("animal_id")]
        public int AnimalId { get; set; } = 0;

        [Column("funcionario_id")]
        public int FuncionarioId { get; set; } = 0;

        [Column("atendente_id")]
        public int AtendenteId { get; set; } = 0;

        public Nullable<DateTime> _dataInicio = DateTime.Now;
        public Nullable<DateTime> _dataFim = null;

        [Column("data_inicio")]
        public Nullable<DateTime> DataInicio {
            get { if (_dataInicio == null) return null; return Convert.ToDateTime(_dataInicio?.ToShortDateString() + " " + HoraInicio); }
            set { _dataInicio = value; }
        }

        [Column("data_fim")]
        public Nullable<DateTime> DataFim { 
            get { if (_dataFim == null) return null; return Convert.ToDateTime(_dataFim?.ToShortDateString() + " " + HoraFim); } 
            set { _dataFim = value; } 
        }

        [Column("data_criacao")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [NotMapped]
        public string HoraInicio { get; set; } = "00:00";
        [NotMapped]
        public string HoraFim { get; set; } = "00:00";
        public static object TSource { get; private set; }

        public static void Salvar(Servico servico)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (servico.Id > 0)
                    context.Servicos.Update(servico);
                else {
                    servico.Valor = Produto.BuscarPorId(servico.ProdutoId).Valor;
                    context.Servicos.Add(servico);
                }

                context.SaveChanges();
            }
        }

        public static List<Servico> BuscarServicos()
        {
            List<Servico> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Servicos.ToList();

            return registrosAtivos;
        }

        public static Servico BuscarPorId(int id)
        {
            Servico servico;

            using (ClinicaContext context = new ClinicaContext())
            {
                servico = context.Servicos.Find(id);
            }

            return servico;
        }

        public static List<ServicoDetalhes> BuscarServicosDetalhados()
        {
            List<Servico> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Servicos.Take(20).ToList();

            return ServicosToServicosDetalhadosList(registrosAtivos);
        }

        public static List<ServicoDetalhes> BuscarServicosDetalhados(Servico servico)
        {
            List<Servico> registrosAtivos;
            string qry = "";

            void AddSQL(string sql) {
                qry += qry.Length == 0 ? " WHERE " : " AND ";
                qry += sql;
            }

            if (servico.DataInicio != null) AddSQL($" data_inicio >= '{servico.DataInicio}'");
            if (servico.DataFim != null) AddSQL($" data_fim >= '{servico.DataFim}'");
            if (servico.AnimalId > 0) AddSQL($" animal_id = {servico.AnimalId} ");
            if (servico.ClienteId > 0) AddSQL($" cliente_id = {servico.ClienteId} ");
            if (servico.FuncionarioId > 0) AddSQL($" funcionario_id = {servico.FuncionarioId} ");

            qry = "SELECT TOP 20 * FROM servicos " + qry;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Servicos.FromSqlRaw(qry).ToList();
                
            return ServicosToServicosDetalhadosList(registrosAtivos);
        }

        private static List<ServicoDetalhes> ServicosToServicosDetalhadosList(List<Servico> servicos)
        {
            List<ServicoDetalhes> servicoDetalhes = new List<ServicoDetalhes>();

            for (int i = 0; i < servicos.Count; i++)
                servicoDetalhes.Add(new ServicoDetalhes(servicos[i]));

            return servicoDetalhes;
        }
    }
}
