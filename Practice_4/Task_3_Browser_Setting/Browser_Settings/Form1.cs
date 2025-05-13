using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser_Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string selectedSettings = "Обрані налаштування браузера:\n";

            // Перевіряємо вибрані елементи в CheckedListBox
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedSettings += item.ToString() + "\n";
            }

            // Якщо не вибрано жодного елемента
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                selectedSettings = "Не вибрано жодного параметра.";
            }

            // Виводимо результат у текстове поле
            txtResult.Text = selectedSettings;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Увімкнути рекламу");
            checkedListBox1.Items.Add("Зберігати паролі");
            checkedListBox1.Items.Add("Зберігати історію браузера");
            checkedListBox1.Items.Add("Використовувати приватний режим");
            checkedListBox1.Items.Add("Включити автоматичне оновлення");
        }
    }
}
