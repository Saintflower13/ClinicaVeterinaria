using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    [Table("animais_tipo")]
    public class AnimalEspecie : ICadastroBasicoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }

        public static void Salvar(AnimalEspecie animalEspecie)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (animalEspecie.Id > 0)
                    context.AnimaisEspecies.Update(animalEspecie);
                else
                    context.AnimaisEspecies.Add(animalEspecie);

                context.SaveChanges();
            }
        }

        public static void Excluir(AnimalEspecie animalEspecie)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                animalEspecie.Status = false;
                context.AnimaisEspecies.Update(animalEspecie);
                context.SaveChanges();
            }
        }

        public static List<AnimalEspecie> BuscarRegistroAtivos()
        {
            List<AnimalEspecie> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.AnimaisEspecies.Where(e => e.Status == true).OrderBy(e => e.Descricao).ToList();

            return registrosAtivos;
        }

        public static AnimalEspecie BuscarPorId(int id)
        {
            AnimalEspecie animalEspecie;

            using (ClinicaContext context = new ClinicaContext())
                animalEspecie = context.AnimaisEspecies.Find(id);

            return animalEspecie;
        }
    }
}
