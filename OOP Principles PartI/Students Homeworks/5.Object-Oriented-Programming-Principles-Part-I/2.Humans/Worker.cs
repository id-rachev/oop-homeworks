using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Humans
{
    class Worker: Human
    {
        double weekSalary;
        double workHoursPerDay;

        public double WeekSalary
        {
            get { return this.weekSalary; }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
        }

        public Worker (string fName, string LName, double weekSalary, double workHoursPerDay)
            : base (fName, LName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return weekSalary / workHoursPerDay * 5;
        }
    }
}
