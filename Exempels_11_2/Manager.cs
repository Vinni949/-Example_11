using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempels_11_2
{
    class Manager : Employee
    {
        
        public Manager(int id)
        {
            this.Id = id;
        }


        public override double GetSalary()
        {
            return Salary * 0.15;
        }
    }
}
