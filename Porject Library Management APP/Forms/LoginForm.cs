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
    public partial class LoginForm : Form
    {
        List<Librarian> LibrariansList = new List<Librarian>();
        MenuForm menuForm = new MenuForm();
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Default
            LibrariansList.Add(new Librarian(0,"nkkm","nkkm"));
            txtPassword.UseSystemPasswordChar = true;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var item in LibrariansList)
            {
                if (txtUsername.Text == item.Username && txtPassword.Text == item.Password)
                {
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("Wrong username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPassword.Clear();
                txtUsername.Clear();

                this.Hide();
                menuForm.ShowDialog();
                this.Show();
            }
        }
    }
}
