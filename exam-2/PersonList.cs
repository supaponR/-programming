using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }
        

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }

        public void FetchPersonList(string name, string password, int status, string employeeID, string studentID)
        {

            //เพื่อแสดงค่าว่ามีอะไรอยู่ในlistPersonบ้าง
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    name = person.GetName();
                    password = person.GetPassword();
                    status = person.GetStatus();
                    
                }
                else if (person is Employee)
                {
                    name = person.GetName();
                    password = person.GetPassword();
                    status = person.GetStatus();
                }
            }
        }
    }
}
