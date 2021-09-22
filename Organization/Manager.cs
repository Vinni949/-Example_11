using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempels_11_2
{
    class Manager : Employee
    {
        Departament departament;
        const double baseSalary = 1300;
        public Manager(Departament departament, int id)
        {
            this.departament = departament;
            this.Id = id;
        }


        public override double GetSalary()
        {
            
            double managerSalaru = departament.AllSalary() * 0.15;
            if ((managerSalaru) > baseSalary)
            {
                return managerSalaru;
            }
            return baseSalary;
        }
    }
}
