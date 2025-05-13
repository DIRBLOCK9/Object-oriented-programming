namespace BEER_order
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblLightBeer = new System.Windows.Forms.Label();
            this.lblDarkBeer = new System.Windows.Forms.Label();
            this.nudLightBeerQty = new System.Windows.Forms.NumericUpDown();
            this.nudDarkBeerQty = new System.Windows.Forms.NumericUpDown();
            this.nudChipsQty = new System.Windows.Forms.NumericUpDown();
            this.nudFishQty = new System.Windows.Forms.NumericUpDown();
            this.lblChips = new System.Windows.Forms.Label();
            this.lblFish = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLightBeerQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDarkBeerQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipsQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFishQty)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(776, 360);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nudDarkBeerQty);
            this.tabPage1.Controls.Add(this.nudLightBeerQty);
            this.tabPage1.Controls.Add(this.lblDarkBeer);
            this.tabPage1.Controls.Add(this.lblLightBeer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пиво";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblFish);
            this.tabPage2.Controls.Add(this.lblChips);
            this.tabPage2.Controls.Add(this.nudFishQty);
            this.tabPage2.Controls.Add(this.nudChipsQty);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Закуски";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblLightBeer
            // 
            this.lblLightBeer.AutoSize = true;
            this.lblLightBeer.Location = new System.Drawing.Point(9, 28);
            this.lblLightBeer.Name = "lblLightBeer";
            this.lblLightBeer.Size = new System.Drawing.Size(66, 13);
            this.lblLightBeer.TabIndex = 0;
            this.lblLightBeer.Text = "Світле пиво";
            // 
            // lblDarkBeer
            // 
            this.lblDarkBeer.AutoSize = true;
            this.lblDarkBeer.Location = new System.Drawing.Point(8, 54);
            this.lblDarkBeer.Name = "lblDarkBeer";
            this.lblDarkBeer.Size = new System.Drawing.Size(67, 13);
            this.lblDarkBeer.TabIndex = 1;
            this.lblDarkBeer.Text = "Темне пиво";
            // 
            // nudLightBeerQty
            // 
            this.nudLightBeerQty.Location = new System.Drawing.Point(81, 26);
            this.nudLightBeerQty.Name = "nudLightBeerQty";
            this.nudLightBeerQty.Size = new System.Drawing.Size(120, 20);
            this.nudLightBeerQty.TabIndex = 2;
            this.nudLightBeerQty.ValueChanged += new System.EventHandler(this.UpdateTotalPrice);
            // 
            // nudDarkBeerQty
            // 
            this.nudDarkBeerQty.Location = new System.Drawing.Point(81, 52);
            this.nudDarkBeerQty.Name = "nudDarkBeerQty";
            this.nudDarkBeerQty.Size = new System.Drawing.Size(120, 20);
            this.nudDarkBeerQty.TabIndex = 3;
            this.nudDarkBeerQty.ValueChanged += new System.EventHandler(this.UpdateTotalPrice);
            // 
            // nudChipsQty
            // 
            this.nudChipsQty.Location = new System.Drawing.Point(47, 38);
            this.nudChipsQty.Name = "nudChipsQty";
            this.nudChipsQty.Size = new System.Drawing.Size(120, 20);
            this.nudChipsQty.TabIndex = 0;
            this.nudChipsQty.ValueChanged += new System.EventHandler(this.UpdateTotalPrice);
            // 
            // nudFishQty
            // 
            this.nudFishQty.Location = new System.Drawing.Point(47, 64);
            this.nudFishQty.Name = "nudFishQty";
            this.nudFishQty.Size = new System.Drawing.Size(120, 20);
            this.nudFishQty.TabIndex = 1;
            this.nudFishQty.ValueChanged += new System.EventHandler(this.UpdateTotalPrice);
            // 
            // lblChips
            // 
            this.lblChips.AutoSize = true;
            this.lblChips.Location = new System.Drawing.Point(6, 40);
            this.lblChips.Name = "lblChips";
            this.lblChips.Size = new System.Drawing.Size(35, 13);
            this.lblChips.TabIndex = 2;
            this.lblChips.Text = "Чіпси";
            // 
            // lblFish
            // 
            this.lblFish.AutoSize = true;
            this.lblFish.Location = new System.Drawing.Point(6, 66);
            this.lblFish.Name = "lblFish";
            this.lblFish.Size = new System.Drawing.Size(32, 13);
            this.lblFish.TabIndex = 3;
            this.lblFish.Text = "Риба";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(246, 3);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(207, 20);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(84, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Замовити";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(165, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "45 грн";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "50 грн";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "30 грн";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "40 грн";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Controls.Add(this.txtTotalPrice);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 393);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 45);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLightBeerQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDarkBeerQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipsQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFishQty)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nudDarkBeerQty;
        private System.Windows.Forms.NumericUpDown nudLightBeerQty;
        private System.Windows.Forms.Label lblDarkBeer;
        private System.Windows.Forms.Label lblLightBeer;
        private System.Windows.Forms.Label lblFish;
        private System.Windows.Forms.Label lblChips;
        private System.Windows.Forms.NumericUpDown nudFishQty;
        private System.Windows.Forms.NumericUpDown nudChipsQty;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

