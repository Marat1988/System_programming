
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
            this.buttonAbortPrimeNumber = new System.Windows.Forms.Button();
            this.buttonAbortFibinacciNumber = new System.Windows.Forms.Button();
            this.buttonSuppentPrimeNumber = new System.Windows.Forms.Button();
            this.buttonSuppentFiibinacciNumber = new System.Windows.Forms.Button();
            this.buttonResumePrimeNumber = new System.Windows.Forms.Button();
            this.buttonResumeFiibinacciNumber = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxThread1
            // 
            this.listBoxThread1.FormattingEnabled = true;
            this.listBoxThread1.ItemHeight = 16;
            this.listBoxThread1.Location = new System.Drawing.Point(20, 54);
            this.listBoxThread1.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxThread1.Name = "listBoxThread1";
            this.listBoxThread1.ScrollAlwaysVisible = true;
            this.listBoxThread1.Size = new System.Drawing.Size(220, 436);
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
            this.textBoxBeginRange.Margin = new System.Windows.Forms.Padding(4);
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
            this.textBoxEndRange.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonRunThread.Location = new System.Drawing.Point(407, 121);
            this.buttonRunThread.Margin = new System.Windows.Forms.Padding(4);
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
            this.listBoxThread2.Location = new System.Drawing.Point(655, 54);
            this.listBoxThread2.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxThread2.Name = "listBoxThread2";
            this.listBoxThread2.ScrollAlwaysVisible = true;
            this.listBoxThread2.Size = new System.Drawing.Size(224, 436);
            this.listBoxThread2.TabIndex = 7;
            // 
            // labelThread2
            // 
            this.labelThread2.AutoSize = true;
            this.labelThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThread2.Location = new System.Drawing.Point(651, 28);
            this.labelThread2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThread2.Name = "labelThread2";
            this.labelThread2.Size = new System.Drawing.Size(222, 18);
            this.labelThread2.TabIndex = 8;
            this.labelThread2.Text = "Поток 2. Числа Фибоначчи";
            // 
            // buttonAbortPrimeNumber
            // 
            this.buttonAbortPrimeNumber.Location = new System.Drawing.Point(20, 500);
            this.buttonAbortPrimeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbortPrimeNumber.Name = "buttonAbortPrimeNumber";
            this.buttonAbortPrimeNumber.Size = new System.Drawing.Size(221, 30);
            this.buttonAbortPrimeNumber.TabIndex = 9;
            this.buttonAbortPrimeNumber.Text = "Abort";
            this.buttonAbortPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonAbortPrimeNumber.Click += new System.EventHandler(this.buttonAbortPrimeNumber_Click);
            // 
            // buttonAbortFibinacciNumber
            // 
            this.buttonAbortFibinacciNumber.Location = new System.Drawing.Point(655, 498);
            this.buttonAbortFibinacciNumber.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbortFibinacciNumber.Name = "buttonAbortFibinacciNumber";
            this.buttonAbortFibinacciNumber.Size = new System.Drawing.Size(221, 30);
            this.buttonAbortFibinacciNumber.TabIndex = 10;
            this.buttonAbortFibinacciNumber.Text = "Abort";
            this.buttonAbortFibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonAbortFibinacciNumber.Click += new System.EventHandler(this.buttonAbortFibinacciNumber_Click);
            // 
            // buttonSuppentPrimeNumber
            // 
            this.buttonSuppentPrimeNumber.Location = new System.Drawing.Point(20, 537);
            this.buttonSuppentPrimeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSuppentPrimeNumber.Name = "buttonSuppentPrimeNumber";
            this.buttonSuppentPrimeNumber.Size = new System.Drawing.Size(221, 31);
            this.buttonSuppentPrimeNumber.TabIndex = 11;
            this.buttonSuppentPrimeNumber.Text = "Suppend";
            this.buttonSuppentPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonSuppentPrimeNumber.Click += new System.EventHandler(this.buttonSuppentPrimeNumber_Click);
            // 
            // buttonSuppentFiibinacciNumber
            // 
            this.buttonSuppentFiibinacciNumber.Location = new System.Drawing.Point(655, 537);
            this.buttonSuppentFiibinacciNumber.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSuppentFiibinacciNumber.Name = "buttonSuppentFiibinacciNumber";
            this.buttonSuppentFiibinacciNumber.Size = new System.Drawing.Size(221, 31);
            this.buttonSuppentFiibinacciNumber.TabIndex = 12;
            this.buttonSuppentFiibinacciNumber.Text = "Suppend";
            this.buttonSuppentFiibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonSuppentFiibinacciNumber.Click += new System.EventHandler(this.buttonSuppentFiibinacciNumber_Click);
            // 
            // buttonResumePrimeNumber
            // 
            this.buttonResumePrimeNumber.Location = new System.Drawing.Point(20, 575);
            this.buttonResumePrimeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResumePrimeNumber.Name = "buttonResumePrimeNumber";
            this.buttonResumePrimeNumber.Size = new System.Drawing.Size(221, 31);
            this.buttonResumePrimeNumber.TabIndex = 13;
            this.buttonResumePrimeNumber.Text = "Resume";
            this.buttonResumePrimeNumber.UseVisualStyleBackColor = true;
            this.buttonResumePrimeNumber.Click += new System.EventHandler(this.buttonResumePrimeNumber_Click);
            // 
            // buttonResumeFiibinacciNumber
            // 
            this.buttonResumeFiibinacciNumber.Location = new System.Drawing.Point(655, 575);
            this.buttonResumeFiibinacciNumber.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResumeFiibinacciNumber.Name = "buttonResumeFiibinacciNumber";
            this.buttonResumeFiibinacciNumber.Size = new System.Drawing.Size(221, 31);
            this.buttonResumeFiibinacciNumber.TabIndex = 14;
            this.buttonResumeFiibinacciNumber.Text = "Resume";
            this.buttonResumeFiibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonResumeFiibinacciNumber.Click += new System.EventHandler(this.buttonResumeFiibinacciNumber_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonResumeFiibinacciNumber);
            this.Controls.Add(this.buttonResumePrimeNumber);
            this.Controls.Add(this.buttonSuppentFiibinacciNumber);
            this.Controls.Add(this.buttonSuppentPrimeNumber);
            this.Controls.Add(this.buttonAbortFibinacciNumber);
            this.Controls.Add(this.buttonAbortPrimeNumber);
            this.Controls.Add(this.labelThread2);
            this.Controls.Add(this.listBoxThread2);
            this.Controls.Add(this.buttonRunThread);
            this.Controls.Add(this.labelEndRange);
            this.Controls.Add(this.labelBeginRange);
            this.Controls.Add(this.textBoxEndRange);
            this.Controls.Add(this.textBoxBeginRange);
            this.Controls.Add(this.labelThread1);
            this.Controls.Add(this.listBoxThread1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Тестовое приложение. Многопоточность.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
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
        private System.Windows.Forms.Button buttonAbortPrimeNumber;
        private System.Windows.Forms.Button buttonAbortFibinacciNumber;
        private System.Windows.Forms.Button buttonSuppentPrimeNumber;
        private System.Windows.Forms.Button buttonSuppentFiibinacciNumber;
        private System.Windows.Forms.Button buttonResumePrimeNumber;
        private System.Windows.Forms.Button buttonResumeFiibinacciNumber;
        private System.Windows.Forms.Button button1;
    }
}

