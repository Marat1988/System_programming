
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOpenChild = new System.Windows.Forms.Button();
            this.buttonSendStyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelInfo.Location = new System.Drawing.Point(24, 24);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(594, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Главное приложение для смены стилей элементов управления (шрифт, начертание и т.д" +
    ".) в дочернем приложении.";
            // 
            // buttonOpenChild
            // 
            this.buttonOpenChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonOpenChild.Location = new System.Drawing.Point(27, 54);
            this.buttonOpenChild.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonOpenChild.Name = "buttonOpenChild";
            this.buttonOpenChild.Size = new System.Drawing.Size(246, 45);
            this.buttonOpenChild.TabIndex = 2;
            this.buttonOpenChild.Text = "Открыть дочернее приложение";
            this.buttonOpenChild.UseVisualStyleBackColor = true;
            this.buttonOpenChild.Click += new System.EventHandler(this.buttonOpenChild_Click);
            // 
            // buttonSendStyle
            // 
            this.buttonSendStyle.Location = new System.Drawing.Point(27, 118);
            this.buttonSendStyle.Name = "buttonSendStyle";
            this.buttonSendStyle.Size = new System.Drawing.Size(246, 43);
            this.buttonSendStyle.TabIndex = 4;
            this.buttonSendStyle.Text = "Присвоить размер шрифта, шрифт в дочернюю форму";
            this.buttonSendStyle.UseVisualStyleBackColor = true;
            this.buttonSendStyle.Click += new System.EventHandler(this.buttonSendStyle_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSendStyle);
            this.Controls.Add(this.buttonOpenChild);
            this.Controls.Add(this.labelInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormMain";
            this.Text = "Главное приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonOpenChild;
        private System.Windows.Forms.Button buttonSendStyle;
    }
}

