using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gusev_ITMO_WPF_Final_Exercise
{
    class RelayCommand:ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object,bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            //add => CommandManager.RequerySuggested += value;
            add
            {
                CommandManager.RequerySuggested += value;
            }
           // remove => CommandManager.RequerySuggested -= value;
            remove
            {
            CommandManager.RequerySuggested -= value;
            }
        }

        public RelayCommand(Action<object> Execute, Func<object,bool> CanExecute = null)
        {
            //execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            if (Execute == null)
            {
                throw new ArgumentNullException("Какой-то вызываемый метод");
            }
            else
            {
                execute = Execute;
            }
            canExecute = CanExecute;
        }

        // public bool CanExecute(object parameter) => canExecute?.Invoke(parameter) ?? true;
        public bool CanExecute(object parameter)
        {
            if (canExecute(parameter) == null) 
            return true;
            return canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
