using System.Windows.Input;

namespace wpfTodoList
{
    internal class RelayCommand(Action<object?> execute, Predicate<object?>? canExecute = null) : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public void Execute(object? parameter) => execute?.Invoke(parameter);  
        public bool CanExecute(object? parameter) => canExecute == null || canExecute.Invoke(parameter);

    }
}