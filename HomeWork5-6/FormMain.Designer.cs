
namespace HomeWork5_6
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
            this.listBoxThread1 = new System.Windows.Forms.ListBox();
            this.labelThread1 = new System.Windows.Forms.Label();
            this.textBoxBeginRange = new System.Windows.Forms.TextBox();
            this.textBoxEndRange = new System.Windows.Forms.TextBox();
            this.labelBeginRange = new System.Windows.Forms.Label();
            this.labelEndRange = new System.Windows.Forms.Label();
            this.buttonRunThread = new System.Windows.Forms.Button();
            this.listBoxThread2 = new System.Windows.Forms.ListBox();
            this.labelThread2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxThread1
            // 
            this.listBoxThread1.FormattingEnabled = true;
            this.listBoxThread1.ItemHeight = 16;
            this.listBoxThread1.Location = new System.Drawing.Point(20, 54);
            this.listBoxThread1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxThread1.Name = "listBoxThread1";
            this.listBoxThread1.ScrollAlwaysVisible = true;
            this.listBoxThread1.Size = new System.Drawing.Size(287, 436);
            this.listBoxThread1.TabIndex = 0;
            // 
            // labelThread1
            // 
            this.labelThread1.AutoSize = true;
            this.labelThread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThread1.Location = new System.Drawing.Point(16, 28);
            this.labelThread1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThread1.Name = "labelThread1";
            this.labelThread1.Size = new System.Drawing.Size(201, 18);
            this.labelThread1.TabIndex = 1;
            this.labelThread1.Text = "Поток 1. Простые числа";
            // 
            // textBoxBeginRange
            // 
            this.textBoxBeginRange.Location = new System.Drawing.Point(477, 50);
            this.textBoxBeginRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBeginRange.Name = "textBoxBeginRange";
            this.textBoxBeginRange.Size = new System.Drawing.Size(132, 22);
            this.textBoxBeginRange.TabIndex = 2;
            this.textBoxBeginRange.Text = "2";
            this.textBoxBeginRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBeginRange.UseWaitCursor = true;
            this.textBoxBeginRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBeginRange_KeyPress);
            // 
            // textBoxEndRange
            // 
            this.textBoxEndRange.Location = new System.Drawing.Point(477, 90);
            this.textBoxEndRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEndRange.Name = "textBoxEndRange";
            this.textBoxEndRange.Size = new System.Drawing.Size(132, 22);
            this.textBoxEndRange.TabIndex = 3;
            this.textBoxEndRange.Text = "100000";
            this.textBoxEndRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxEndRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBeginRange_KeyPress);
            // 
            // labelBeginRange
            // 
            this.labelBeginRange.AutoSize = true;
            this.labelBeginRange.Location = new System.Drawing.Point(344, 54);
            this.labelBeginRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeginRange.Name = "labelBeginRange";
            this.labelBeginRange.Size = new System.Drawing.Size(120, 17);
            this.labelBeginRange.TabIndex = 4;
            this.labelBeginRange.Text = "Нижняя граница:";
            // 
            // labelEndRange
            // 
            this.labelEndRange.AutoSize = true;
            this.labelEndRange.Location = new System.Drawing.Point(344, 94);
            this.labelEndRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndRange.Name = "labelEndRange";
            this.labelEndRange.Size = new System.Drawing.Size(124, 17);
            this.labelEndRange.TabIndex = 5;
            this.labelEndRange.Text = "Верхняя граница:";
            // 
            // buttonRunThread
            // 
            this.buttonRunThread.Location = new System.Drawing.Point(407, 120);
            this.buttonRunThread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRunThread.Name = "buttonRunThread";
            this.buttonRunThread.Size = new System.Drawing.Size(131, 50);
            this.buttonRunThread.TabIndex = 6;
            this.buttonRunThread.Text = "Запуск";
            this.buttonRunThread.UseVisualStyleBackColor = true;
            this.buttonRunThread.Click += new System.EventHandler(this.buttonRunThread_Click);
            // 
            // listBoxThread2
            // 
            this.listBoxThread2.FormattingEnabled = true;
            this.listBoxThread2.ItemHeight = 16;
            this.listBoxThread2.Location = new System.Drawing.Point(653, 54);
            this.listBoxThread2.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxThread2.Name = "listBoxThread2";
            this.listBoxThread2.ScrollAlwaysVisible = true;
            this.listBoxThread2.Size = new System.Drawing.Size(287, 436);
            this.listBoxThread2.TabIndex = 7;
            // 
            // labelThread2
            // 
            this.labelThread2.AutoSize = true;
            this.labelThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThread2.Location = new System.Drawing.Point(650, 28);
            this.labelThread2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThread2.Name = "labelThread2";
            this.labelThread2.Size = new System.Drawing.Size(222, 18);
            this.labelThread2.TabIndex = 8;
            this.labelThread2.Text = "Поток 2. Числа Фибоначчи";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelThread2);
            this.Controls.Add(this.listBoxThread2);
            this.Controls.Add(this.buttonRunThread);
            this.Controls.Add(this.labelEndRange);
            this.Controls.Add(this.labelBeginRange);
            this.Controls.Add(this.textBoxEndRange);
            this.Controls.Add(this.textBoxBeginRange);
            this.Controls.Add(this.labelThread1);
            this.Controls.Add(this.listBoxThread1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Тестовое приложение. Многопоточность.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxThread1;
        private System.Windows.Forms.Label labelThread1;
        private System.Windows.Forms.TextBox textBoxBeginRange;
        private System.Windows.Forms.TextBox textBoxEndRange;
        private System.Windows.Forms.Label labelBeginRange;
        private System.Windows.Forms.Label labelEndRange;
        private System.Windows.Forms.Button buttonRunThread;
        private System.Windows.Forms.ListBox listBoxThread2;
        private System.Windows.Forms.Label labelThread2;
    }
}

