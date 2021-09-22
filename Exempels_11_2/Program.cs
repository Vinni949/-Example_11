using System;

namespace Exempels_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementDepartament mDep = new ManagementDepartament();

            TestData(mDep);

            bool choice = true;
            while (choice)
            {
                string text = string.Empty;
                Console.WriteLine();
                Console.WriteLine("Введите номер: \n1-Печатать все департаменты и работников, \n2-добавить департамент,\n3-добавить сотрудника \n0 - exit");
                switch (Console.ReadKey().Key)
                {

                    case ConsoleKey.D1:
                        Console.WriteLine();
                        mDep.PrintOrganisation();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine("Введите название департамента в который добавить департамент:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Введите название нового департамента:");
                        string newTitle = Console.ReadLine();
                        mDep.AddDep(title, newTitle);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine("Добавление сотрудника:");
                        Console.WriteLine("Введите название департамента в который добавить сотрудника:");
                        title = Console.ReadLine();
                        AddEmployee(mDep,title);
                        break;
                    case ConsoleKey.D0:
                        choice = false;
                        break;
                    default:
                        Console.WriteLine("Нажата неверна клавиша, введите снова!");
                        break;
                }
            }
        } 

        static public void AddEmployee(ManagementDepartament mDep, string title)
        {
            string name;
            int id;
            bool choice = true;
            while (choice)
            {
                string text = string.Empty;
                Console.WriteLine();
                Console.WriteLine("Введите номер: \n1-добавить сотрудника интерна, \n2-добавить сотрудника рабочего,\n3-добавить сотрудника менеджера.\n0 - exit");
                switch (Console.ReadKey().Key)
                {

                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("Добавление интерна:");
                        Console.WriteLine("Введите имя сотрудника");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите ID сотрудника");
                        id= Convert.ToInt32(Console.ReadLine());
                        Employee employeeIntern = new Intern(id);
                        employeeIntern.Name = name;
                        mDep.AddEmployeeInDepartament(title, employeeIntern);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine("Добавление рабочего:");
                        Console.WriteLine("Введите имя сотрудника");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите ID сотрудника");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите количество отработанных часов");
                        int time= Convert.ToInt32(Console.ReadLine());
                        Employee employeeWorker = new Worker(id,time);
                        employeeWorker.Name = name;
                        mDep.AddEmployeeInDepartament(title, employeeWorker);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine("Добавление менеджера:");
                        Console.WriteLine("Введите имя сотрудника");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите ID сотрудника");
                        id = Convert.ToInt32(Console.ReadLine());
                        Departament departamentForManager = mDep.FindDepartament(title, mDep.Departament);
                        Manager manager = new Manager(departamentForManager, id);
                        manager.Name = name;
                        departamentForManager.Manager = manager;
                        break;
                    case ConsoleKey.D0:
                        choice = false;
                        break;
                    default:
                        Console.WriteLine("Нажата неверна клавиша, введите снова!");
                        break;
                }
            }
        }

        static public void TestData(ManagementDepartament mDep)
        {
            
            string newTitle = Console.ReadLine();
            mDep.AddDep(ManagementDepartament.orgTitle, "1");
            Employee employeeIntern = new Intern(11);
            employeeIntern.Name = "bob";
            mDep.AddEmployeeInDepartament("1", employeeIntern);
            Employee employeeWorker = new Worker(12, 12);
            employeeWorker.Name = "Sam";
            mDep.AddEmployeeInDepartament("1", employeeWorker);
            Employee employeeIntern1 = new Intern(11);
            employeeIntern.Name = "bob";
            mDep.AddEmployeeInDepartament("1", employeeIntern);
            Employee employeeWorker1 = new Worker(12, 12);
            employeeWorker.Name = "Sam";
            mDep.AddEmployeeInDepartament("1", employeeWorker);
            Employee employeeIntern2 = new Intern(11);
            employeeIntern.Name = "bob";
            mDep.AddEmployeeInDepartament("1", employeeIntern);
            Employee employeeWorker2 = new Worker(12, 12);
            employeeWorker.Name = "Sam";
            mDep.AddEmployeeInDepartament("1", employeeWorker);
            Employee employeeIntern3 = new Intern(11);
            employeeIntern.Name = "bob";
            mDep.AddEmployeeInDepartament("1", employeeIntern);
            Employee employeeWorker3 = new Worker(12, 12);
            employeeWorker.Name = "Sam";
            Employee employeeIntern4 = new Intern(11);
            employeeIntern.Name = "bob";
            mDep.AddEmployeeInDepartament("1", employeeIntern);
            Employee employeeWorker4 = new Worker(12, 12);
            employeeWorker.Name = "Sam";
            mDep.AddEmployeeInDepartament("1", employeeWorker);
            Employee employeeIntern5 = new Intern(11);
            employeeIntern.Name = "bob";
            mDep.AddEmployeeInDepartament("1", employeeIntern);
            Employee employeeWorker5 = new Worker(12, 12);
            employeeWorker.Name = "Sam";
            mDep.AddEmployeeInDepartament("1", employeeWorker);
            Employee employeeIntern6 = new Intern(11);
            employeeIntern.Name = "bob";
            mDep.AddEmployeeInDepartament("1", employeeIntern);
            Employee employeeWorker6 = new Worker(12, 12);
            employeeWorker.Name = "Sam";
            mDep.AddEmployeeInDepartament("1", employeeWorker);
            Departament departamentForManager = mDep.FindDepartament("1", mDep.Departament);
            Manager manager = new Manager(departamentForManager, 13);
            manager.Name = "Man";
            departamentForManager.Manager = manager;
            mDep.PrintOrganisation();

        }
    }
}
