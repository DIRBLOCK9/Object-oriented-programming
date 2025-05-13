using Lab7.Data;
using Lab7.Models;
using Microsoft.UI.Xaml;
using System.Linq;
using System.Windows;

namespace Lab7
{
    public partial class MainWindow : Window
    {
        private AppDbContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            AnimalList.ItemsSource = _context.Animals.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var animal = new Animal
            {
                Name = NameBox.Text,
                Species = SpeciesBox.Text,
                Price = decimal.Parse(PriceBox.Text),
                Stock = int.Parse(StockBox.Text)
            };

            _context.Animals.Add(animal);
            _context.SaveChanges();
            LoadAnimals();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (AnimalList.SelectedItem is Animal selected)
            {
                _context.Animals.Remove(selected);
                _context.SaveChanges();
                LoadAnimals();
            }
        }
    }
}
