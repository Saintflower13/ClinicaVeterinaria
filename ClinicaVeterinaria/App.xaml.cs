using ClinicaVeterinaria.Views;
using System.Threading.Tasks;
using System.Windows;

namespace ClinicaVeterinaria
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var splashScreen = new SplashScreenView();
            this.MainWindow = splashScreen;
            splashScreen.Show();

            CarregarDadosIniciais(splashScreen);
        }

        private async Task CarregarDadosIniciais(SplashScreenView splashScreen)
        {
            await Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    System.Threading.Thread.Sleep(20);
                    splashScreen.Dispatcher.Invoke(() => splashScreen.Progress = i);
                }

                this.Dispatcher.Invoke(() =>
                {
                    var mainWindow = new LoginView();
                    this.MainWindow = mainWindow;
                    mainWindow.Show();
                    splashScreen.Close();
                });
            });
        }
    }
}
