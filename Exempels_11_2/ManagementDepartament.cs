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
        Departament departament = new Departament(orgTitle, idDeportament);
        
        public void AddDep(string title,string newTitle)
        {
            Departament result = FindDepartament(title, departament);
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
            Print(departament,0) ;
        }
        private void Print(Departament departament,int level)
        {
            for(int i=0;i<level;i++)
            {
                Console.Write("---");
            }
            Console.WriteLine(departament);
            foreach (Employee employee in departament.employees)
            {
                for (int i = 0; i < level; i++)
                {
                    Console.Write("---");
                }
                Console.WriteLine(employee);
            }
            foreach (Departament departamentInAll in departament.departaments)
            {
                Print(departamentInAll,level+1);
            }
        }
        public Departament FindDepartament(string title,Departament departament)
        {
            Departament result=null;
            if (departament.Title == title)
            {
                return departament;
            }
                foreach (Departament departamentInAll in departament.departaments)
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
            Departament result = FindDepartament(title, departament);
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
