using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication_type_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbMonth.Items.Add("Січень");
            cbMonth.Items.Add("Лютий");
            cbMonth.Items.Add("Березень");
            cbMonth.Items.Add("Квітень");
            cbMonth.Items.Add("Травень");
            cbMonth.Items.Add("Червень");
            cbMonth.Items.Add("Липень");
            cbMonth.Items.Add("Серпень");
            cbMonth.Items.Add("Вересень");
            cbMonth.Items.Add("Жовтень");
            cbMonth.Items.Add("Листопад");
            cbMonth.Items.Add("Грудень");

            // Додаємо міста у ComboBox для вибору міста народження
            cbCity.Items.Add("Київ");
            cbCity.Items.Add("Львів");
            cbCity.Items.Add("Одеса");
            cbCity.Items.Add("Харків");
            cbCity.Items.Add("Дніпро");

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // Перевірка вибору статі
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Будь ласка, виберіть стать.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка вибору дати народження
            if (nudYear.Value == 0 || cbMonth.SelectedIndex == -1 || nudDay.Value == 0)
            {
                MessageBox.Show("Будь ласка, виберіть дату народження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка вибору міста народження
            if (cbCity.SelectedIndex == -1)
            {
                MessageBox.Show("Будь ласка, виберіть місто народження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int year = (int)nudYear.Value;
            string month = cbMonth.SelectedItem.ToString();
            int day = (int)nudDay.Value;

            string gender = rbMale.Checked ? "Чоловік" : "Жінка";
            string city = cbCity.SelectedItem.ToString();  // Отримання вибраного міста

            // Формування результату
            string birthDate = $"{day}/{month}/{year}";

            // Виведення результату
            txtResult.Text = $"Дата народження: {birthDate}\nСтать: {gender}\nМісто народження: {city}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
