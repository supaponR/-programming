using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Person
    {
        protected string name;
        protected string password;
        protected int status;

        public Person(string name, string password, int status)
        {
            this.name = name;
            this.password = password;
            this.status = status;
        }
        public string GetName()
        {
            return this.name;    
        }
        public int GetStatus()
        {

            return this.status;
        }
        public string GetPassword()
        {
            return this.password;
        }
    }
}
