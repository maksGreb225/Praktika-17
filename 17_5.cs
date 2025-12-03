using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_17_5
{
    enum EmploymentStatus {Active, OnLeave, Terminatet }
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee
            {
                Name = "Пётр",
                HareDate = new DateTime(2020, 3, 15),
                Status = EmploymentStatus.Active
            };
            Console.WriteLine(emp.GetYearsWorkes());
            emp.HareDate = null;
            Console.WriteLine(emp.GetYearsWorkes());
            Console.WriteLine(emp);
        }
    }

    class Employee
    {
        public string Name;
        public DateTime? HareDate;
        public EmploymentStatus Status;

        public int GetYearsWorkes()
        {
            if (HareDate == null)
            {
                return -1;
            }
            else { 
                return 2025 - HareDate.Value.Year;
            }
        }

        public override string ToString() {
            if (HareDate == null)
                return $"{Name}, статус: {Status}, стаж: не указан";
            else
                return $"{Name}, статус: {Status}, стаж: {GetYearsWorkes()}";
        }
    }
}
