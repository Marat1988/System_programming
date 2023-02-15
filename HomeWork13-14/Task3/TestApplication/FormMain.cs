using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            MessageBox.Show(IsNumberTelephone("+7(911)475-34-83").ToString());

        }



        public bool IsNumberTelephone(string text)
        {
            return Regex.IsMatch(text, @"\+7\((\d{3})\)\d{3}-\d{2}-\d{2}");
        }
    }
}
