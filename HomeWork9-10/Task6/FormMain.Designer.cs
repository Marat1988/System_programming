
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPlayerLog
            // 
            this.listBoxPlayerLog.FormattingEnabled = true;
            this.listBoxPlayerLog.HorizontalScrollbar = true;
            this.listBoxPlayerLog.ItemHeight = 16;
            this.listBoxPlayerLog.Location = new System.Drawing.Point(12, 38);
            this.listBoxPlayerLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPlayerLog.Name = "listBoxPlayerLog";
            this.listBoxPlayerLog.ScrollAlwaysVisible = true;
            this.listBoxPlayerLog.Size = new System.Drawing.Size(1036, 388);
            this.listBoxPlayerLog.TabIndex = 0;
            // 
            // labelPlayerLog
            // 
            this.labelPlayerLog.AutoSize = true;
            this.labelPlayerLog.Location = new System.Drawing.Point(12, 9);
            this.labelPlayerLog.Name = "labelPlayerLog";
            this.labelPlayerLog.Size = new System.Drawing.Size(95, 17);
            this.labelPlayerLog.TabIndex = 1;
            this.labelPlayerLog.Text = "Лог событий:";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGame.Location = new System.Drawing.Point(15, 446);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(109, 34);
            this.buttonStartGame.TabIndex = 6;
            this.buttonStartGame.Text = "Погнали!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(292, 446);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(60, 20);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Инфо";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(293, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Игрок выбывает, если сыграл 8 раундов или если у игрока закончились деньги";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelPlayerLog);
            this.Controls.Add(this.listBoxPlayerLog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
    }
}

