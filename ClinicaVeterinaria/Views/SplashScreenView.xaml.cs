using System;
using System.Windows;

namespace ClinicaVeterinaria.Views
{
    public partial class SplashScreenView : Window
    {
        public SplashScreenView()
        {
            InitializeComponent();
        }

        public double Progress
        {
            get { return progressBar.Value; }
            set { progressBar.Value = value; txt.Text = $"{value}%"; }
        }
    }
}
