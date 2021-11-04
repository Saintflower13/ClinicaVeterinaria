using ClinicaVeterinaria.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("funcionarios")]
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Tipo { get; set; } = false;
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; } = true;

        [Column("funcao_id")]
        public int FuncaoId { get; set; }

        [Column("nome_completo")]
        public string NomeCompleto { get; set; }

        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; }

        public void Salvar(Funcionario funcionario)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (funcionario.Id > 0)
                    context.Funcionarios.Update(funcionario);
                else
                    context.Funcionarios.Add(funcionario);

                context.SaveChanges();
            }
        }

        public static Funcionario BuscarPorId(int id)
        {
            Funcionario funcionario;

            using (ClinicaContext context = new ClinicaContext())
                funcionario = context.Funcionarios.Find(id);

            return funcionario;
        }

        public static List<Funcionario> BuscarFuncionariosAtivos()
        {
            List<Funcionario> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Funcionarios.Where(e => e.Status == true).Take(100).OrderBy(e => e.NomeCompleto).ToList();

            return registrosAtivos;
        }

        public static List<Funcionario> BuscarFuncionariosPorNomeEUsuario(string funcionarioBuscar)
        {
            List<Funcionario> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
            {
                registrosAtivos = context.Funcionarios
                                    .Where(e => e.Status == true && 
                                        (e.NomeCompleto.Contains(funcionarioBuscar) || e.Usuario.Contains(funcionarioBuscar)))
                                    .Take(100)
                                    .OrderBy(e => e.NomeCompleto)
                                    .ToList();

                return registrosAtivos;
            }
        }

        public static Funcionario Logar(string usuario, string senha)
        {
            Funcionario funcionario = null;

            using (ClinicaContext context = new ClinicaContext())
            {
                try { funcionario = context.Funcionarios.Where(e => e.Usuario == usuario && e.Senha == senha).First();
                } catch { funcionario = null; }
            }

            return funcionario;
        }
    }
}
