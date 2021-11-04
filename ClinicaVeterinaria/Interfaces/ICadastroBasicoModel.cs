namespace ClinicaVeterinaria.Interfaces
{
    public interface ICadastroBasicoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
    }
}
