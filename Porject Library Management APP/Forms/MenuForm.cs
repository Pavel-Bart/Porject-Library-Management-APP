using Porject_Library_Management_APP.ZForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porject_Library_Management_APP
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLibrarians_Click(object sender, EventArgs e)
        {
            LibrariansForm LibForm = new LibrariansForm();
            this.Hide();
            LibForm.ShowDialog();
            this.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentsForm studForm = new StudentsForm();
            this.Hide();
            studForm.ShowDialog();
            this.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksForm bookForm = new BooksForm();
            this.Hide();
            bookForm.ShowDialog();
            this.Show();
        }
    }
}
