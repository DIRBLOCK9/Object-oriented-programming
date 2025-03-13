using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedIceCream = string.Empty;

            if (rbChocolate.Checked)
                selectedIceCream = "Шоколадне";
            else if (rbVanilla.Checked)
                selectedIceCream = "Ванільне";
            else if (rbStrawberry.Checked)
                selectedIceCream = "Полуничне";
            else if (rbBanana.Checked)
                selectedIceCream = "Бананове";
            else
            {
                MessageBox.Show("Будь ласка, виберіть сорт морозива.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int quantity = (int)nudQuantity.Value;

           
            decimal pricePerPortion = 0;

            switch (selectedIceCream)
            {
                case "Шоколадне":
                    pricePerPortion = 40; 
                    break;
                case "Ванільне":
                    pricePerPortion = 35;
                    break;
                case "Полуничне":
                    pricePerPortion = 45;
                    break;
                case "Бананове":
                    pricePerPortion = 50;
                    break;
            }

           
            decimal totalPrice = pricePerPortion * quantity;

            
            if (quantity > 20)
            {
                totalPrice *= 0.95m; 
            }

            
            txtResult.Text = $"Ви замовили {quantity} порцію {selectedIceCream} морозива.\n" +
                             $"Загальна вартість: {totalPrice} грн";
        }
    }
    }

