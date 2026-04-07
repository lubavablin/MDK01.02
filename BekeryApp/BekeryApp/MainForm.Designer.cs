namespace BekeryApp
{
    partial class MainForm
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
            this.comboBoxPies = new System.Windows.Forms.ComboBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPies
            // 
            this.comboBoxPies.FormattingEnabled = true;
            this.comboBoxPies.Location = new System.Drawing.Point(129, 116);
            this.comboBoxPies.Name = "comboBoxPies";
            this.comboBoxPies.Size = new System.Drawing.Size(170, 21);
            this.comboBoxPies.TabIndex = 0;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(169, 208);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(88, 44);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите пирожок:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.comboBoxPies);
            this.Name = "MainForm";
            this.Text = "Пекарня";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPies;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label label1;
    }
}

