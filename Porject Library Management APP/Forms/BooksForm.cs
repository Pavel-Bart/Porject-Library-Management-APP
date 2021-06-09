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
    public partial class BooksForm : Form
    {
        List<Book> BookList = new List<Book>();
        public BooksForm(List<Book> BookL)
        {
            BookList = BookL;
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ShowList(List<Book> BookList)
        {
            lstBook.Items.Clear();
            foreach (var item in BookList)
            {
                lstBook.Items.Add(item.BookName + ", " + item.Author + ", " + item.Price + "$, " + item.Quantity + "\n");
            }
        }
        private void BooksForm_Load(object sender, EventArgs e)
        {
            if (lstBook.SelectedIndex == -1)
            {
                btnDelete.Enabled = false;
            }
            ShowList(BookList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != string.Empty && txtAuthor.Text != string.Empty && txtPrice.Text != string.Empty && txtQuantity.Text != string.Empty)
            {

                foreach (var item in BookList)
                {
                    if (txtBookName.Text == item.BookName)
                    {
                        MessageBox.Show("This book already on the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                double price;
                Double.TryParse(txtPrice.Text, out price);
                int quant;
                Int32.TryParse(txtQuantity.Text, out quant);

                BookList.Add(new Book(txtBookName.Text, txtAuthor.Text,price ,quant));
                ShowList(BookList);
            }
            else
            {
                MessageBox.Show("All fields must be filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            string[] data; string dat;

            if (lstBook.SelectedItem == null)//tam kad isvengti error, paspaudziant ant listbox(white place)
            {
                txtBookName.Text = string.Empty;
                txtAuthor.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtQuantity.Text = string.Empty;

                btnDelete.Enabled = false;
                return;
            }
            else
            {
                dat = lstBook.SelectedItem.ToString();
            }

            data = dat.Split(',');

            txtBookName.Text = data[0];
            txtAuthor.Text = data[1];
            txtPrice.Text = data[2];
            txtQuantity.Text = data[3];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] data;
            if (lstBook.SelectedItem == null)
            {
                return;
            }
            else
            {
                data = lstBook.SelectedItem.ToString().Split(' ');
            }
            txtBookName.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;

            int removal = lstBook.SelectedIndex;
            BookList.RemoveAt(removal);

            ShowList(BookList);

            btnDelete.Enabled = false;
        }
    }
}
