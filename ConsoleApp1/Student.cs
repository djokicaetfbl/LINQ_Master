using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public Student(string firstName, string lastName, int[] marks)
        {
            FirstName = firstName;
            LastName = lastName;
            Marks = marks;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Marks { get; set; }
    }
}
