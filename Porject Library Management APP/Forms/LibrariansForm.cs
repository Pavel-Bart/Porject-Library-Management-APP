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
    public partial class LibrariansForm : Form
    {
        List<Librarian> LibrarianList = new List<Librarian>();


        public LibrariansForm(List<Librarian> Libr)
        {
            LibrarianList = Libr;

            InitializeComponent();
            if (lstLibrarian.SelectedIndex == -1)
            {
                btnDelete.Enabled = false;
            }
        }
        private void LibrariansForm_Load(object sender, EventArgs e)
        {
            ShowList(LibrarianList);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ShowList(List<Librarian> LibrarianList)
        {
            lstLibrarian.Items.Clear();
            foreach (var item in LibrarianList)
            {
                lstLibrarian.Items.Add(item.Name + " " + item.Username + " " + item.Password + " " + item.Phone + " " + "\n");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && txtPhone.Text != string.Empty)
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

                foreach (var item in LibrarianList)
                {
                    if (txtUsername.Text == item.Username)
                    {
                        MessageBox.Show("A person with such a Username, is already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                LibrarianList.Add(new Librarian(txtName.Text, txtUsername.Text, txtPassword.Text, txtPhone.Text));
                ShowList(LibrarianList);
            }
            else
            {
                MessageBox.Show("All fields must be filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstLibrarian_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            string[] data; string dat;

            if (lstLibrarian.SelectedItem == null)//tam kad isvengti error, paspaudziant ant listbox(white place)
            {
                txtName.Text = string.Empty;
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtPhone.Text = string.Empty;

                btnDelete.Enabled = false;
                return;
            }
            else
            {
                dat = lstLibrarian.SelectedItem.ToString();
            }

            data = dat.Split(' ');

            txtName.Text = data[0];
            txtUsername.Text = data[1];
            txtPassword.Text = data[2];
            txtPhone.Text = data[3];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] data;
            if (lstLibrarian.SelectedItem == null)
            {
                return;
            }
            else
            {
                data = lstLibrarian.SelectedItem.ToString().Split(' ');
            }

            if(data[1] == "NKKM")
            {
                MessageBox.Show("You can't delete default user", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;

            int removal = lstLibrarian.SelectedIndex;
            LibrarianList.RemoveAt(removal);

            ShowList(LibrarianList);

            btnDelete.Enabled = false;

        }


    }
}
