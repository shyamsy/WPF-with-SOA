using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CAClient.Frontend.MvvmBase
{
    public class RelayCommand : ICommand
    {
        Func<bool> canExecute;
        Action commandTask;

        public RelayCommand(Action workToDo, Func<bool> execute)
        {
            this.commandTask = workToDo;
            canExecute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            commandTask();
        }
    }
}
