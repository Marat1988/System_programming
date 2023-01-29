
namespace Task2
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
            this.buttonProcessStart = new System.Windows.Forms.Button();
            this.buttonStopProcess = new System.Windows.Forms.Button();
            this.checkBoxChooseWait = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonProcessStart
            // 
            this.buttonProcessStart.Location = new System.Drawing.Point(57, 46);
            this.buttonProcessStart.Name = "buttonProcessStart";
            this.buttonProcessStart.Size = new System.Drawing.Size(245, 56);
            this.buttonProcessStart.TabIndex = 0;
            this.buttonProcessStart.Text = "Запустить процесс";
            this.buttonProcessStart.UseVisualStyleBackColor = true;
            this.buttonProcessStart.Click += new System.EventHandler(this.buttonProcessStart_Click);
            // 
            // buttonStopProcess
            // 
            this.buttonStopProcess.Location = new System.Drawing.Point(57, 108);
            this.buttonStopProcess.Name = "buttonStopProcess";
            this.buttonStopProcess.Size = new System.Drawing.Size(245, 65);
            this.buttonStopProcess.TabIndex = 1;
            this.buttonStopProcess.Text = "Принудительно завершить процесс";
            this.buttonStopProcess.UseVisualStyleBackColor = true;
            this.buttonStopProcess.Click += new System.EventHandler(this.buttonStopProcess_Click);
            // 
            // checkBoxChooseWait
            // 
            this.checkBoxChooseWait.AutoSize = true;
            this.checkBoxChooseWait.Location = new System.Drawing.Point(57, 23);
            this.checkBoxChooseWait.Name = "checkBoxChooseWait";
            this.checkBoxChooseWait.Size = new System.Drawing.Size(258, 17);
            this.checkBoxChooseWait.TabIndex = 2;
            this.checkBoxChooseWait.Text = "Запустить процесс с ожиданием завершения";
            this.checkBoxChooseWait.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 257);
            this.Controls.Add(this.checkBoxChooseWait);
            this.Controls.Add(this.buttonStopProcess);
            this.Controls.Add(this.buttonProcessStart);
            this.Name = "FormMain";
            this.Text = "Тест дочернего процесса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcessStart;
        private System.Windows.Forms.Button buttonStopProcess;
        private System.Windows.Forms.CheckBox checkBoxChooseWait;
    }
}

