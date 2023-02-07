using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_5
{
    public partial class FormMain : Form
    {
        private string[] nameThread = { "Процесс заполнения файла числами", "Процесс перебора простых чисел", "Процесс перебора простых чисел по условию" };
        public FormMain()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;
            buttonReportShow.Click += ButtonReportShow_Click;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                buttonStart.Enabled = false;
                Worker worker = new Worker();
                worker.WorkBegin += Worker_WorkBegin;
                worker.WorkEnd += Worker_WorkEnd;
                Thread[] threads = new Thread[nameThread.Length];
                for (int i = 0; i < threads.Length; i++)
                {
                    threads[i] = new Thread(worker.Start);
                    threads[i].IsBackground = true;
                    threads[i].Name = nameThread[i];
                    threads[i].Start(i + 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Worker_WorkBegin(string info)
        {
            Action action = () => { listBoxLog.Items.Add(info); };
            this.InvokeEx(action);
        }
        private void Worker_WorkEnd(string info)
        {
            Action action = () => { listBoxLog.Items.Add(info); };
            this.InvokeEx(action);
        }

        private void ButtonReportShow_Click(object sender, EventArgs e)
        {
            dataGridViewReport.DataSource = null;
            buttonStart.Enabled = true;
            var sql = (from info in Worker.reports
                       select new
                       {
                           Количество_чисел = info.countNumber,
                           Размер_файла = info.sizeFile,
                           Контент = info.fileСontent.Substring(0, 1000)
                       }).ToList();
            dataGridViewReport.DataSource = sql;
        }
    }
}
