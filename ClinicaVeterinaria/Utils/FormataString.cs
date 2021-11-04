namespace ClinicaVeterinaria.Utils
{
    public static class FormataString
    {
        public static string StringVazia(string str, string strPadrao = "Não Informado")
        {
            return string.IsNullOrWhiteSpace(str) ? strPadrao : str;
        }

        public static string CPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf)) return "";

            cpf = cpf.Replace(".", "").Replace("-", "").Trim();
            return cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
        }

        public static string RG(string rg)
        {
            if (string.IsNullOrWhiteSpace(rg)) return "";

            rg = rg.Replace(".", "").Trim();
            return rg.Insert(2, ".").Insert(6, ".").Insert(10, "-");
        }
    }
}
