using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Разработайте приложение, которое умеет запускать
дочерний процесс. В зависимости от выбора пользователя
родительское приложение должно ожидать завершения
дочернего процесса и отображать код завершения либо
принудительно завершать работу дочернего процесса.*/

namespace Task2
{
    public partial class FormMain : Form
    {
        private Process myProcess;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonProcessStart_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess = new Process();
                myProcess.StartInfo.FileName = "notepad.exe";
                myProcess.Start();
                if (checkBoxChooseWait.Checked)
                {
                    myProcess.WaitForExit();
                    if (myProcess.HasExited)
                    {
                        MessageBox.Show($"Процесс завершен. Код завершения: {myProcess.ExitCode}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                  
        }

        private void buttonStopProcess_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess?.CloseMainWindow();
                myProcess?.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
    }
}
