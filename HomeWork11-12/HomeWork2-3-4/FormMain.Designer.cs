
namespace HomeWork2_3_4
{
    partial class FormMain
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
            this.listBoxPassengers = new System.Windows.Forms.ListBox();
            this.labelPassengers = new System.Windows.Forms.Label();
            this.listBoxBus = new System.Windows.Forms.ListBox();
            this.labelBus = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelCountPassenger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPassengers
            // 
            this.listBoxPassengers.FormattingEnabled = true;
            this.listBoxPassengers.HorizontalScrollbar = true;
            this.listBoxPassengers.Location = new System.Drawing.Point(15, 82);
            this.listBoxPassengers.Name = "listBoxPassengers";
            this.listBoxPassengers.ScrollAlwaysVisible = true;
            this.listBoxPassengers.Size = new System.Drawing.Size(334, 303);
            this.listBoxPassengers.TabIndex = 0;
            // 
            // labelPassengers
            // 
            this.labelPassengers.AutoSize = true;
            this.labelPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassengers.Location = new System.Drawing.Point(12, 56);
            this.labelPassengers.Name = "labelPassengers";
            this.labelPassengers.Size = new System.Drawing.Size(95, 16);
            this.labelPassengers.TabIndex = 1;
            this.labelPassengers.Text = "Пассажиры:";
            // 
            // listBoxBus
            // 
            this.listBoxBus.FormattingEnabled = true;
            this.listBoxBus.HorizontalScrollbar = true;
            this.listBoxBus.Location = new System.Drawing.Point(396, 82);
            this.listBoxBus.Name = "listBoxBus";
            this.listBoxBus.ScrollAlwaysVisible = true;
            this.listBoxBus.Size = new System.Drawing.Size(334, 303);
            this.listBoxBus.TabIndex = 2;
            // 
            // labelBus
            // 
            this.labelBus.AutoSize = true;
            this.labelBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBus.Location = new System.Drawing.Point(393, 56);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(84, 16);
            this.labelBus.TabIndex = 3;
            this.labelBus.Text = "Автобусы:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 402);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(124, 56);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Запуск имитации";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(173, 25);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Текущее время:";
            // 
            // labelCountPassenger
            // 
            this.labelCountPassenger.AutoSize = true;
            this.labelCountPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPassenger.Location = new System.Drawing.Point(176, 402);
            this.labelCountPassenger.Name = "labelCountPassenger";
            this.labelCountPassenger.Size = new System.Drawing.Size(412, 20);
            this.labelCountPassenger.TabIndex = 6;
            this.labelCountPassenger.Text = "Текущее количество пассажиров на остановке:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 507);
            this.Controls.Add(this.labelCountPassenger);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelBus);
            this.Controls.Add(this.listBoxBus);
            this.Controls.Add(this.labelPassengers);
            this.Controls.Add(this.listBoxPassengers);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потоки. Имитация работы автобусной конечной";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPassengers;
        private System.Windows.Forms.Label labelPassengers;
        private System.Windows.Forms.ListBox listBoxBus;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCountPassenger;
    }
}

