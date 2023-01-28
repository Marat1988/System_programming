
namespace Task1
{
    partial class FormTestProcess
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
            this.buttonStartCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartCalc
            // 
            this.buttonStartCalc.Location = new System.Drawing.Point(60, 29);
            this.buttonStartCalc.Name = "buttonStartCalc";
            this.buttonStartCalc.Size = new System.Drawing.Size(196, 84);
            this.buttonStartCalc.TabIndex = 0;
            this.buttonStartCalc.Text = "Запустить блокнот";
            this.buttonStartCalc.UseVisualStyleBackColor = true;
            this.buttonStartCalc.Click += new System.EventHandler(this.buttonStartCalc_Click);
            // 
            // FormTestProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 162);
            this.Controls.Add(this.buttonStartCalc);
            this.Name = "FormTestProcess";
            this.Text = "Тестовое приложение. Процесс.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartCalc;
    }
}

