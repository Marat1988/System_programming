
namespace Task4_5
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.labelReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(302, 35);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(106, 51);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(18, 35);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(268, 238);
            this.listBoxLog.TabIndex = 1;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(18, 16);
            this.labelLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(75, 13);
            this.labelLog.TabIndex = 2;
            this.labelLog.Text = "Лог событий:";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(18, 301);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(268, 168);
            this.dataGridViewReport.TabIndex = 3;
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.Location = new System.Drawing.Point(18, 285);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(36, 13);
            this.labelReport.TabIndex = 4;
            this.labelReport.Text = "Отчет";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 541);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мьютекс. Текстовое приложение";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label labelReport;
    }
}

