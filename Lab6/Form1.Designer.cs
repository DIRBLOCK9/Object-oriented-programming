namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxAnimals = new ListBox();
            cbSpecies1 = new ComboBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            tabPage3 = new TabPage();
            dgvAnimals = new DataGridView();
            tabPage2 = new TabPage();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tabPage1 = new TabPage();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbSpecies = new ComboBox();
            numPrice = new NumericUpDown();
            label4 = new Label();
            numStock = new NumericUpDown();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lbAnimals = new ListBox();
            tabControlAnimals = new TabControl();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            tabControlAnimals.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxAnimals
            // 
            listBoxAnimals.FormattingEnabled = true;
            listBoxAnimals.ItemHeight = 15;
            listBoxAnimals.Location = new Point(649, 90);
            listBoxAnimals.Name = "listBoxAnimals";
            listBoxAnimals.Size = new Size(120, 94);
            listBoxAnimals.TabIndex = 12;
            listBoxAnimals.SelectedIndexChanged += listBoxAnimals_SelectedIndexChanged;
            // 
            // cbSpecies1
            // 
            cbSpecies1.FormattingEnabled = true;
            cbSpecies1.Location = new Point(649, 190);
            cbSpecies1.Name = "cbSpecies1";
            cbSpecies1.Size = new Size(121, 23);
            cbSpecies1.TabIndex = 13;
            cbSpecies1.SelectedIndexChanged += cbSpecies1_SelectedIndexChanged;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvAnimals);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(598, 337);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Таблиця";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(18, 16);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.Size = new Size(551, 303);
            dgvAnimals.TabIndex = 0;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(598, 337);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ListView";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader5, columnHeader4 });
            listView1.Location = new Point(92, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(241, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.VirtualMode = true;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ім’я";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ціна";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Вид";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Кількість";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbAnimals);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(numStock);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(numPrice);
            tabPage1.Controls.Add(cbSpecies);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(598, 337);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Тварини";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 59);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(15, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 103);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Вид тварини";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 148);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Ціна";
            // 
            // cbSpecies
            // 
            cbSpecies.FormattingEnabled = true;
            cbSpecies.Items.AddRange(new object[] { "Кішка", "Собака", "Рибка" });
            cbSpecies.Location = new Point(15, 122);
            cbSpecies.Name = "cbSpecies";
            cbSpecies.Size = new Size(121, 23);
            cbSpecies.TabIndex = 4;
            cbSpecies.SelectedIndexChanged += cbSpecies_SelectedIndexChanged;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(16, 166);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 204);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Кількість";
            // 
            // numStock
            // 
            numStock.Location = new Point(16, 222);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Location = new Point(15, 274);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Yellow;
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.Location = new Point(177, 274);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Location = new Point(96, 274);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbAnimals
            // 
            lbAnimals.FormattingEnabled = true;
            lbAnimals.ItemHeight = 15;
            lbAnimals.Location = new Point(171, 125);
            lbAnimals.Name = "lbAnimals";
            lbAnimals.Size = new Size(127, 94);
            lbAnimals.TabIndex = 11;
            lbAnimals.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControlAnimals
            // 
            tabControlAnimals.Controls.Add(tabPage1);
            tabControlAnimals.Controls.Add(tabPage2);
            tabControlAnimals.Controls.Add(tabPage3);
            tabControlAnimals.Location = new Point(23, 28);
            tabControlAnimals.Name = "tabControlAnimals";
            tabControlAnimals.SelectedIndex = 0;
            tabControlAnimals.Size = new Size(606, 365);
            tabControlAnimals.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSpecies1);
            Controls.Add(listBoxAnimals);
            Controls.Add(tabControlAnimals);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            tabControlAnimals.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxAnimals;
        private ComboBox cbSpecies1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private TabPage tabPage3;
        private DataGridView dgvAnimals;
        private TabPage tabPage2;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader4;
        private TabPage tabPage1;
        private ListBox lbAnimals;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private NumericUpDown numStock;
        private Label label4;
        private NumericUpDown numPrice;
        private ComboBox cbSpecies;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TabControl tabControlAnimals;
    }
}
