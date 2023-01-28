
namespace ChildApplication
{
    partial class FormChild
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
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonOutputFIO = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelColledge = new System.Windows.Forms.Label();
            this.textBoxColledge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(129, 12);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(211, 39);
            this.textBoxLastName.TabIndex = 0;
            this.textBoxLastName.Text = "Тухтаров";
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(13, 25);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(103, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Введите фамилию:";
            // 
            // buttonOutputFIO
            // 
            this.buttonOutputFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonOutputFIO.Location = new System.Drawing.Point(80, 255);
            this.buttonOutputFIO.Name = "buttonOutputFIO";
            this.buttonOutputFIO.Size = new System.Drawing.Size(206, 72);
            this.buttonOutputFIO.TabIndex = 2;
            this.buttonOutputFIO.Text = "Вывод ФИО";
            this.buttonOutputFIO.UseVisualStyleBackColor = true;
            this.buttonOutputFIO.Click += new System.EventHandler(this.buttonOutputFIO_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(129, 70);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(211, 39);
            this.textBoxFirstName.TabIndex = 3;
            this.textBoxFirstName.Text = "Марат";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(129, 130);
            this.textBoxMiddleName.Multiline = true;
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(211, 39);
            this.textBoxMiddleName.TabIndex = 4;
            this.textBoxMiddleName.Text = "Ринадович";
            this.textBoxMiddleName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(13, 83);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 13);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "Введите имя:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(13, 143);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(100, 13);
            this.labelMiddleName.TabIndex = 6;
            this.labelMiddleName.Text = "Введите отчество:";
            // 
            // labelColledge
            // 
            this.labelColledge.AutoSize = true;
            this.labelColledge.Location = new System.Drawing.Point(13, 202);
            this.labelColledge.Name = "labelColledge";
            this.labelColledge.Size = new System.Drawing.Size(110, 13);
            this.labelColledge.TabIndex = 8;
            this.labelColledge.Text = "Учебное заведение:";
            // 
            // textBoxColledge
            // 
            this.textBoxColledge.Location = new System.Drawing.Point(129, 189);
            this.textBoxColledge.Multiline = true;
            this.textBoxColledge.Name = "textBoxColledge";
            this.textBoxColledge.Size = new System.Drawing.Size(211, 41);
            this.textBoxColledge.TabIndex = 7;
            this.textBoxColledge.Text = "Академия \"ТОП\" г. Калининград";
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 357);
            this.Controls.Add(this.labelColledge);
            this.Controls.Add(this.textBoxColledge);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonOutputFIO);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Name = "FormChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Child Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonOutputFIO;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelColledge;
        private System.Windows.Forms.TextBox textBoxColledge;
    }
}

