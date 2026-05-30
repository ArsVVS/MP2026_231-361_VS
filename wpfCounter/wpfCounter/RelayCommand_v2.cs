using System.Windows.Input;

namespace wpfCounter
{
    internal class RelayCommand_v2(Action<object?> execute, Predicate<object?>? canExecute = null) : ICommand
    {

        public event EventHandler? CanExecuteChanged;
        
        public bool CanExecute(object? parameter) => canExecute == null || canExecute.Invoke(parameter);

        public void Execute(object? parameter) => execute?.Invoke(parameter);

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}