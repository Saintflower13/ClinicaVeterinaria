using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("funcionarios_funcoes")]
    public class FuncionarioFuncao : ICadastroBasicoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }

        public static void Salvar(FuncionarioFuncao funcionarioFuncao)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (funcionarioFuncao.Id > 0)
                    context.FuncionariosFuncoes.Update(funcionarioFuncao);
                else
                    context.FuncionariosFuncoes.Add(funcionarioFuncao);

                context.SaveChanges();
            }
        }

        public static void Excluir(FuncionarioFuncao funcionarioFuncao)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                funcionarioFuncao.Status = false;
                context.FuncionariosFuncoes.Update(funcionarioFuncao);
                context.SaveChanges();
            }
        }

        public static List<FuncionarioFuncao> BuscarRegistroAtivos()
        {
            List<FuncionarioFuncao> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.FuncionariosFuncoes.Where(e => e.Status == true).OrderBy(e => e.Descricao).ToList();

            return registrosAtivos;
        }

        public static FuncionarioFuncao BuscarPorId(int id)
        {
            FuncionarioFuncao funcionarioFuncao;

            using (ClinicaContext context = new ClinicaContext())
                funcionarioFuncao = context.FuncionariosFuncoes.Find(id);

            return funcionarioFuncao;
        }
    }
}
