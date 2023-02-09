
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
            this.labelCurrentNumber = new System.Windows.Forms.Label();
            this.textBoxCurrentNumber = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.labelNumberFell = new System.Windows.Forms.Label();
            this.textBoxNumberFell = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxPlayerLog
            // 
            this.listBoxPlayerLog.FormattingEnabled = true;
            this.listBoxPlayerLog.ItemHeight = 16;
            this.listBoxPlayerLog.Location = new System.Drawing.Point(12, 38);
            this.listBoxPlayerLog.Name = "listBoxPlayerLog";
            this.listBoxPlayerLog.ScrollAlwaysVisible = true;
            this.listBoxPlayerLog.Size = new System.Drawing.Size(815, 388);
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
            // labelCurrentNumber
            // 
            this.labelCurrentNumber.AutoSize = true;
            this.labelCurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentNumber.Location = new System.Drawing.Point(12, 435);
            this.labelCurrentNumber.Name = "labelCurrentNumber";
            this.labelCurrentNumber.Size = new System.Drawing.Size(217, 29);
            this.labelCurrentNumber.TabIndex = 4;
            this.labelCurrentNumber.Text = "Текущий номер:";
            // 
            // textBoxCurrentNumber
            // 
            this.textBoxCurrentNumber.Enabled = false;
            this.textBoxCurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBoxCurrentNumber.Location = new System.Drawing.Point(235, 435);
            this.textBoxCurrentNumber.Name = "textBoxCurrentNumber";
            this.textBoxCurrentNumber.Size = new System.Drawing.Size(84, 34);
            this.textBoxCurrentNumber.TabIndex = 5;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGame.Location = new System.Drawing.Point(340, 435);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(109, 34);
            this.buttonStartGame.TabIndex = 6;
            this.buttonStartGame.Text = "Погнали!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            // 
            // labelNumberFell
            // 
            this.labelNumberFell.AutoSize = true;
            this.labelNumberFell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberFell.Location = new System.Drawing.Point(10, 615);
            this.labelNumberFell.Name = "labelNumberFell";
            this.labelNumberFell.Size = new System.Drawing.Size(239, 29);
            this.labelNumberFell.TabIndex = 7;
            this.labelNumberFell.Text = "Выпавший номер:";
            // 
            // textBoxNumberFell
            // 
            this.textBoxNumberFell.Enabled = false;
            this.textBoxNumberFell.Location = new System.Drawing.Point(265, 615);
            this.textBoxNumberFell.Multiline = true;
            this.textBoxNumberFell.Name = "textBoxNumberFell";
            this.textBoxNumberFell.Size = new System.Drawing.Size(100, 35);
            this.textBoxNumberFell.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 512);
            this.Controls.Add(this.textBoxNumberFell);
            this.Controls.Add(this.labelNumberFell);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.textBoxCurrentNumber);
            this.Controls.Add(this.labelCurrentNumber);
            this.Controls.Add(this.labelPlayerLog);
            this.Controls.Add(this.listBoxPlayerLog);
            this.Name = "FormMain";
            this.Text = "Имитация казино (рулетка)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayerLog;
        private System.Windows.Forms.Label labelPlayerLog;
        private System.Windows.Forms.Label labelCurrentNumber;
        private System.Windows.Forms.TextBox textBoxCurrentNumber;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label labelNumberFell;
        private System.Windows.Forms.TextBox textBoxNumberFell;
    }
}

