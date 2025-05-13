using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation_of_ice_cream_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;  
            string result = "Ваше замовлення:\n ";  

            
            if (cbChocolate.Checked)
            {
                int quantityChocolate = (int)nudChocolate.Value;
                decimal priceChocolate = 40; 
                decimal priceForChocolate = priceChocolate * quantityChocolate;
                result += $"{quantityChocolate}порцій Шоколадного морозива по {priceChocolate} грн = {priceForChocolate} грн\n ";
                 totalPrice += priceForChocolate;
            }

           
            if (cbStrawberry.Checked)
            {
                int quantityStrawberry = (int)nudStrawberry.Value;
                decimal priceStrawberry = 45;
                decimal priceForStrawberry = priceStrawberry * quantityStrawberry;
                result += $"{quantityStrawberry} порцій Полуничного морозива по {priceStrawberry} грн = {priceForStrawberry} грн\n ";
                 totalPrice += priceForStrawberry;
            }

            
            if (cbBanana.Checked)
            {
                int quantityBanana = (int)nudBanana.Value;
                decimal priceBanana = 50;
                decimal priceForBanana = priceBanana * quantityBanana;
                result += $"{quantityBanana} порцій Бананового морозива по {priceBanana} грн = {priceForBanana} грн\n ";
                 totalPrice += priceForBanana;
            }

            
            if (totalPrice > 0) 
            {
                if ((int)nudChocolate.Value + (int)nudStrawberry.Value + (int)nudBanana.Value > 20)
                {
                    decimal discount = totalPrice * 0.05m; 
                    totalPrice -= discount; 
                    result += $"\nЗнижка 5%: {discount} грн";
                }

                
                result += $"\n\nЗагальна сума: {totalPrice} грн";
                txtResult.Text = result;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть морозиво та кількість порцій.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
