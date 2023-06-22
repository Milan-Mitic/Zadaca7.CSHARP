using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass7Option1
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }   
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set;}
        
        public double Salary { get; set; }

        public double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
    }
}
