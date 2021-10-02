using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Employee : Person
    {
        protected string employeeID;
        public Employee(string name, string password, int status, string employeeID)
        : base(name, password, status)
        {
            this.employeeID = employeeID;
        }

    }
}
