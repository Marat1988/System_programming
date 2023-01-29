
namespace MainApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelChooseOperation = new System.Windows.Forms.Label();
            this.comboBoxChooseOperation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumber2 = new System.Windows.Forms.NumericUpDown();
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.numericUpDownNumber1 = new System.Windows.Forms.NumericUpDown();
            this.buttonRunProcess = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelChooseOperation);
            this.groupBox1.Controls.Add(this.comboBoxChooseOperation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownNumber2);
            this.groupBox1.Controls.Add(this.labelNumber1);
            this.groupBox1.Controls.Add(this.numericUpDownNumber1);
            this.groupBox1.Controls.Add(this.buttonRunProcess);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 206);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Аргументы командной строки:";
            // 
            // labelChooseOperation
            // 
            this.labelChooseOperation.AutoSize = true;
            this.labelChooseOperation.Location = new System.Drawing.Point(15, 94);
            this.labelChooseOperation.Name = "labelChooseOperation";
            this.labelChooseOperation.Size = new System.Drawing.Size(113, 13);
            this.labelChooseOperation.TabIndex = 8;
            this.labelChooseOperation.Text = "Выберите операцию:";
            // 
            // comboBoxChooseOperation
            // 
            this.comboBoxChooseOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseOperation.FormattingEnabled = true;
            this.comboBoxChooseOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxChooseOperation.Location = new System.Drawing.Point(134, 91);
            this.comboBoxChooseOperation.Name = "comboBoxChooseOperation";
            this.comboBoxChooseOperation.Size = new System.Drawing.Size(71, 21);
            this.comboBoxChooseOperation.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Число 2:";
            // 
            // numericUpDownNumber2
            // 
            this.numericUpDownNumber2.Location = new System.Drawing.Point(72, 59);
            this.numericUpDownNumber2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownNumber2.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownNumber2.Name = "numericUpDownNumber2";
            this.numericUpDownNumber2.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownNumber2.TabIndex = 5;
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(15, 30);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(51, 13);
            this.labelNumber1.TabIndex = 4;
            this.labelNumber1.Text = "Число 1:";
            // 
            // numericUpDownNumber1
            // 
            this.numericUpDownNumber1.Location = new System.Drawing.Point(72, 28);
            this.numericUpDownNumber1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownNumber1.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownNumber1.Name = "numericUpDownNumber1";
            this.numericUpDownNumber1.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownNumber1.TabIndex = 3;
            // 
            // buttonRunProcess
            // 
            this.buttonRunProcess.Location = new System.Drawing.Point(18, 118);
            this.buttonRunProcess.Name = "buttonRunProcess";
            this.buttonRunProcess.Size = new System.Drawing.Size(187, 61);
            this.buttonRunProcess.TabIndex = 2;
            this.buttonRunProcess.Text = "Запустить процесс";
            this.buttonRunProcess.UseVisualStyleBackColor = true;
            this.buttonRunProcess.Click += new System.EventHandler(this.buttonRunProcess_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 310);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Запуск процесса с аргументами командной строки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber1;
        private System.Windows.Forms.Button buttonRunProcess;
        private System.Windows.Forms.ComboBox comboBoxChooseOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber2;
        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelChooseOperation;
    }
}

