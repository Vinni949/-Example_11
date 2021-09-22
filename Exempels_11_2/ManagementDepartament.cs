using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempels_11_2
{
    class ManagementDepartament
    {
        public const string orgTitle = "Organisation";
        static public int idDeportament = 1;
        public Departament Departament { get; set; } = new Departament(orgTitle, idDeportament);
        
        public void AddDep(string title,string newTitle)
        {
            Departament result = FindDepartament(title, Departament);
            if (result == null)
            {
                Console.WriteLine("!");
            }
            else
            {
                result.AddDepartament(newTitle);
            }
        }
        public void PrintOrganisation()
        {
            Print(Departament,0) ;
        }
        private void Print(Departament Departament,int level)
        {
            for(int i=0;i<level;i++)
            {
                Console.Write("---");
            }
            Console.WriteLine(Departament);
            Console.WriteLine(Departament.Manager);

            foreach (Employee employee in Departament.employees)
            {
                for (int i = 0; i < level; i++)
                {
                    Console.Write("---");
                }
                Console.WriteLine(employee);
            }
            foreach (Departament departamentInAll in Departament.departaments)
            {
                Print(departamentInAll,level+1);
            }
        }
        public Departament FindDepartament(string title,Departament Departament)
        {
            Departament result=null;
            if (Departament.Title == title)
            {
                return Departament;
            }
                foreach (Departament departamentInAll in Departament.departaments)
                {
                    if (departamentInAll.Title == title)
                    {
                        return departamentInAll;
                    }
                    else
                    {
                        result = FindDepartament(title, departamentInAll);
                    }
                }
            
            return result;
        }

        public void AddEmployeeInDepartament(string title,Employee employee)
        {
            Departament result = FindDepartament(title, Departament);
            if(result==null)
            {
                Console.WriteLine("!");
            }
            else
            {
                result.employees.Add(employee);
            }
        }
    }
}
