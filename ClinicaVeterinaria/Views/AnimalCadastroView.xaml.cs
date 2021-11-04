using ClinicaVeterinaria.Controllers;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ClinicaVeterinaria.Views
{
    public partial class AnimalCadastroView : Window
    {
        public AnimalCadastroController Controller { get; set; }

        public AnimalCadastroView()
        {
            InitializeComponent();
            Controller = new AnimalCadastroController();
            ConfigurarTela();
        }

        public AnimalCadastroView(object animal)
        {
            InitializeComponent();
            Controller = new AnimalCadastroController(animal);
            ConfigurarTela();
        }

        private void tgbStatus_Check(object sender, RoutedEventArgs e)
        {
            tgbStatus.Content = tgbStatus.IsChecked == true ? "Vivo" : "Óbito";
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (Controller.BtnSalvar())
                this.Close();
        }

        private void ConfigurarTela()
        {
            this.DataContext = this;
            rbFemea.IsChecked = !rbMacho.IsChecked;
            txtNomeAnimal.Text = Controller.Animal.Id > 0 ?  Controller.Animal.Nome : "Novo Animal";
        }
    }
}
