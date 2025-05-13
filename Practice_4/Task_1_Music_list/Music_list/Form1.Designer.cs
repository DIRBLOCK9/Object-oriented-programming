namespace Music_list
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMelodies = new System.Windows.Forms.ComboBox();
            this.listBoxSelectedMelodies = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMelodies
            // 
            this.comboBoxMelodies.FormattingEnabled = true;
            this.comboBoxMelodies.Location = new System.Drawing.Point(195, 150);
            this.comboBoxMelodies.Name = "comboBoxMelodies";
            this.comboBoxMelodies.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMelodies.TabIndex = 0;
            // 
            // listBoxSelectedMelodies
            // 
            this.listBoxSelectedMelodies.FormattingEnabled = true;
            this.listBoxSelectedMelodies.Location = new System.Drawing.Point(195, 49);
            this.listBoxSelectedMelodies.Name = "listBoxSelectedMelodies";
            this.listBoxSelectedMelodies.Size = new System.Drawing.Size(120, 95);
            this.listBoxSelectedMelodies.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(195, 177);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 288);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxSelectedMelodies);
            this.Controls.Add(this.comboBoxMelodies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMelodies;
        private System.Windows.Forms.ListBox listBoxSelectedMelodies;
        private System.Windows.Forms.Button buttonAdd;
    }
}

