using System.Collections.ObjectModel;
using System.ComponentModel;
using PetStoreApp.Models;
using PetStoreApp.Commands;

namespace PetStoreApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Animal> Animals { get; set; } = new ObservableCollection<Animal>();

        public RelayCommand AddAnimalCommand { get; set; }

        public MainViewModel()
        {
            AddAnimalCommand = new RelayCommand(() =>
            {
                Animals.Add(new Animal { Name = "Кіт", Species = "Котячі" });
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
