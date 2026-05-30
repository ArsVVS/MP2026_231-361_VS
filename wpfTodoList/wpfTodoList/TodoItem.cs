namespace wpfTodoList
{
    internal class TodoItem : ViewModelBase
    {
        public string? Title { get; set => SetProperty(ref field, value); }
        public bool IsDone { get; set => SetProperty(ref field, value); } = false;
    }
}