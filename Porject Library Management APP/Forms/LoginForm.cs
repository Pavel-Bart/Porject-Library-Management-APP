﻿using System;
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
        static List<Librarian> LibrariansList = new List<Librarian>();
        MenuForm menuForm = new MenuForm(LibrariansList);
        
        public LoginForm()
        {
            InitializeComponent();
        }
        //LibrariansForm Lib = new LibrariansForm(LibrariansList);
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Default
            LibrariansList.Add(new Librarian("DEFAULT", "NKKM", "nkkm","37069224820"));
            txtPassword.UseSystemPasswordChar = true;

            txtUsername.Text = "NKKM";
            txtPassword.Text = "nkkm";

            MessageBox.Show("Default User: NKKM \nPass: nkkm ");

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
