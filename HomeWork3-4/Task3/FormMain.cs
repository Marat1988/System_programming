using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            comboBoxChooseOperation.SelectedIndex = 0;
        }

        private void buttonRunProcess_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = $"/k echo {numericUpDownNumber1.Value} {comboBoxChooseOperation.Text} {numericUpDownNumber2.Value} = &&" +
                $"set /a {numericUpDownNumber1.Value}{comboBoxChooseOperation.Text}{numericUpDownNumber2.Value}";
            Process.Start(info);
        }
    }
}
