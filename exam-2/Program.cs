using System;
using System.Collections.Generic;
enum Menu
{ //กำหนดเลขหน้า
    Login = 1,
    Register,
}
enum Type
{
    Student = 1,
    Teacher,
}
enum MenuManagment
{
    BorrowBook = 1,
    GetListBooke,

}


namespace _2
{
    class Program
    {
        static PersonList personList;
        int total = 1;
        
        
        static void Main(string[] args)
        {
            PreparPersonListWhenProgramIsLoad();
            PrintMenuScreen();          
        }
        
        static Employee CreatNewEmployee()
        {
            return new Employee(InputName(),
                InputPassword(),
                InputUserType(),
                InputEmployeeID()); ;
        }
        static Student CreatNewStudent()
        {
            return new Student(InputName(),
                InputPassword(),
                InputUserType(),
                InputStudentID()); ;
        }

        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintPageMenu();
            InputMenuFromKeyboard();

        }
        static void PreparPersonListWhenProgramIsLoad()
        {
            Program.personList = new PersonList();
        }
        //ปริ้นหัวข้อ
        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("--------------------------");
        }

        //ปริ้นหน้าให้เลือกเมนู
        static void PrintPageMenu()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            
        }

        //ใส่เลขเพื่อนเลือก หน้าเมนู
        static void InputMenuFromKeyboard()
        {
            Console.Write("Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }
        static void InputNewEmpkoyeeFromKeyboard(int total)
        {
            for (int i = 0; i < total; i++)
            {
                Console.Clear();
                PrintHeadRegister();
                ShowHeadEmployeeScreen();
                Employee employee = CreatNewEmployee();

                Program.personList.AddNewPerson(employee);
            }

            Console.Clear();
            PrintMenuScreen();
        }
        static void InputNewStudentFromKeyboard(int total)
        {
            for (int i = 0; i < total; i++)
            {
                Console.Clear();
                PrintHeadRegister();
                ShowHeadEmployeeScreen();
                Student student = CreatNewStudent();

                Program.personList.AddNewPerson(student);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        //ปริ้นหัวข้อหน้า ล๊อคอิน
        static void PrintHeadLogin()
        {
            Console.Clear();
            Console.WriteLine("Login Screen");
            Console.WriteLine("------------");
        }
        //ปริ้นหัวข้อ หน้าลงทะเบียบ
        static void PrintHeadRegister()
        {
            Console.Clear();
            Console.WriteLine("Register new Person");
            Console.WriteLine("-------------------");
        }
        //หัวข้อหน้าเมนูของนักเรียน
        static void ShowHeadStudentScreen()
        {
            Console.WriteLine("Student Management");
            Console.WriteLine("------------------");
        }
        //หัวข้อหน้าเมนูEmployee
        static void ShowHeadEmployeeScreen()
        {
            Console.WriteLine("Employee Management");
            Console.WriteLine("-------------------");
        }
        //เลือกหน้าการทำงาน
        static void PresentMenu(Menu menu)
        {

            if (menu == Menu.Login)
            {
                ShowInputLoginScreen();

            }
            else if (menu == Menu.Register)
            {
                ShowInputRegisterScreen();
            }
            else
            {

            }
        }

        //แสดงหัวข้อให้ กรอกข้อมูลเพื่อ ล๊อคอิน
        static void ShowInputLoginScreen()
        {
            Console.Clear();
            PrintHeadLogin();
            InputName();
            InputPassword();
            
        }
        //แสดงหัวข้อให้ กรอกข้อมูลเพื่อ ลงทะเบียบ
        static void ShowInputRegisterScreen()
        {
            Console.Clear();
            PrintHeadRegister();
            InputName();
            InputPassword();
            switch (InputUserType())
            {
                case 1:
                    InputStudentID();
                    PrintMenuScreen();
                    break;
                case 2:
                    InputEmployeeID();
                    PrintMenuScreen();
                    break;
                    
            }
        }
        //แสดงเมนูสำหรับนักเรียน
        static void ShowStudentMenuScreen()
        {
            ShowHeadStudentScreen();
            //อย่าลืมเอาค่าชื่อSdID มาใส่
            Console.WriteLine("1. Borrow Book");
            InputMenuManagementFromKeyboard();
        }
        //แสดงเมนูสำหรับEmployee
        static void ShowEmployeeMenuScreen()
        {
            ShowHeadEmployeeScreen();
            //อย่าลืมเอาค่าชื่อEmID มาใส่
            Console.WriteLine("1. Get List Books");
            InputMenuManagementFromKeyboard();
        }
        //รับค่าเลือกเมนูmanagement
        static void InputMenuManagementFromKeyboard()
        {
            Console.Write("Input Menu: ");
            MenuManagment managemantMenu = (MenuManagment)(int.Parse(Console.ReadLine()));
        }
        



        //ตัวอินพุด
        static string InputName()
        {
            Console.Write("Input name: ");
            return Console.ReadLine();
        }
        static string InputPassword()
        {
            Console.Write("Input Password: ");
            return Console.ReadLine();
        }
        static int InputUserType()
        {
            Console.Write("Input User Type: ");
            return (int.Parse(Console.ReadLine()));
        }
        static string InputStudentID()
        {
            Console.Write("StudentID: ");
            return Console.ReadLine();
        }
        static string InputEmployeeID()
        {
            Console.Write("EmployeeID: ");
            return Console.ReadLine();
        }


        




    }
}
