using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempels_11_2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static double Salary { get; set; }
        public override string ToString()
        {
            return Id+" "+Name+" "+Salary;
        }
        public virtual double GetSalary()
        {
            Salary = GetSalary();
            return Salary;
        }
    }
}
