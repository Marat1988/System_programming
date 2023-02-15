
namespace TestApplication
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
            this.buttonChooseFIO = new System.Windows.Forms.Button();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxTelNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelTelNumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonChooseTelNumber = new System.Windows.Forms.Button();
            this.buttonChooseEmail = new System.Windows.Forms.Button();
            this.buttonChooseAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChooseFIO
            // 
            this.buttonChooseFIO.Location = new System.Drawing.Point(263, 10);
            this.buttonChooseFIO.Name = "buttonChooseFIO";
            this.buttonChooseFIO.Size = new System.Drawing.Size(81, 22);
            this.buttonChooseFIO.TabIndex = 0;
            this.buttonChooseFIO.Text = "Проверка";
            this.buttonChooseFIO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonChooseFIO.UseVisualStyleBackColor = true;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(53, 12);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(194, 20);
            this.textBoxFIO.TabIndex = 1;
            this.textBoxFIO.Text = "Тухтаров Марат Ринадович";
            // 
            // textBoxTelNumber
            // 
            this.textBoxTelNumber.Location = new System.Drawing.Point(114, 38);
            this.textBoxTelNumber.Name = "textBoxTelNumber";
            this.textBoxTelNumber.Size = new System.Drawing.Size(133, 20);
            this.textBoxTelNumber.TabIndex = 2;
            this.textBoxTelNumber.Text = "+7(911)475-34-83";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(53, 64);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(194, 20);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "pirat03071988@mail.ru";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(74, 90);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(173, 20);
            this.textBoxAge.TabIndex = 4;
            this.textBoxAge.Text = "34";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 15);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 5;
            this.labelFIO.Text = "ФИО:";
            // 
            // labelTelNumber
            // 
            this.labelTelNumber.AutoSize = true;
            this.labelTelNumber.Location = new System.Drawing.Point(12, 41);
            this.labelTelNumber.Name = "labelTelNumber";
            this.labelTelNumber.Size = new System.Drawing.Size(96, 13);
            this.labelTelNumber.TabIndex = 6;
            this.labelTelNumber.Text = "Номер телефона:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 67);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 93);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(52, 13);
            this.labelAge.TabIndex = 8;
            this.labelAge.Text = "Возраст:";
            // 
            // buttonChooseTelNumber
            // 
            this.buttonChooseTelNumber.Location = new System.Drawing.Point(263, 36);
            this.buttonChooseTelNumber.Name = "buttonChooseTelNumber";
            this.buttonChooseTelNumber.Size = new System.Drawing.Size(81, 22);
            this.buttonChooseTelNumber.TabIndex = 9;
            this.buttonChooseTelNumber.Text = "Проверка";
            this.buttonChooseTelNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonChooseTelNumber.UseVisualStyleBackColor = true;
            // 
            // buttonChooseEmail
            // 
            this.buttonChooseEmail.Location = new System.Drawing.Point(263, 62);
            this.buttonChooseEmail.Name = "buttonChooseEmail";
            this.buttonChooseEmail.Size = new System.Drawing.Size(81, 22);
            this.buttonChooseEmail.TabIndex = 10;
            this.buttonChooseEmail.Text = "Проверка";
            this.buttonChooseEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonChooseEmail.UseVisualStyleBackColor = true;
            // 
            // buttonChooseAge
            // 
            this.buttonChooseAge.Location = new System.Drawing.Point(263, 88);
            this.buttonChooseAge.Name = "buttonChooseAge";
            this.buttonChooseAge.Size = new System.Drawing.Size(81, 22);
            this.buttonChooseAge.TabIndex = 11;
            this.buttonChooseAge.Text = "Проверка";
            this.buttonChooseAge.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonChooseAge.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 323);
            this.Controls.Add(this.buttonChooseAge);
            this.Controls.Add(this.buttonChooseEmail);
            this.Controls.Add(this.buttonChooseTelNumber);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.labelTelNumber);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelNumber);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.buttonChooseFIO);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Проверка библиотеки. Тестовое приложение.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxTelNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelTelNumber;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonChooseTelNumber;
        private System.Windows.Forms.Button buttonChooseEmail;
        private System.Windows.Forms.Button buttonChooseAge;
    }
}

