
namespace Task6
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
            this.listBoxPlayerLog = new System.Windows.Forms.ListBox();
            this.labelPlayerLog = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPlayerLog
            // 
            this.listBoxPlayerLog.FormattingEnabled = true;
            this.listBoxPlayerLog.HorizontalScrollbar = true;
            this.listBoxPlayerLog.Location = new System.Drawing.Point(9, 31);
            this.listBoxPlayerLog.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPlayerLog.Name = "listBoxPlayerLog";
            this.listBoxPlayerLog.ScrollAlwaysVisible = true;
            this.listBoxPlayerLog.Size = new System.Drawing.Size(778, 316);
            this.listBoxPlayerLog.TabIndex = 0;
            // 
            // labelPlayerLog
            // 
            this.labelPlayerLog.AutoSize = true;
            this.labelPlayerLog.Location = new System.Drawing.Point(9, 7);
            this.labelPlayerLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerLog.Name = "labelPlayerLog";
            this.labelPlayerLog.Size = new System.Drawing.Size(75, 13);
            this.labelPlayerLog.TabIndex = 1;
            this.labelPlayerLog.Text = "Лог событий:";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGame.Location = new System.Drawing.Point(11, 362);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(82, 28);
            this.buttonStartGame.TabIndex = 6;
            this.buttonStartGame.Text = "Погнали!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(219, 362);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(49, 16);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Инфо";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 543);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelPlayerLog);
            this.Controls.Add(this.listBoxPlayerLog);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Имитация казино (рулетка)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayerLog;
        private System.Windows.Forms.Label labelPlayerLog;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label labelInfo;
    }
}

