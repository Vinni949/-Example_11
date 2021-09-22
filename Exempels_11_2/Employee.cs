using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempels_11_2
{
    abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Id+" "+Name+" "+ GetSalary();
        }
        public abstract double GetSalary();
    }
}
