
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
            this.listBoxThreadPrimeNumber = new System.Windows.Forms.ListBox();
            this.labelThread1 = new System.Windows.Forms.Label();
            this.textBoxEndRange = new System.Windows.Forms.TextBox();
            this.labelBeginRange = new System.Windows.Forms.Label();
            this.labelEndRange = new System.Windows.Forms.Label();
            this.buttonRunFibinacciNumber = new System.Windows.Forms.Button();
            this.listBoxThreadFibinacciNumber = new System.Windows.Forms.ListBox();
            this.labelThread2 = new System.Windows.Forms.Label();
            this.buttonAbortPrimeNumber = new System.Windows.Forms.Button();
            this.buttonAbortFibinacciNumber = new System.Windows.Forms.Button();
            this.buttonSuppentPrimeNumber = new System.Windows.Forms.Button();
            this.buttonSuppentFiibinacciNumber = new System.Windows.Forms.Button();
            this.buttonResumePrimeNumber = new System.Windows.Forms.Button();
            this.buttonResumeFiibinacciNumber = new System.Windows.Forms.Button();
            this.buttonRunPrimeNumber = new System.Windows.Forms.Button();
            this.textBoxBeginRange = new System.Windows.Forms.TextBox();
            this.buttonRestartPrimeNumber = new System.Windows.Forms.Button();
            this.buttonRestartFibinacciNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxThreadPrimeNumber
            // 
            this.listBoxThreadPrimeNumber.FormattingEnabled = true;
            this.listBoxThreadPrimeNumber.ItemHeight = 16;
            this.listBoxThreadPrimeNumber.Location = new System.Drawing.Point(20, 54);
            this.listBoxThreadPrimeNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxThreadPrimeNumber.Name = "listBoxThreadPrimeNumber";
            this.listBoxThreadPrimeNumber.ScrollAlwaysVisible = true;
            this.listBoxThreadPrimeNumber.Size = new System.Drawing.Size(220, 436);
            this.listBoxThreadPrimeNumber.TabIndex = 0;
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
            // textBoxEndRange
            // 
            this.textBoxEndRange.Location = new System.Drawing.Point(385, 92);
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
            this.labelBeginRange.Location = new System.Drawing.Point(252, 59);
            this.labelBeginRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeginRange.Name = "labelBeginRange";
            this.labelBeginRange.Size = new System.Drawing.Size(120, 17);
            this.labelBeginRange.TabIndex = 4;
            this.labelBeginRange.Text = "Нижняя граница:";
            // 
            // labelEndRange
            // 
            this.labelEndRange.AutoSize = true;
            this.labelEndRange.Location = new System.Drawing.Point(249, 92);
            this.labelEndRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndRange.Name = "labelEndRange";
            this.labelEndRange.Size = new System.Drawing.Size(124, 17);
            this.labelEndRange.TabIndex = 5;
            this.labelEndRange.Text = "Верхняя граница:";
            // 
            // buttonRunFibinacciNumber
            // 
            this.buttonRunFibinacciNumber.Location = new System.Drawing.Point(593, 498);
            this.buttonRunFibinacciNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRunFibinacciNumber.Name = "buttonRunFibinacciNumber";
            this.buttonRunFibinacciNumber.Size = new System.Drawing.Size(221, 30);
            this.buttonRunFibinacciNumber.TabIndex = 6;
            this.buttonRunFibinacciNumber.Text = "Run";
            this.buttonRunFibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonRunFibinacciNumber.Click += new System.EventHandler(this.buttonRunFibinacciNumber_Click);
            // 
            // listBoxThreadFibinacciNumber
            // 
            this.listBoxThreadFibinacciNumber.FormattingEnabled = true;
            this.listBoxThreadFibinacciNumber.ItemHeight = 16;
            this.listBoxThreadFibinacciNumber.Location = new System.Drawing.Point(593, 54);
            this.listBoxThreadFibinacciNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxThreadFibinacciNumber.Name = "listBoxThreadFibinacciNumber";
            this.listBoxThreadFibinacciNumber.ScrollAlwaysVisible = true;
            this.listBoxThreadFibinacciNumber.Size = new System.Drawing.Size(224, 436);
            this.listBoxThreadFibinacciNumber.TabIndex = 7;
            // 
            // labelThread2
            // 
            this.labelThread2.AutoSize = true;
            this.labelThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThread2.Location = new System.Drawing.Point(589, 28);
            this.labelThread2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThread2.Name = "labelThread2";
            this.labelThread2.Size = new System.Drawing.Size(222, 18);
            this.labelThread2.TabIndex = 8;
            this.labelThread2.Text = "Поток 2. Числа Фибоначчи";
            // 
            // buttonAbortPrimeNumber
            // 
            this.buttonAbortPrimeNumber.Location = new System.Drawing.Point(20, 535);
            this.buttonAbortPrimeNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbortPrimeNumber.Name = "buttonAbortPrimeNumber";
            this.buttonAbortPrimeNumber.Size = new System.Drawing.Size(221, 30);
            this.buttonAbortPrimeNumber.TabIndex = 9;
            this.buttonAbortPrimeNumber.Text = "Abort";
            this.buttonAbortPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonAbortPrimeNumber.Click += new System.EventHandler(this.buttonAbortPrimeNumber_Click);
            // 
            // buttonAbortFibinacciNumber
            // 
            this.buttonAbortFibinacciNumber.Location = new System.Drawing.Point(593, 535);
            this.buttonAbortFibinacciNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbortFibinacciNumber.Name = "buttonAbortFibinacciNumber";
            this.buttonAbortFibinacciNumber.Size = new System.Drawing.Size(221, 30);
            this.buttonAbortFibinacciNumber.TabIndex = 10;
            this.buttonAbortFibinacciNumber.Text = "Abort";
            this.buttonAbortFibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonAbortFibinacciNumber.Click += new System.EventHandler(this.buttonAbortFibinacciNumber_Click);
            // 
            // buttonSuppentPrimeNumber
            // 
            this.buttonSuppentPrimeNumber.Location = new System.Drawing.Point(20, 572);
            this.buttonSuppentPrimeNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSuppentPrimeNumber.Name = "buttonSuppentPrimeNumber";
            this.buttonSuppentPrimeNumber.Size = new System.Drawing.Size(221, 31);
            this.buttonSuppentPrimeNumber.TabIndex = 11;
            this.buttonSuppentPrimeNumber.Text = "Suppend";
            this.buttonSuppentPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonSuppentPrimeNumber.Click += new System.EventHandler(this.buttonSuppentPrimeNumber_Click);
            // 
            // buttonSuppentFiibinacciNumber
            // 
            this.buttonSuppentFiibinacciNumber.Location = new System.Drawing.Point(593, 572);
            this.buttonSuppentFiibinacciNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSuppentFiibinacciNumber.Name = "buttonSuppentFiibinacciNumber";
            this.buttonSuppentFiibinacciNumber.Size = new System.Drawing.Size(221, 31);
            this.buttonSuppentFiibinacciNumber.TabIndex = 12;
            this.buttonSuppentFiibinacciNumber.Text = "Suppend";
            this.buttonSuppentFiibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonSuppentFiibinacciNumber.Click += new System.EventHandler(this.buttonSuppentFiibinacciNumber_Click);
            // 
            // buttonResumePrimeNumber
            // 
            this.buttonResumePrimeNumber.Location = new System.Drawing.Point(20, 610);
            this.buttonResumePrimeNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonResumePrimeNumber.Name = "buttonResumePrimeNumber";
            this.buttonResumePrimeNumber.Size = new System.Drawing.Size(221, 31);
            this.buttonResumePrimeNumber.TabIndex = 13;
            this.buttonResumePrimeNumber.Text = "Resume";
            this.buttonResumePrimeNumber.UseVisualStyleBackColor = true;
            this.buttonResumePrimeNumber.Click += new System.EventHandler(this.buttonResumePrimeNumber_Click);
            // 
            // buttonResumeFiibinacciNumber
            // 
            this.buttonResumeFiibinacciNumber.Location = new System.Drawing.Point(593, 610);
            this.buttonResumeFiibinacciNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonResumeFiibinacciNumber.Name = "buttonResumeFiibinacciNumber";
            this.buttonResumeFiibinacciNumber.Size = new System.Drawing.Size(221, 31);
            this.buttonResumeFiibinacciNumber.TabIndex = 14;
            this.buttonResumeFiibinacciNumber.Text = "Resume";
            this.buttonResumeFiibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonResumeFiibinacciNumber.Click += new System.EventHandler(this.buttonResumeFiibinacciNumber_Click);
            // 
            // buttonRunPrimeNumber
            // 
            this.buttonRunPrimeNumber.Location = new System.Drawing.Point(20, 498);
            this.buttonRunPrimeNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRunPrimeNumber.Name = "buttonRunPrimeNumber";
            this.buttonRunPrimeNumber.Size = new System.Drawing.Size(221, 30);
            this.buttonRunPrimeNumber.TabIndex = 16;
            this.buttonRunPrimeNumber.Text = "Run";
            this.buttonRunPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonRunPrimeNumber.Click += new System.EventHandler(this.buttonRunPrimeNumber_Click);
            // 
            // textBoxBeginRange
            // 
            this.textBoxBeginRange.Location = new System.Drawing.Point(385, 55);
            this.textBoxBeginRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBeginRange.Name = "textBoxBeginRange";
            this.textBoxBeginRange.Size = new System.Drawing.Size(132, 22);
            this.textBoxBeginRange.TabIndex = 17;
            this.textBoxBeginRange.Text = "2";
            this.textBoxBeginRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBeginRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBeginRange_KeyPress);
            // 
            // buttonRestartPrimeNumber
            // 
            this.buttonRestartPrimeNumber.Location = new System.Drawing.Point(20, 649);
            this.buttonRestartPrimeNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRestartPrimeNumber.Name = "buttonRestartPrimeNumber";
            this.buttonRestartPrimeNumber.Size = new System.Drawing.Size(221, 30);
            this.buttonRestartPrimeNumber.TabIndex = 18;
            this.buttonRestartPrimeNumber.Text = "Restart";
            this.buttonRestartPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonRestartPrimeNumber.Click += new System.EventHandler(this.buttonRestartPrimeNumber_Click);
            // 
            // buttonRestartFibinacciNumber
            // 
            this.buttonRestartFibinacciNumber.Location = new System.Drawing.Point(593, 649);
            this.buttonRestartFibinacciNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRestartFibinacciNumber.Name = "buttonRestartFibinacciNumber";
            this.buttonRestartFibinacciNumber.Size = new System.Drawing.Size(221, 30);
            this.buttonRestartFibinacciNumber.TabIndex = 19;
            this.buttonRestartFibinacciNumber.Text = "Restart";
            this.buttonRestartFibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonRestartFibinacciNumber.Click += new System.EventHandler(this.buttonRestartFibinacciNumber_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 715);
            this.Controls.Add(this.buttonRestartFibinacciNumber);
            this.Controls.Add(this.buttonRestartPrimeNumber);
            this.Controls.Add(this.textBoxBeginRange);
            this.Controls.Add(this.buttonRunPrimeNumber);
            this.Controls.Add(this.buttonResumeFiibinacciNumber);
            this.Controls.Add(this.buttonResumePrimeNumber);
            this.Controls.Add(this.buttonSuppentFiibinacciNumber);
            this.Controls.Add(this.buttonSuppentPrimeNumber);
            this.Controls.Add(this.buttonAbortFibinacciNumber);
            this.Controls.Add(this.buttonAbortPrimeNumber);
            this.Controls.Add(this.labelThread2);
            this.Controls.Add(this.listBoxThreadFibinacciNumber);
            this.Controls.Add(this.buttonRunFibinacciNumber);
            this.Controls.Add(this.labelEndRange);
            this.Controls.Add(this.labelBeginRange);
            this.Controls.Add(this.textBoxEndRange);
            this.Controls.Add(this.labelThread1);
            this.Controls.Add(this.listBoxThreadPrimeNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Тестовое приложение. Многопоточность.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxThreadPrimeNumber;
        private System.Windows.Forms.Label labelThread1;
        private System.Windows.Forms.TextBox textBoxEndRange;
        private System.Windows.Forms.Label labelBeginRange;
        private System.Windows.Forms.Label labelEndRange;
        private System.Windows.Forms.Button buttonRunFibinacciNumber;
        private System.Windows.Forms.ListBox listBoxThreadFibinacciNumber;
        private System.Windows.Forms.Label labelThread2;
        private System.Windows.Forms.Button buttonAbortPrimeNumber;
        private System.Windows.Forms.Button buttonAbortFibinacciNumber;
        private System.Windows.Forms.Button buttonSuppentPrimeNumber;
        private System.Windows.Forms.Button buttonSuppentFiibinacciNumber;
        private System.Windows.Forms.Button buttonResumePrimeNumber;
        private System.Windows.Forms.Button buttonResumeFiibinacciNumber;
        private System.Windows.Forms.Button buttonRunPrimeNumber;
        private System.Windows.Forms.TextBox textBoxBeginRange;
        private System.Windows.Forms.Button buttonRestartPrimeNumber;
        private System.Windows.Forms.Button buttonRestartFibinacciNumber;
    }
}

