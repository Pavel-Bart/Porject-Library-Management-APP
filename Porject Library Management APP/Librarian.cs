using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porject_Library_Management_APP
{
    public class Librarian
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public Librarian(string name, string username, string password, string phone)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Phone = phone;
        }
    }
}
