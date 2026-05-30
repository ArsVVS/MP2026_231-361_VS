using System.Collections.ObjectModel;
using System.Windows.Input;

namespace wpfTodoList
{
    internal class MainViewModel : ViewModelBase
    {

        //public List<string> Tasks { get; }
        public ObservableCollection<TodoItem> Todos { get; } = new();

        public string NewTitle { get; set => SetProperty(ref field, value); }
        public TodoItem? SelectedTodo { get; set => SetProperty(ref field, value); }

        public ICommand AddTodoCommand { get; }
        public ICommand RemoveTodoCommand { get; }
        public ICommand RemoveDoneTodoCommand { get; }
        public ICommand ToggleTodoCommand { get; }

        public MainViewModel()
        {
            Todos.Add(new TodoItem { Title = "Задача 1" });
            Todos.Add(new TodoItem { Title = "Задача 2", IsDone = true });
            Todos.Add(new TodoItem { Title = "Задача 3" });
            Todos.Add(new TodoItem { Title = "Задача 4", IsDone = true });

            AddTodoCommand = new RelayCommand(_ => AddTodo(), _ => CanAddTodo());
            RemoveTodoCommand = new RelayCommand(_ => RemoveTodo(), _ => SelectedTodo != null);
            RemoveDoneTodoCommand = new RelayCommand(_ => RemoveDoneTodo());
            ToggleTodoCommand = new RelayCommand(_ => ToggleTodo(), _ => SelectedTodo != null);
        }

        private void ToggleTodo()
        {
            if (SelectedTodo != null)
                SelectedTodo.IsDone = !SelectedTodo.IsDone;
        }

        private void RemoveDoneTodo()
        {
            for (int i = Todos.Count - 1; i >= 0; i--)
                if (Todos[i].IsDone)
                    Todos.RemoveAt(i);
        }

        private void RemoveTodo()
        {
            if (SelectedTodo != null)
                Todos.Remove(SelectedTodo);
        }

        private bool CanAddTodo() => !string.IsNullOrWhiteSpace(NewTitle);

        private void AddTodo()
        {
            Todos.Add(new TodoItem { Title = NewTitle, IsDone = false });
            NewTitle = "";
        }
    }
}