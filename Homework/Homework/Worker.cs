using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Worker:Person
    {
        public Worker(double salaryPerHour,string name,string surname,byte age):base(name,surname,age)
        {
            this.SalaryPerHour = salaryPerHour;
        }

        public double SalaryPerHour;
        public int MontlyHour;

        public double CalcSalary()
        {
            return MontlyHour * SalaryPerHour;
        }
    }
}
