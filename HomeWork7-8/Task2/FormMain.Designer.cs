
namespace Task2
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
            this.Horse1 = new System.Windows.Forms.ProgressBar();
            this.Horse2 = new System.Windows.Forms.ProgressBar();
            this.labelHorse1 = new System.Windows.Forms.Label();
            this.labelHorse2 = new System.Windows.Forms.Label();
            this.labelHorse3 = new System.Windows.Forms.Label();
            this.labelHorse4 = new System.Windows.Forms.Label();
            this.labelHorse5 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.Horse3 = new System.Windows.Forms.ProgressBar();
            this.Horse4 = new System.Windows.Forms.ProgressBar();
            this.Horse5 = new System.Windows.Forms.ProgressBar();
            this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // Horse1
            // 
            this.Horse1.Location = new System.Drawing.Point(98, 22);
            this.Horse1.Maximum = 200;
            this.Horse1.Name = "Horse1";
            this.Horse1.Size = new System.Drawing.Size(769, 23);
            this.Horse1.TabIndex = 0;
            // 
            // Horse2
            // 
            this.Horse2.Location = new System.Drawing.Point(98, 51);
            this.Horse2.Maximum = 200;
            this.Horse2.Name = "Horse2";
            this.Horse2.Size = new System.Drawing.Size(769, 23);
            this.Horse2.TabIndex = 1;
            // 
            // labelHorse1
            // 
            this.labelHorse1.AutoSize = true;
            this.labelHorse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHorse1.Location = new System.Drawing.Point(12, 27);
            this.labelHorse1.Name = "labelHorse1";
            this.labelHorse1.Size = new System.Drawing.Size(80, 13);
            this.labelHorse1.TabIndex = 5;
            this.labelHorse1.Text = "Лошадь №1:";
            // 
            // labelHorse2
            // 
            this.labelHorse2.AutoSize = true;
            this.labelHorse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHorse2.Location = new System.Drawing.Point(12, 55);
            this.labelHorse2.Name = "labelHorse2";
            this.labelHorse2.Size = new System.Drawing.Size(80, 13);
            this.labelHorse2.TabIndex = 6;
            this.labelHorse2.Text = "Лошадь №2:";
            // 
            // labelHorse3
            // 
            this.labelHorse3.AutoSize = true;
            this.labelHorse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHorse3.Location = new System.Drawing.Point(12, 85);
            this.labelHorse3.Name = "labelHorse3";
            this.labelHorse3.Size = new System.Drawing.Size(80, 13);
            this.labelHorse3.TabIndex = 7;
            this.labelHorse3.Text = "Лошадь №3:";
            // 
            // labelHorse4
            // 
            this.labelHorse4.AutoSize = true;
            this.labelHorse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHorse4.Location = new System.Drawing.Point(12, 115);
            this.labelHorse4.Name = "labelHorse4";
            this.labelHorse4.Size = new System.Drawing.Size(80, 13);
            this.labelHorse4.TabIndex = 8;
            this.labelHorse4.Text = "Лошадь №4:";
            // 
            // labelHorse5
            // 
            this.labelHorse5.AutoSize = true;
            this.labelHorse5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHorse5.Location = new System.Drawing.Point(12, 142);
            this.labelHorse5.Name = "labelHorse5";
            this.labelHorse5.Size = new System.Drawing.Size(80, 13);
            this.labelHorse5.TabIndex = 9;
            this.labelHorse5.Text = "Лошадь №5:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(98, 179);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 35);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // Horse3
            // 
            this.Horse3.Location = new System.Drawing.Point(98, 80);
            this.Horse3.Maximum = 200;
            this.Horse3.Name = "Horse3";
            this.Horse3.Size = new System.Drawing.Size(769, 23);
            this.Horse3.TabIndex = 12;
            // 
            // Horse4
            // 
            this.Horse4.Location = new System.Drawing.Point(98, 109);
            this.Horse4.Maximum = 200;
            this.Horse4.Name = "Horse4";
            this.Horse4.Size = new System.Drawing.Size(769, 23);
            this.Horse4.TabIndex = 13;
            // 
            // Horse5
            // 
            this.Horse5.Location = new System.Drawing.Point(98, 138);
            this.Horse5.Maximum = 200;
            this.Horse5.Name = "Horse5";
            this.Horse5.Size = new System.Drawing.Size(769, 23);
            this.Horse5.TabIndex = 14;
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(15, 231);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            this.dataGridViewStatistic.Size = new System.Drawing.Size(373, 217);
            this.dataGridViewStatistic.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 490);
            this.Controls.Add(this.dataGridViewStatistic);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelHorse1);
            this.Controls.Add(this.labelHorse2);
            this.Controls.Add(this.labelHorse3);
            this.Controls.Add(this.labelHorse4);
            this.Controls.Add(this.labelHorse5);
            this.Controls.Add(this.Horse1);
            this.Controls.Add(this.Horse2);
            this.Controls.Add(this.Horse3);
            this.Controls.Add(this.Horse4);
            this.Controls.Add(this.Horse5);
            this.Name = "FormMain";
            this.Text = "Эмуляция конных скачек";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Horse1;
        private System.Windows.Forms.ProgressBar Horse2;
        private System.Windows.Forms.Label labelHorse1;
        private System.Windows.Forms.Label labelHorse2;
        private System.Windows.Forms.Label labelHorse3;
        private System.Windows.Forms.Label labelHorse4;
        private System.Windows.Forms.Label labelHorse5;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar Horse3;
        private System.Windows.Forms.ProgressBar Horse4;
        private System.Windows.Forms.ProgressBar Horse5;
        private System.Windows.Forms.DataGridView dataGridViewStatistic;
    }
}

