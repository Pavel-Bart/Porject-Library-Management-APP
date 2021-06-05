using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porject_Library_Management_APP.ZForms
{
    public partial class StudentsForm : Form
    {
        List<Student> StudentList = new List<Student>()
        {
            new Student("Vardenis", "Pavardenis", "37068113718", "IV"),
            
        };
        public StudentsForm()
        {
            InitializeComponent();
            if(lstStudents.SelectedIndex == -1)
            {
                btnDelete.Enabled = false;
            }
        }
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            ShowList(StudentList);
          
        }

        void ShowList(List<Student> StudentList)
        {
            lstStudents.Items.Clear();
            foreach (var item in StudentList)
            {
                lstStudents.Items.Add(item.Name + " " + item.Surname + " " + item.Phone + " " + item.Class + "\n");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtSurname.Text != string.Empty && txtPhone.Text != string.Empty && cBoxClass.Text != string.Empty)
            {          
                StudentList.Add(new Student(txtName.Text, txtSurname.Text, txtPhone.Text, cBoxClass.Text));
                ShowList(StudentList);
            }
            else
            {
                MessageBox.Show("All fields must be filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            string[] data;  string dat;
            
            dat = lstStudents.SelectedItem.ToString();
            data = dat.Split(' ');

            txtName.Text = data[0];
            txtSurname.Text = data[1];
            txtPhone.Text = data[2];
            cBoxClass.Text = data[3];
        }
    }
}
