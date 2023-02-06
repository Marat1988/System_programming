
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
            this.listBoxNumberFibinachi = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelNumberFibinachi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndRange)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownBeginRange
            // 
            this.numericUpDownBeginRange.Location = new System.Drawing.Point(156, 23);
            this.numericUpDownBeginRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBeginRange.Name = "numericUpDownBeginRange";
            this.numericUpDownBeginRange.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBeginRange.TabIndex = 0;
            // 
            // numericUpDownEndRange
            // 
            this.numericUpDownEndRange.Location = new System.Drawing.Point(156, 66);
            this.numericUpDownEndRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEndRange.Name = "numericUpDownEndRange";
            this.numericUpDownEndRange.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownEndRange.TabIndex = 1;
            this.numericUpDownEndRange.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
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
            // listBoxNumberFibinachi
            // 
            this.listBoxNumberFibinachi.FormattingEnabled = true;
            this.listBoxNumberFibinachi.ItemHeight = 16;
            this.listBoxNumberFibinachi.Location = new System.Drawing.Point(296, 39);
            this.listBoxNumberFibinachi.Name = "listBoxNumberFibinachi";
            this.listBoxNumberFibinachi.ScrollAlwaysVisible = true;
            this.listBoxNumberFibinachi.Size = new System.Drawing.Size(190, 228);
            this.listBoxNumberFibinachi.TabIndex = 4;
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
            // labelNumberFibinachi
            // 
            this.labelNumberFibinachi.AutoSize = true;
            this.labelNumberFibinachi.Location = new System.Drawing.Point(293, 19);
            this.labelNumberFibinachi.Name = "labelNumberFibinachi";
            this.labelNumberFibinachi.Size = new System.Drawing.Size(134, 17);
            this.labelNumberFibinachi.TabIndex = 6;
            this.labelNumberFibinachi.Text = "Числа Фибиначчи:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 289);
            this.Controls.Add(this.labelNumberFibinachi);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxNumberFibinachi);
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
        private System.Windows.Forms.ListBox listBoxNumberFibinachi;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelNumberFibinachi;
    }
}

