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
        static List<Librarian> LibMenu = new List<Librarian>();
        static List<Student> StudentList = new List<Student>();

        static List<Book> BookList = new List<Book>();

        public MenuForm(List<Librarian> LibL)
        {
            LibMenu = LibL;//lista gauname is login form
            InitializeComponent();
        }
        

        private void MenuForm_Load(object sender, EventArgs e)
        {
            StudentList.Add(new Student("Vardenis", "Pavardenis", "37068113718", "IV"));
            BookList.Add(new Book("Harry Potter and the Philosopher's Stone", "J. K. Rowling", 25, 124));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLibrarians_Click(object sender, EventArgs e)
        {
            
            LibrariansForm LibForm = new LibrariansForm(LibMenu);//siunciu i Librarians form
            this.Hide();
            LibForm.ShowDialog();
            this.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentsForm studForm = new StudentsForm(StudentList);
            this.Hide();
            studForm.ShowDialog();
            this.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksForm bookForm = new BooksForm(BookList);
            this.Hide();
            bookForm.ShowDialog();
            this.Show();
        }
    }
}
