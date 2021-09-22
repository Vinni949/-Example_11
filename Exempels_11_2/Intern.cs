using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempels_11_2
{
    class Intern:Employee
    {
        
        public Intern(int id)
        {
            this.Id = id;
        }
        public override double GetSalary()
        {
            return 500;
        }
    }
}
