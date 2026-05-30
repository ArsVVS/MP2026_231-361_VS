using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace wpfViewModel
{
    internal class MainViewModel_v2 : INotifyPropertyChanged
    {
        private string? firstName;
        public string? FirstName
        {
            get => firstName;
            set
            {
                if (firstName == value) return;
                firstName = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }


        public string? LastName
        {
            get;
            set
            {
                if (field == value) return;
                field = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public int? Age
        {
            get;
            set
            {
                if (field == value) return;
                field = value;
                OnPropertyChanged();
            }
        }
        public string FullName => $"{FirstName} {LastName}";

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}