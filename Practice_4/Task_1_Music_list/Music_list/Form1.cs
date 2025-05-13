using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMusicList();
        }

        private void InitializeMusicList()

        {
            comboBoxMelodies.Items.AddRange(new string[]
       {
        "Bohemian Rhapsody",
        "Imagine",
        "Hotel California",
        "Stairway to Heaven",
        "Hey Jude",
        "Smells Like Teen Spirit",
        "Wonderwall",
        "Sweet Child O' Mine",
        "Billie Jean",
        "Shape of You"
       });
      }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMelodies.SelectedItem != null)
            {
                listBoxSelectedMelodies.Items.Add(comboBoxMelodies.SelectedItem);
            }
            else
            {
                MessageBox.Show("Оберіть мелодію зі списку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
