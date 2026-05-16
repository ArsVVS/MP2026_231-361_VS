using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private List<MyTask> listTasks;
        private ObservableCollection<MyTask> listTasks;
        MyTask newTask = new();
        public MainWindow()
        {
            InitializeComponent();

            List<string> listPhones = new() { "iphone 13", "samsung", "honor" };
            lbPhones.ItemsSource = listPhones;

            listTasks = new()
            {
                new() {Name="Открыть ноутбук", Description="Свой ноутбук", Priority=1},
                new() {Name="Выполнить ДЗ", Priority=1},
                new() {Name="Закрыть ноутбук", Description="Выключить", Priority=5},
            };
            lbTasks.ItemsSource = listTasks;
            stackPanelAdd.DataContext = newTask;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listTasks.Add(new() { Name = newTask.Name, Description = newTask.Description, Priority = newTask.Priority });
            MessageBox.Show("!");
        }
    }

    internal class MyTask
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Priority {  get; set; }
    }
}