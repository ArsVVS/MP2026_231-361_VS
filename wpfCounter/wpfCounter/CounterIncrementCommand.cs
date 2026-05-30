using System.Windows.Input;

namespace wpfCounter
{
    internal class CounterIncrementCommand(MainViewModel mainViewModel) : ICommand
    {
        private MainViewModel mainViewModel = mainViewModel;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => mainViewModel.Counter++;
    }
}