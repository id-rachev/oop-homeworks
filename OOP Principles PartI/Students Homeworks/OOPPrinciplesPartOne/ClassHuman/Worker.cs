using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Worker:Human
    {

        public decimal WeekSalary { get; private set; }
        public decimal WorkHoursPerDay { get; private set; }

        public Worker(string fname, string lname, decimal salary, decimal workHours) : base(fname, lname) 
        {
            if (salary <= 0) throw new ArgumentOutOfRangeException("Salary must be grater than zero");
            if (workHours <= 0 || workHours > 24) throw new ArgumentOutOfRangeException("Work hours per day must be grater than 0, and less than or equal to 24");
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workHours;
        }
        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / this.WorkHoursPerDay) / 5;
        }
        public override string ToString()
        {
            StringBuilder workerInfo = new StringBuilder();
            workerInfo.AppendFormat("{0}-:{1:C2}-{2}hours per day-Money Per Hour:{3:C2}", base.ToString(), this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
            return Convert.ToString(workerInfo);
        }
    }

