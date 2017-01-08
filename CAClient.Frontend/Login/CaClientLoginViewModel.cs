using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace CAClient.Frontend.Login
{
    public class CaClientLoginViewModel : ViewModelBase
    {
        public ICommand LoginCommand
        {
            get { return new RelayCommand(ValidateLogin, CanValidateLogin); }
        }

        private bool CanValidateLogin()
        {
            return true;
        }

        private void ValidateLogin()
        {
            bool isValidated = true;
            if (isValidated)
                LaunchMainWindow();
        }

        private void LaunchMainWindow()
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = mainWindowViewModel;
            var loginWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            mainWindow.Show();
            loginWindow.Close();
        }
    }
}
