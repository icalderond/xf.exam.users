using System;
using System.Windows.Input;

namespace xf.exam.users.ViewModels
{
    public class ActionCommand<T> : ICommand
    {
        readonly Action<T> Action;
        public ActionCommand(Action<T> _action)
        {
            this.Action = _action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Action((T)parameter);
        }
    }
}
