using System;
using System.Windows.Input;

namespace Axen.Minecraft.Launcher.Utils.DataType
{
    public class DelegateCommand : ICommand
    {
        private readonly Predicate<object> _canExecuteHandler;
        private readonly Action<object> _executeHandler;

        public DelegateCommand(Action<object> executeHandler, Predicate<object> canExecuteHandler)
        {
            _executeHandler = executeHandler;
            _canExecuteHandler = canExecuteHandler;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (_canExecuteHandler != null)
                return _canExecuteHandler(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            if (CanExecute(parameter)) _executeHandler(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}