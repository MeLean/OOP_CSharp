namespace _02.HumanStudentWorker
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value > 0)
                {
                    this.weekSalary = value;
                }
                else
                {
                    throw new ArgumentException("Week salary must be greater than zero!");
                }
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value >= 0 && value <= 12)
                {
                     this.workHoursPerDay = value;
                }
                else
                {
                     throw new ArgumentException("Work hours per day must be in interwal 0 and 12!");
                }
            }
        }

        public decimal MoneyPerHour()
        {
            const int WorkingDaysInWeek = 5;
            return this.weekSalary / (this.workHoursPerDay * WorkingDaysInWeek);
        }

        public override string ToString()
        {
            return string.Format("Worker: {0} {1}, gets {2:F2} leva per hour.", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
