using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public byte WorkHoursPerDay { get; set; }

        public Worker(string firstName)
            : this(firstName, null, 0, 0)
        {
        }

        public Worker(string firstName, string lastName,
            decimal weekSalary, byte workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            byte workDaysOfWeek = 5;
            decimal moneyPerHour =
                (this.WeekSalary / (this.WorkHoursPerDay * workDaysOfWeek));
            
            return moneyPerHour;
        }
    }
}
