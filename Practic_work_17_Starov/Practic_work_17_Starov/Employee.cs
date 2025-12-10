using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work_17_Starov
{
    public enum EmploymentStatus { Active, OnLeave, Terminated }

    internal class Employee
    {
        public string Name { get; set; }
        public DateTime? HireDate { get; set; }
        public EmploymentStatus Status { get; set; }

        public int GetYearsWorked()
        {
            if (!HireDate.HasValue)
                return -1;

            DateTime today = DateTime.Today;
            int years = today.Year - HireDate.Value.Year;


            if (HireDate.Value.Date > today.AddYears(-years))
                years--;

            return years;
        }

        public override string ToString()
        {
            string hireInfo = HireDate.HasValue
                ? $"стаж: {GetYearsWorked()} лет"
                : "стаж: не указан";

            return $"{Name}, статус: {Status}, {hireInfo}";
        }
    }
}
