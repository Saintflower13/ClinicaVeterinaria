using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Enums;
using ClinicaVeterinaria.Models;
using ClinicaVeterinaria.Utils;
using System.Windows;
using System.Windows.Controls;

namespace ClinicaVeterinaria.Views
{
    public partial class ClienteExpandidoView : Window
    {
        public ClienteExpandidoController Controller { get; set; }

        public ClienteExpandidoView(object clienteEditar)
        {
            InitializeComponent();
            Controller = new ClienteExpandidoController(clienteEditar);
            ConfigurarTela();
        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteCadastroView clienteCadastroView = new ClienteCadastroView(Controller.Cliente);
            clienteCadastroView.ShowDialog();
            Controller.AtualizarCliente();
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            CarregarClienteInformacoes();
            CarregarAnimais();
        }

        private void CarregarAnimais()
        {
            spnAnimais.Children.Clear();
            var animais = Controller.BuscarAnimaisCliente();

            foreach (Animal animal in animais)
                CriarLinhaAnimal(animal);
        }

        private void CriarLinhaAnimal(Animal animal)
        { 
            var txt = new TextBlock();
            txt.PreviewMouseDown += Animal_Click;
            txt.Text = $"{animal.Nome} - {AnimalEspecie.BuscarPorId(animal.AnimalEspecieId).Descricao} - ";
            txt.Text += animal.Sexo ? "Macho" : "Fêmea";
            txt.Tag = animal;
            txt.Height = 30;

            if (!string.IsNullOrWhiteSpace(animal.Pelagem))
                txt.Text += $" - {animal.Pelagem}";
          
            spnAnimais.Children.Add(txt);
        }

        private void CarregarClienteInformacoes()
        {
            string cpf = string.IsNullOrEmpty(Controller.Cliente.CPF.Trim()) ? 
                FormataString.StringVazia(Controller.Cliente.CPF) : FormataString.CPF(Controller.Cliente.CPF);
            string rg = string.IsNullOrEmpty(Controller.Cliente.RG.Trim()) ? 
                FormataString.StringVazia(Controller.Cliente.RG) : FormataString.RG(Controller.Cliente.RG);

            txtNome.Text = $"Nome: {FormataString.StringVazia(Controller.Cliente.NomeCompleto)}";
            txtTelefone.Text = $"Telefone: {FormataString.StringVazia(Controller.Cliente.Telefone)}";
            txtEmail.Text = $"Email: {FormataString.StringVazia(Controller.Cliente.Email)}";
            txtCPF.Text = $"CPF: {cpf}";
            txtRG.Text = $"RG: {rg}";

            txtEnderecoLinha1.Text = $"{FormataString.StringVazia(Controller.Cliente.EndLogradouro)}, {Controller.Cliente.EndNumero} - " +
                $"{FormataString.StringVazia(Controller.Cliente.EndBairro)}";
            txtEnderecoLinha2.Text = $"{FormataString.StringVazia(Controller.Cliente.EndCidade)} - " +
               $"{(Estados)Controller.Cliente.EndEstadoIndex}";
        }

        private void Animal_Click(object sender, RoutedEventArgs e)
        {
            object animal = (sender as TextBlock).Tag;

            if (animal == null) return;

            AnimalCadastroView animalCadastroView = new AnimalCadastroView(animal);
            animalCadastroView.ShowDialog();
            CarregarAnimais();
        }
    }
}
