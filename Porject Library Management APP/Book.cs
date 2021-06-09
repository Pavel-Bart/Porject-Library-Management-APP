using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porject_Library_Management_APP
{
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Book(string name, string author, double price, int quantity)
        {
            this.BookName = name;
            this.Author = author;
            this.Price = price;
            this.Quantity = quantity;
        }

    }
}
