using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porject_Library_Management_APP
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Class { get; set; }

        public Student(string name, string surname,string phone, string Clas)
        {
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
            this.Class = Clas;
        }
    }
}
