
namespace Task4
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
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelStatisticInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(13, 13);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(100, 17);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "Путь к файлу:";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Enabled = false;
            this.textBoxFilePath.Location = new System.Drawing.Point(119, 10);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(415, 22);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(549, 9);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 25);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Обзор";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(12, 43);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(109, 17);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = "Введите слово:";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(119, 40);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(120, 22);
            this.textBoxWord.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(13, 78);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 38);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "ПОИСК";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelStatisticInfo
            // 
            this.labelStatisticInfo.AutoSize = true;
            this.labelStatisticInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatisticInfo.Location = new System.Drawing.Point(12, 129);
            this.labelStatisticInfo.Name = "labelStatisticInfo";
            this.labelStatisticInfo.Size = new System.Drawing.Size(49, 17);
            this.labelStatisticInfo.TabIndex = 6;
            this.labelStatisticInfo.Text = "Инфо";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 487);
            this.Controls.Add(this.labelStatisticInfo);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelFilePath);
            this.Name = "FormMain";
            this.Text = "Асинхронность. Поиск слова в файле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelStatisticInfo;
    }
}

