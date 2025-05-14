using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RecipeApp;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControlAnimals.TabPages.Clear();
            foreach (var animal in _context.Animals)
            {
                var item = new ListViewItem(animal.Name);
                item.SubItems.Add(animal.Species);
                item.SubItems.Add(animal.Price.ToString("C"));
                item.SubItems.Add(animal.Stock.ToString());
                tabControlAnimals.TabPages.Add(tabPage1);
            }
        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var animal = new Animal
            {
                Name = !string.IsNullOrEmpty(txtName.Text) ? txtName.Text : "Unknown",
                Species = cbSpecies.SelectedItem?.ToString() ?? "Unknown",
                Price = numPrice.Value,
                Stock = (int)numStock.Value
            };

            _context.Animals.Add(animal);
            _context.SaveChanges(); // ✅ Зберігає до бази
            LoadAnimals();          // 🔄 Оновлює список
            LoadAnimalsToGrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAnimals.SelectedItem is Animal selectedAnimal)
            {
                _context.Animals.Remove(selectedAnimal);
                _context.SaveChanges();
                LoadAnimals();

                UpdateAllViews();
                ClearForm();
                selectedIndex = -1;
                LoadAnimalsToGrid();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxAnimals.SelectedItem is Animal selectedAnimal)
            {
                selectedAnimal.Name = txtName.Text;
                selectedAnimal.Species = cbSpecies.SelectedItem?.ToString() ?? "Unknown";  // перевірка на null
                selectedAnimal.Price = numPrice.Value;
                selectedAnimal.Stock = (int)numStock.Value;

                _context.SaveChanges();
                LoadAnimals();
                UpdateAllViews();
                ClearForm();
                LoadAnimalsToGrid();

            }
        }

        private void UpdateAllViews()
        {
            lbAnimals.Items.Clear();
            listView1.Items.Clear();
            dgvAnimals.Rows.Clear();

            foreach (var animal in animals)
            {
                // ListBox
                lbAnimals.Items.Add(animal);

                // ListView
                var listItem = new ListViewItem(animal.Name);
                listItem.SubItems.Add(animal.Price.ToString("C"));
                listItem.SubItems.Add(animal.Species);
                listItem.SubItems.Add(animal.Stock.ToString());
                listView1.Items.Add(listItem);

                // DataGridView
                dgvAnimals.Rows.Add(animal.Name, animal.Price, animal.Species, animal.Stock);
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            cbSpecies.SelectedIndex = 0; // або -1, якщо хочеш очистити
            numPrice.Value = 0;
            numStock.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            if (!_context.Animals.Any())
            {
                _context.Animals.AddRange(
                    new Animal { Name = "Барсик", Species = "Кішка", Price = 300, Stock = 5 },
                    new Animal { Name = "Рекс", Species = "Собака", Price = 500, Stock = 2 }
                );
                _context.SaveChanges();

            }



            LoadAnimals();
            cbSpecies.Items.AddRange(new string[] { "Кішка", "Собака", "Папуга", "Рибка" });
            cbSpecies1.SelectedIndex = 0;
            LoadAnimalsToGrid(); // Додаємо сюди

        }
        private void LoadAnimals()
        {
            listBoxAnimals.DataSource = null;
            listBoxAnimals.DataSource = _context.Animals.ToList();
            listBoxAnimals.DisplayMember = "Name";


        }

        private List<Animal> animals = new List<Animal>();
        private int selectedIndex = -1;

        private void listBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAnimals.SelectedItem is Animal selected)
            {
                txtName.Text = selected.Name;
                cbSpecies.SelectedItem = selected.Species;
                numPrice.Value = selected.Price;
                numStock.Value = selected.Stock;
            }
        }



        private void dgvAnimals_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvAnimals.ColumnCount = 4;
            dgvAnimals.Columns[0].Name = "Ім’я";
            dgvAnimals.Columns[1].Name = "Ціна";
            dgvAnimals.Columns[2].Name = "Вид";
            dgvAnimals.Columns[3].Name = "Кількість";
        }


        private void LoadAnimalsToGrid()
        {
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = _context.Animals.ToList();
        }

        private void CustomizeGrid()
        {
            dgvAnimals.Columns["Id"].Visible = false; // якщо не треба бачити ID
            dgvAnimals.Columns["Name"].HeaderText = "Ім'я";
            dgvAnimals.Columns["Species"].HeaderText = "Вид";
            dgvAnimals.Columns["Price"].HeaderText = "Ціна";
            dgvAnimals.Columns["Stock"].HeaderText = "Кількість";
        }


        private void cbSpecies1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

