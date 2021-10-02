using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Student : Person
    {
        protected string studentID;
        
        public Student(string name, string password, int status,string studentID)
        : base(name, password, status)
        {
            this.studentID = studentID;
        }

    }
}
