using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildApplication
{
    public partial class FormChild : Form
    {
        class Student
        {
            private readonly string lastName;
            private readonly string firstName;
            private readonly string middleName;
            private readonly string colledge;

            public Student(string lastName, string firstName, string middleName, string colledge)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.middleName = middleName;
                this.colledge = colledge;
            }

            public override string ToString()
            {
                return $"Фамилия: {lastName}\nИмя: {firstName}\nОтчество: {middleName}\nУчебное заведение: {colledge}";
            }
        }

        public FormChild()
        {
            InitializeComponent();
        }

        private void buttonOutputFIO_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBoxFirstName.Text, textBoxLastName.Text, textBoxMiddleName.Text, textBoxColledge.Text);
            MessageBox.Show(student.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            buttonOutputFIO.Enabled = !(string.IsNullOrEmpty(textBoxFirstName.Text)
                || string.IsNullOrEmpty(textBoxLastName.Text) || string.IsNullOrEmpty(textBoxMiddleName.Text));
        }
    }
}
