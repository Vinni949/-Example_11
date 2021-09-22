using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempels_11_2
{
    class Worker:Employee
    {
        public int Time { set; get; }

        public Worker(int id,int time)
        {
            this.Id = id;
            this.Time = time;
        }
        public override double GetSalary()
        {
            return 12 * Time;
        }
    }
}
