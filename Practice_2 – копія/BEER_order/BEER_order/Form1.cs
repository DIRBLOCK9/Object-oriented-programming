using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEER_order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Перевірка на наявність товарів у замовленні
            if (nudDarkBeerQty.Value == 0 && nudLightBeerQty.Value == 0 && nudChipsQty.Value == 0 && nudFishQty.Value == 0)
            {
                MessageBox.Show("Будь ласка, додайте товари до замовлення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Оновлення ціни, якщо товари додані
                UpdateTotalPrice(sender, e);

                // Отримуємо поточний текст з поля txtTotalPrice (який містить суму)
                string totalPriceMessage = txtTotalPrice.Text;

                // Показуємо вікно з підтвердженням замовлення та сумою
                MessageBox.Show($"Замовлення успішно оформлено! на суму: {totalPriceMessage}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nudDarkBeerQty.Value = 0;
            nudLightBeerQty.Value = 0;
            nudChipsQty.Value = 0;
            nudFishQty.Value = 0;

            txtTotalPrice.Text = "0 грн";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateTotalPrice(object sender, EventArgs e)
        {
            const decimal PRICE_DARK_BEER = 50;
            const decimal PRICE_LIGHT_BEER = 45;
            const decimal PRICE_CHIPS = 30;
            const decimal PRICE_FISH = 40;

            decimal totalPrice =
                nudDarkBeerQty.Value * PRICE_DARK_BEER +
                nudLightBeerQty.Value * PRICE_LIGHT_BEER +
                nudChipsQty.Value * PRICE_CHIPS +
                nudFishQty.Value * PRICE_FISH;

            // Перевірка на знижку після 300 грн
            decimal discount = 0;
            if (totalPrice > 300)
            {
                discount = totalPrice * 0.15m; // Знижка 15%
            }

            totalPrice -= discount;  // Зменшуємо суму на знижку

            // Відображення підсумкової вартості з урахуванням знижки
            txtTotalPrice.Text = $"{totalPrice} грн (Знижка: {discount} грн)";
        }
    }
}
