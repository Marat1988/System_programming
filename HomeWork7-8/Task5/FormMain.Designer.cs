
namespace Task5
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
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonSearchWordInTextFile = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(13, 25);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(97, 17);
            this.labelFolderPath.TabIndex = 0;
            this.labelFolderPath.Text = "Путь к папке:";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Enabled = false;
            this.textBoxFolderPath.Location = new System.Drawing.Point(116, 22);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(393, 22);
            this.textBoxFolderPath.TabIndex = 1;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(515, 22);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 22);
            this.buttonOpenFolder.TabIndex = 2;
            this.buttonOpenFolder.Text = "ОБЗОР";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(13, 56);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(187, 17);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = "Введите слово для поиска:";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(206, 53);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(100, 22);
            this.textBoxWord.TabIndex = 4;
            // 
            // buttonSearchWordInTextFile
            // 
            this.buttonSearchWordInTextFile.Enabled = false;
            this.buttonSearchWordInTextFile.Location = new System.Drawing.Point(16, 87);
            this.buttonSearchWordInTextFile.Name = "buttonSearchWordInTextFile";
            this.buttonSearchWordInTextFile.Size = new System.Drawing.Size(204, 48);
            this.buttonSearchWordInTextFile.TabIndex = 5;
            this.buttonSearchWordInTextFile.Text = "Осуществить поиск слова в текстовых файлах";
            this.buttonSearchWordInTextFile.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(16, 154);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(69, 24);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Инфо:";
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(20, 205);
            this.dataGridViewStatistic.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            this.dataGridViewStatistic.RowHeadersWidth = 51;
            this.dataGridViewStatistic.Size = new System.Drawing.Size(497, 267);
            this.dataGridViewStatistic.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 544);
            this.Controls.Add(this.dataGridViewStatistic);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonSearchWordInTextFile);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.labelFolderPath);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Асинхронность. Поиск слова в текстовых файлах директории";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button buttonSearchWordInTextFile;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewStatistic;
    }
}

