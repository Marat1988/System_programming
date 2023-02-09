
namespace Task6
{
    partial class FormStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.AllowUserToAddRows = false;
            this.dataGridViewStatistic.AllowUserToDeleteRows = false;
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            this.dataGridViewStatistic.ReadOnly = true;
            this.dataGridViewStatistic.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewStatistic.TabIndex = 0;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStatistic);
            this.Name = "FormStatistic";
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatistic;
    }
}