using ClinicaVeterinaria.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ClinicaVeterinaria.Models
{
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Pelagem { get; set; } = "";
        public bool Sexo { get; set; } = true;
        public bool Status { get; set; } = true;

        [Column("cliente_id")]
        public int ClienteId { get; set; } = 0;

        [Column("tipo_animal")]
        public int AnimalEspecieId { get; set; } = 0;

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; } = DateTime.Now;

        public void Salvar(Animal animal)
        {
            using (ClinicaContext context = new ClinicaContext())
            {
                if (animal.Id > 0)
                    context.Animais.Update(animal);
                else
                    context.Animais.Add(animal);

                context.SaveChanges();
            }
        }

        public static Animal BuscarPorId(int id)
        {
            Animal animal;

            using (ClinicaContext context = new ClinicaContext())
                animal = context.Animais.Find(id);

            return animal;
        }

        public static List<Animal> BuscarPorClienteId(int id)
        {
            List<Animal> animal;

            using (ClinicaContext context = new ClinicaContext())
                animal = context.Animais
                    .Where(e => e.Status == true && e.ClienteId == id).OrderBy(e => e.Nome).ToList();

            return animal;
        }

        public static List<Animal> BuscarAnimaisAtivos()
        {
            List<Animal> registrosAtivos;

            using (ClinicaContext context = new ClinicaContext())
                registrosAtivos = context.Animais.Where(e => e.Status == true).Take(100).OrderBy(e => e.Nome).ToList();

            return registrosAtivos;
        }

        public override string ToString()
        {
            return Nome;
        }
        /*
        public static List<Cliente> BuscarAnimalPorNomeECliente(string clienteBuscar)
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
        }*/
    }
}
