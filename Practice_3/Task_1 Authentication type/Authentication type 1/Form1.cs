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
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Будь ласка, виберіть стать.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  
            }

            
            if (nudYear.Value == 0 || nudMonth.Value == 0 || nudDay.Value == 0)
            {
                MessageBox.Show("Будь ласка, виберіть дату народження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  
            }

           
            int year = (int)nudYear.Value;
            int month = (int)nudMonth.Value;
            int day = (int)nudDay.Value;

            
            string gender = rbMale.Checked ? "Чоловік" : "Жінка";

           
            string birthDate = $"{day}/{month}/{year}";

            
            txtResult.Text = $"Дата народження: {birthDate}\n Стать: {gender}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
