
namespace ApplicationTest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxSourceFileName = new System.Windows.Forms.TextBox();
            this.textBoxDestFileName = new System.Windows.Forms.TextBox();
            this.labelSourceFileName = new System.Windows.Forms.Label();
            this.labelDestFileName = new System.Windows.Forms.Label();
            this.checkBoxOverWrile = new System.Windows.Forms.CheckBox();
            this.buttonStartCopy = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonStartCopy);
            this.tabPage1.Controls.Add(this.checkBoxOverWrile);
            this.tabPage1.Controls.Add(this.labelDestFileName);
            this.tabPage1.Controls.Add(this.labelSourceFileName);
            this.tabPage1.Controls.Add(this.textBoxDestFileName);
            this.tabPage1.Controls.Add(this.textBoxSourceFileName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Копирование файла";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Копирование директорий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxSourceFileName
            // 
            this.textBoxSourceFileName.Location = new System.Drawing.Point(339, 21);
            this.textBoxSourceFileName.Name = "textBoxSourceFileName";
            this.textBoxSourceFileName.Size = new System.Drawing.Size(336, 20);
            this.textBoxSourceFileName.TabIndex = 0;
            // 
            // textBoxDestFileName
            // 
            this.textBoxDestFileName.Location = new System.Drawing.Point(338, 59);
            this.textBoxDestFileName.Name = "textBoxDestFileName";
            this.textBoxDestFileName.Size = new System.Drawing.Size(337, 20);
            this.textBoxDestFileName.TabIndex = 1;
            // 
            // labelSourceFileName
            // 
            this.labelSourceFileName.AutoSize = true;
            this.labelSourceFileName.Location = new System.Drawing.Point(8, 24);
            this.labelSourceFileName.Name = "labelSourceFileName";
            this.labelSourceFileName.Size = new System.Drawing.Size(324, 13);
            this.labelSourceFileName.TabIndex = 2;
            this.labelSourceFileName.Text = "Введите путь к исходному файлу, например: C:\\Test\\MyFile.txt)";
            // 
            // labelDestFileName
            // 
            this.labelDestFileName.AutoSize = true;
            this.labelDestFileName.Location = new System.Drawing.Point(8, 62);
            this.labelDestFileName.Name = "labelDestFileName";
            this.labelDestFileName.Size = new System.Drawing.Size(323, 13);
            this.labelDestFileName.TabIndex = 3;
            this.labelDestFileName.Text = "Введите имя нового файла, например: C:\\Test2\\NewMyFile.txt)";
            // 
            // checkBoxOverWrile
            // 
            this.checkBoxOverWrile.AutoSize = true;
            this.checkBoxOverWrile.Location = new System.Drawing.Point(11, 95);
            this.checkBoxOverWrile.Name = "checkBoxOverWrile";
            this.checkBoxOverWrile.Size = new System.Drawing.Size(208, 17);
            this.checkBoxOverWrile.TabIndex = 4;
            this.checkBoxOverWrile.Text = "Перезаписать существующий файл";
            this.checkBoxOverWrile.UseVisualStyleBackColor = true;
            // 
            // buttonStartCopy
            // 
            this.buttonStartCopy.Location = new System.Drawing.Point(11, 133);
            this.buttonStartCopy.Name = "buttonStartCopy";
            this.buttonStartCopy.Size = new System.Drawing.Size(180, 42);
            this.buttonStartCopy.TabIndex = 5;
            this.buttonStartCopy.Text = "Выполниить копирование";
            this.buttonStartCopy.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Тест библиотеки";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelDestFileName;
        private System.Windows.Forms.Label labelSourceFileName;
        private System.Windows.Forms.TextBox textBoxDestFileName;
        private System.Windows.Forms.TextBox textBoxSourceFileName;
        private System.Windows.Forms.CheckBox checkBoxOverWrile;
        private System.Windows.Forms.Button buttonStartCopy;
    }
}

