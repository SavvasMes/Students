using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Models
{
    public class Student
    {
        private string name { get; set; }
        private string surname { get; set; }
        private string id { get; set; }


        public Student(string firstname, string lastname, string lid)
        {
            name = firstname;
            surname = lastname;
            id = lid;
        }

    }
}
