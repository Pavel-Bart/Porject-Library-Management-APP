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
        List<Student> StudentList = new List<Student>();
      
        public StudentsForm(List<Student> StudList)
        {
            StudentList = StudList;

            InitializeComponent();
            if (lstStudents.SelectedIndex == -1)
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
                char[] phone = txtPhone.Text.ToCharArray();//split by each character 

                if (phone.Length != 11)
                { MessageBox.Show("Field, phone, must contain no more or less than 11 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                for (int i = 0; i < 11; i++)
                {
                    if (phone[i] < '0' || phone[i] > '9')
                    {
                        MessageBox.Show("Field, phone, must contain only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                foreach (var item in StudentList)
                {
                    if(txtName.Text == item.Name && txtSurname.Text == item.Surname)
                    { 
                        MessageBox.Show("A person with such a name and surname, is already on the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

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
            string[] data; string dat;

            if (lstStudents.SelectedItem == null)//tam kad isvengti error, paspaudziant ant listbox(white place)
            {
                txtName.Text = string.Empty;
                txtSurname.Text = string.Empty;
                txtPhone.Text = string.Empty;
                cBoxClass.Text = string.Empty;

                btnDelete.Enabled = false;
                return;
            }
            else
            {
                dat = lstStudents.SelectedItem.ToString();
            }

            data = dat.Split(' ');

            txtName.Text = data[0];
            txtSurname.Text = data[1];
            txtPhone.Text = data[2];
            cBoxClass.Text = data[3];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] data;
            if (lstStudents.SelectedItem == null)
            {
                return;
            }
            else
            {
                data = lstStudents.SelectedItem.ToString().Split(' ');
            }
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cBoxClass.Text = string.Empty;

            int removal = lstStudents.SelectedIndex;
            StudentList.RemoveAt(removal);
            
            ShowList(StudentList);

            btnDelete.Enabled = false;
        }
    }
}
