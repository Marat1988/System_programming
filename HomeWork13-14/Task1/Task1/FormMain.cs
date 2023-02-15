using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1Library;

namespace Task1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonInfo.Click += ButtonInfo_Click;
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Площадь квадрата со сторонами, длинной 5 условных единиц равна = {Formulas.GetSquareArea(5)}", "INFORMATON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"Площадь прямоугольника с длинной 5 условные единиц и шириной 6 условных единиц равна {Formulas.GetSquareAreaRectangle(5, 6)}", "INFORMATON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"Площадь прямоугольного треугольника с длинами катетов 10 и 20 условных единиц равно {Formulas.GetAreaRightTriangle(10, 20)}", "INFORMATON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"Площадь треугольника с длинами сторон 6, 8, 10 равно {Formulas.GetAreaHeronFormula(6, 8, 10)}", "INFORMATON", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
