
namespace Task3
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
            this.numericUpDownBeginRange = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndRange = new System.Windows.Forms.NumericUpDown();
            this.labelBeginRange = new System.Windows.Forms.Label();
            this.labelEndRange = new System.Windows.Forms.Label();
            this.listBoxNumberFibinacci = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndRange)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownBeginRange
            // 
            this.numericUpDownBeginRange.Location = new System.Drawing.Point(156, 23);
            this.numericUpDownBeginRange.Name = "numericUpDownBeginRange";
            this.numericUpDownBeginRange.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBeginRange.TabIndex = 0;
            // 
            // numericUpDownEndRange
            // 
            this.numericUpDownEndRange.Location = new System.Drawing.Point(156, 66);
            this.numericUpDownEndRange.Name = "numericUpDownEndRange";
            this.numericUpDownEndRange.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownEndRange.TabIndex = 1;
            // 
            // labelBeginRange
            // 
            this.labelBeginRange.AutoSize = true;
            this.labelBeginRange.Location = new System.Drawing.Point(13, 23);
            this.labelBeginRange.Name = "labelBeginRange";
            this.labelBeginRange.Size = new System.Drawing.Size(137, 17);
            this.labelBeginRange.TabIndex = 2;
            this.labelBeginRange.Text = "Начало диапазона:";
            // 
            // labelEndRange
            // 
            this.labelEndRange.AutoSize = true;
            this.labelEndRange.Location = new System.Drawing.Point(13, 66);
            this.labelEndRange.Name = "labelEndRange";
            this.labelEndRange.Size = new System.Drawing.Size(128, 17);
            this.labelEndRange.TabIndex = 3;
            this.labelEndRange.Text = "Конец диапазона:";
            // 
            // listBoxNumberFibinacci
            // 
            this.listBoxNumberFibinacci.FormattingEnabled = true;
            this.listBoxNumberFibinacci.ItemHeight = 16;
            this.listBoxNumberFibinacci.Location = new System.Drawing.Point(296, 23);
            this.listBoxNumberFibinacci.Name = "listBoxNumberFibinacci";
            this.listBoxNumberFibinacci.ScrollAlwaysVisible = true;
            this.listBoxNumberFibinacci.Size = new System.Drawing.Size(190, 244);
            this.listBoxNumberFibinacci.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 103);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(114, 50);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 289);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxNumberFibinacci);
            this.Controls.Add(this.labelEndRange);
            this.Controls.Add(this.labelBeginRange);
            this.Controls.Add(this.numericUpDownEndRange);
            this.Controls.Add(this.numericUpDownBeginRange);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Числа Фибиначчи";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownBeginRange;
        private System.Windows.Forms.NumericUpDown numericUpDownEndRange;
        private System.Windows.Forms.Label labelBeginRange;
        private System.Windows.Forms.Label labelEndRange;
        private System.Windows.Forms.ListBox listBoxNumberFibinacci;
        private System.Windows.Forms.Button buttonStart;
    }
}

