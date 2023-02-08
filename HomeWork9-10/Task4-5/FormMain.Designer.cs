
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
            this.buttonReportShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(503, 43);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(157, 80);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.ItemHeight = 16;
            this.listBoxLog.Location = new System.Drawing.Point(24, 43);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(459, 292);
            this.listBoxLog.TabIndex = 1;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(24, 20);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(95, 17);
            this.labelLog.TabIndex = 2;
            this.labelLog.Text = "Лог событий:";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(24, 372);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.Size = new System.Drawing.Size(357, 236);
            this.dataGridViewReport.TabIndex = 3;
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.Location = new System.Drawing.Point(24, 351);
            this.labelReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(49, 17);
            this.labelReport.TabIndex = 4;
            this.labelReport.Text = "Отчет";
            // 
            // buttonReportShow
            // 
            this.buttonReportShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReportShow.Location = new System.Drawing.Point(503, 129);
            this.buttonReportShow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReportShow.Name = "buttonReportShow";
            this.buttonReportShow.Size = new System.Drawing.Size(157, 81);
            this.buttonReportShow.TabIndex = 5;
            this.buttonReportShow.Text = "Вывести статистику";
            this.buttonReportShow.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 641);
            this.Controls.Add(this.buttonReportShow);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonReportShow;
    }
}

