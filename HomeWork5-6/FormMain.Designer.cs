
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
            this.SuspendLayout();
            // 
            // listBoxThreadPrimeNumber
            // 
            this.listBoxThreadPrimeNumber.FormattingEnabled = true;
            this.listBoxThreadPrimeNumber.Location = new System.Drawing.Point(15, 44);
            this.listBoxThreadPrimeNumber.Name = "listBoxThreadPrimeNumber";
            this.listBoxThreadPrimeNumber.ScrollAlwaysVisible = true;
            this.listBoxThreadPrimeNumber.Size = new System.Drawing.Size(166, 355);
            this.listBoxThreadPrimeNumber.TabIndex = 0;
            // 
            // labelThread1
            // 
            this.labelThread1.AutoSize = true;
            this.labelThread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThread1.Location = new System.Drawing.Point(12, 23);
            this.labelThread1.Name = "labelThread1";
            this.labelThread1.Size = new System.Drawing.Size(169, 15);
            this.labelThread1.TabIndex = 1;
            this.labelThread1.Text = "Поток 1. Простые числа";
            // 
            // textBoxEndRange
            // 
            this.textBoxEndRange.Location = new System.Drawing.Point(289, 75);
            this.textBoxEndRange.Name = "textBoxEndRange";
            this.textBoxEndRange.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndRange.TabIndex = 3;
            this.textBoxEndRange.Text = "100000";
            this.textBoxEndRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxEndRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBeginRange_KeyPress);
            // 
            // labelBeginRange
            // 
            this.labelBeginRange.AutoSize = true;
            this.labelBeginRange.Location = new System.Drawing.Point(189, 48);
            this.labelBeginRange.Name = "labelBeginRange";
            this.labelBeginRange.Size = new System.Drawing.Size(94, 13);
            this.labelBeginRange.TabIndex = 4;
            this.labelBeginRange.Text = "Нижняя граница:";
            // 
            // labelEndRange
            // 
            this.labelEndRange.AutoSize = true;
            this.labelEndRange.Location = new System.Drawing.Point(187, 75);
            this.labelEndRange.Name = "labelEndRange";
            this.labelEndRange.Size = new System.Drawing.Size(96, 13);
            this.labelEndRange.TabIndex = 5;
            this.labelEndRange.Text = "Верхняя граница:";
            // 
            // buttonRunFibinacciNumber
            // 
            this.buttonRunFibinacciNumber.Location = new System.Drawing.Point(445, 405);
            this.buttonRunFibinacciNumber.Name = "buttonRunFibinacciNumber";
            this.buttonRunFibinacciNumber.Size = new System.Drawing.Size(166, 24);
            this.buttonRunFibinacciNumber.TabIndex = 6;
            this.buttonRunFibinacciNumber.Text = "Run\\Restart";
            this.buttonRunFibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonRunFibinacciNumber.Click += new System.EventHandler(this.buttonRunFibinacciNumber_Click);
            // 
            // listBoxThreadFibinacciNumber
            // 
            this.listBoxThreadFibinacciNumber.FormattingEnabled = true;
            this.listBoxThreadFibinacciNumber.Location = new System.Drawing.Point(445, 44);
            this.listBoxThreadFibinacciNumber.Name = "listBoxThreadFibinacciNumber";
            this.listBoxThreadFibinacciNumber.ScrollAlwaysVisible = true;
            this.listBoxThreadFibinacciNumber.Size = new System.Drawing.Size(169, 355);
            this.listBoxThreadFibinacciNumber.TabIndex = 7;
            // 
            // labelThread2
            // 
            this.labelThread2.AutoSize = true;
            this.labelThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThread2.Location = new System.Drawing.Point(442, 23);
            this.labelThread2.Name = "labelThread2";
            this.labelThread2.Size = new System.Drawing.Size(186, 15);
            this.labelThread2.TabIndex = 8;
            this.labelThread2.Text = "Поток 2. Числа Фибоначчи";
            // 
            // buttonAbortPrimeNumber
            // 
            this.buttonAbortPrimeNumber.Location = new System.Drawing.Point(15, 435);
            this.buttonAbortPrimeNumber.Name = "buttonAbortPrimeNumber";
            this.buttonAbortPrimeNumber.Size = new System.Drawing.Size(166, 24);
            this.buttonAbortPrimeNumber.TabIndex = 9;
            this.buttonAbortPrimeNumber.Text = "Abort";
            this.buttonAbortPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonAbortPrimeNumber.Click += new System.EventHandler(this.buttonAbortPrimeNumber_Click);
            // 
            // buttonAbortFibinacciNumber
            // 
            this.buttonAbortFibinacciNumber.Location = new System.Drawing.Point(445, 436);
            this.buttonAbortFibinacciNumber.Name = "buttonAbortFibinacciNumber";
            this.buttonAbortFibinacciNumber.Size = new System.Drawing.Size(166, 24);
            this.buttonAbortFibinacciNumber.TabIndex = 10;
            this.buttonAbortFibinacciNumber.Text = "Abort";
            this.buttonAbortFibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonAbortFibinacciNumber.Click += new System.EventHandler(this.buttonAbortFibinacciNumber_Click);
            // 
            // buttonSuppentPrimeNumber
            // 
            this.buttonSuppentPrimeNumber.Location = new System.Drawing.Point(15, 465);
            this.buttonSuppentPrimeNumber.Name = "buttonSuppentPrimeNumber";
            this.buttonSuppentPrimeNumber.Size = new System.Drawing.Size(166, 25);
            this.buttonSuppentPrimeNumber.TabIndex = 11;
            this.buttonSuppentPrimeNumber.Text = "Suppend";
            this.buttonSuppentPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonSuppentPrimeNumber.Click += new System.EventHandler(this.buttonSuppentPrimeNumber_Click);
            // 
            // buttonSuppentFiibinacciNumber
            // 
            this.buttonSuppentFiibinacciNumber.Location = new System.Drawing.Point(445, 467);
            this.buttonSuppentFiibinacciNumber.Name = "buttonSuppentFiibinacciNumber";
            this.buttonSuppentFiibinacciNumber.Size = new System.Drawing.Size(166, 25);
            this.buttonSuppentFiibinacciNumber.TabIndex = 12;
            this.buttonSuppentFiibinacciNumber.Text = "Suppend";
            this.buttonSuppentFiibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonSuppentFiibinacciNumber.Click += new System.EventHandler(this.buttonSuppentFiibinacciNumber_Click);
            // 
            // buttonResumePrimeNumber
            // 
            this.buttonResumePrimeNumber.Location = new System.Drawing.Point(15, 496);
            this.buttonResumePrimeNumber.Name = "buttonResumePrimeNumber";
            this.buttonResumePrimeNumber.Size = new System.Drawing.Size(166, 25);
            this.buttonResumePrimeNumber.TabIndex = 13;
            this.buttonResumePrimeNumber.Text = "Resume";
            this.buttonResumePrimeNumber.UseVisualStyleBackColor = true;
            this.buttonResumePrimeNumber.Click += new System.EventHandler(this.buttonResumePrimeNumber_Click);
            // 
            // buttonResumeFiibinacciNumber
            // 
            this.buttonResumeFiibinacciNumber.Location = new System.Drawing.Point(445, 498);
            this.buttonResumeFiibinacciNumber.Name = "buttonResumeFiibinacciNumber";
            this.buttonResumeFiibinacciNumber.Size = new System.Drawing.Size(166, 25);
            this.buttonResumeFiibinacciNumber.TabIndex = 14;
            this.buttonResumeFiibinacciNumber.Text = "Resume";
            this.buttonResumeFiibinacciNumber.UseVisualStyleBackColor = true;
            this.buttonResumeFiibinacciNumber.Click += new System.EventHandler(this.buttonResumeFiibinacciNumber_Click);
            // 
            // buttonRunPrimeNumber
            // 
            this.buttonRunPrimeNumber.Location = new System.Drawing.Point(15, 405);
            this.buttonRunPrimeNumber.Name = "buttonRunPrimeNumber";
            this.buttonRunPrimeNumber.Size = new System.Drawing.Size(166, 24);
            this.buttonRunPrimeNumber.TabIndex = 16;
            this.buttonRunPrimeNumber.Text = "Run\\Restart";
            this.buttonRunPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonRunPrimeNumber.Click += new System.EventHandler(this.buttonRunPrimeNumber_Click);
            // 
            // textBoxBeginRange
            // 
            this.textBoxBeginRange.Location = new System.Drawing.Point(289, 45);
            this.textBoxBeginRange.Name = "textBoxBeginRange";
            this.textBoxBeginRange.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeginRange.TabIndex = 17;
            this.textBoxBeginRange.Text = "2";
            this.textBoxBeginRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBeginRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBeginRange_KeyPress);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 531);
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
    }
}

