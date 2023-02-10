
namespace Task1
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
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.ItemHeight = 16;
            this.listBoxLog.Location = new System.Drawing.Point(12, 38);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(675, 244);
            this.listBoxLog.TabIndex = 0;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.Location = new System.Drawing.Point(12, 9);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(107, 17);
            this.labelLog.TabIndex = 1;
            this.labelLog.Text = "Лог событий:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 298);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(125, 59);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 510);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.listBoxLog);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "События. Тестовое приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonStart;
    }
}

