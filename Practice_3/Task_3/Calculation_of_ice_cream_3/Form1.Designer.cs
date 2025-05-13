namespace Calculation_of_ice_cream_2
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.nudChocolate = new System.Windows.Forms.NumericUpDown();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.cbStrawberry = new System.Windows.Forms.CheckBox();
            this.cbBanana = new System.Windows.Forms.CheckBox();
            this.cbVanilla = new System.Windows.Forms.CheckBox();
            this.nudStrawberry = new System.Windows.Forms.NumericUpDown();
            this.nudBanana = new System.Windows.Forms.NumericUpDown();
            this.nudVanilla = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudChocolate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrawberry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(53, 195);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 34);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Підтвердити";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // nudChocolate
            // 
            this.nudChocolate.Location = new System.Drawing.Point(101, 42);
            this.nudChocolate.Name = "nudChocolate";
            this.nudChocolate.Size = new System.Drawing.Size(98, 20);
            this.nudChocolate.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(245, 41);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(163, 186);
            this.txtResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Кількість порцій:";
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(12, 43);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(83, 17);
            this.cbChocolate.TabIndex = 8;
            this.cbChocolate.Text = "Шоколадне";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // cbStrawberry
            // 
            this.cbStrawberry.AutoSize = true;
            this.cbStrawberry.Location = new System.Drawing.Point(12, 73);
            this.cbStrawberry.Name = "cbStrawberry";
            this.cbStrawberry.Size = new System.Drawing.Size(80, 17);
            this.cbStrawberry.TabIndex = 9;
            this.cbStrawberry.Text = "Полуничне";
            this.cbStrawberry.UseVisualStyleBackColor = true;
            // 
            // cbBanana
            // 
            this.cbBanana.AutoSize = true;
            this.cbBanana.Location = new System.Drawing.Point(12, 101);
            this.cbBanana.Name = "cbBanana";
            this.cbBanana.Size = new System.Drawing.Size(75, 17);
            this.cbBanana.TabIndex = 10;
            this.cbBanana.Text = "Бананове";
            this.cbBanana.UseVisualStyleBackColor = true;
            // 
            // cbVanilla
            // 
            this.cbVanilla.AutoSize = true;
            this.cbVanilla.Location = new System.Drawing.Point(12, 130);
            this.cbVanilla.Name = "cbVanilla";
            this.cbVanilla.Size = new System.Drawing.Size(71, 17);
            this.cbVanilla.TabIndex = 11;
            this.cbVanilla.Text = "Ванільне";
            this.cbVanilla.UseVisualStyleBackColor = true;
            this.cbVanilla.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // nudStrawberry
            // 
            this.nudStrawberry.Location = new System.Drawing.Point(101, 73);
            this.nudStrawberry.Name = "nudStrawberry";
            this.nudStrawberry.Size = new System.Drawing.Size(98, 20);
            this.nudStrawberry.TabIndex = 12;
            // 
            // nudBanana
            // 
            this.nudBanana.Location = new System.Drawing.Point(101, 101);
            this.nudBanana.Name = "nudBanana";
            this.nudBanana.Size = new System.Drawing.Size(98, 20);
            this.nudBanana.TabIndex = 13;
            // 
            // nudVanilla
            // 
            this.nudVanilla.Location = new System.Drawing.Point(101, 130);
            this.nudVanilla.Name = "nudVanilla";
            this.nudVanilla.Size = new System.Drawing.Size(98, 20);
            this.nudVanilla.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 256);
            this.Controls.Add(this.nudVanilla);
            this.Controls.Add(this.nudBanana);
            this.Controls.Add(this.nudStrawberry);
            this.Controls.Add(this.cbVanilla);
            this.Controls.Add(this.cbBanana);
            this.Controls.Add(this.cbStrawberry);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.nudChocolate);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudChocolate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrawberry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown nudChocolate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.CheckBox cbStrawberry;
        private System.Windows.Forms.CheckBox cbBanana;
        private System.Windows.Forms.CheckBox cbVanilla;
        private System.Windows.Forms.NumericUpDown nudStrawberry;
        private System.Windows.Forms.NumericUpDown nudBanana;
        private System.Windows.Forms.NumericUpDown nudVanilla;
    }
}

