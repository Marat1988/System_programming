
namespace MainApplication
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPathToTheFile = new System.Windows.Forms.TextBox();
            this.labelPathToTheFile = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRunProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPathToTheFile
            // 
            this.textBoxPathToTheFile.Location = new System.Drawing.Point(281, 44);
            this.textBoxPathToTheFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPathToTheFile.Name = "textBoxPathToTheFile";
            this.textBoxPathToTheFile.Size = new System.Drawing.Size(373, 27);
            this.textBoxPathToTheFile.TabIndex = 0;
            this.textBoxPathToTheFile.TextChanged += new System.EventHandler(this.textBoxPathToTheFile_TextChanged);
            // 
            // labelPathToTheFile
            // 
            this.labelPathToTheFile.AutoSize = true;
            this.labelPathToTheFile.Location = new System.Drawing.Point(14, 47);
            this.labelPathToTheFile.Name = "labelPathToTheFile";
            this.labelPathToTheFile.Size = new System.Drawing.Size(248, 20);
            this.labelPathToTheFile.TabIndex = 1;
            this.labelPathToTheFile.Text = "Параметр 1: укажите путь к файлу:";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(675, 42);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(107, 31);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Обзор";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(374, 94);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(155, 27);
            this.textBoxWord.TabIndex = 3;
            this.textBoxWord.TextChanged += new System.EventHandler(this.textBoxPathToTheFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Параметр 2: укажите слово для поиска в файле:";
            // 
            // buttonRunProcess
            // 
            this.buttonRunProcess.Location = new System.Drawing.Point(14, 145);
            this.buttonRunProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRunProcess.Name = "buttonRunProcess";
            this.buttonRunProcess.Size = new System.Drawing.Size(208, 75);
            this.buttonRunProcess.TabIndex = 5;
            this.buttonRunProcess.Text = "Запустить дочерний процесс";
            this.buttonRunProcess.UseVisualStyleBackColor = true;
            this.buttonRunProcess.Click += new System.EventHandler(this.buttonRunProcess_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 600);
            this.Controls.Add(this.buttonRunProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelPathToTheFile);
            this.Controls.Add(this.textBoxPathToTheFile);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Тестовое приложение. Запуск дочернего процесса с аргументами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPathToTheFile;
        private System.Windows.Forms.Label labelPathToTheFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRunProcess;
    }
}

