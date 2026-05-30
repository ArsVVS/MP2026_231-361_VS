using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace wpfViewModel
{
    internal class MainViewModel_v4 : ViewModelBase
    {
        public string? FirstName
        {
            get;
            set
            {
                //if (field == value) return;
                //field = value;
                //OnPropertyChanged();
                if (!SetProperty(ref field, value)) return;
                OnPropertyChanged(nameof(FullName));
            }
        }


        public string? LastName
        {
            get;
            set
            {
                if (!SetProperty(ref field, value)) return;
                OnPropertyChanged(nameof(FullName));
            }
        }
        public int? Age { get; set => SetProperty(ref field, value); }

        public string FullName => $"{FirstName} {LastName}";
    }
}