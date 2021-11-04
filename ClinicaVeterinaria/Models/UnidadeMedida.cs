using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("unidade_medida")]
    public class UnidadeMedida : ICadastroBasicoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }

        public static void Salvar(UnidadeMedida unMedida)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (unMedida.Id > 0)
                    context.UnidadeMedidas.Update(unMedida);
                else
                    context.UnidadeMedidas.Add(new UnidadeMedida() { Descricao = unMedida.Descricao, Status = true});

                context.SaveChanges();
            }
        }

        public static void Excluir(UnidadeMedida unMedida)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                unMedida.Status = false;
                context.UnidadeMedidas.Update(unMedida);
                context.SaveChanges();
            }
        }

        public static List<UnidadeMedida> BuscarRegistroAtivos()
        {
            List<UnidadeMedida> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.UnidadeMedidas.Where(e => e.Status == true).OrderBy(e => e.Id).ToList();

            return registrosAtivos;
        }

        public static UnidadeMedida BuscarPorId(int id)
        {
            UnidadeMedida frmPgto;

            using (ClinicaContext context = new ClinicaContext())
                frmPgto = context.UnidadeMedidas.Find(id);

            return frmPgto;
        }
    }
}
