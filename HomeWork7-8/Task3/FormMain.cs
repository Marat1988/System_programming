using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonStart.Click += ButtonStart_Click;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private async void Start()
        {
            ulong beginRange = (ulong)Math.Min(numericUpDownBeginRange.Value, numericUpDownEndRange.Value);
            ulong endRange = (ulong)Math.Max(numericUpDownBeginRange.Value, numericUpDownEndRange.Value);
            ulong number = 0;
            for (ulong i = beginRange; i <= endRange; i++)
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    number = Fibonachi(i);
                });
                listBoxNumberFibinacci.Items.Add(number);
            }
        }

        public ulong Fibonachi(ulong number)
        {
            if (number == 0 || number == 1) return number;
            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }
    }
}
