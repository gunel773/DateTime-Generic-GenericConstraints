using DatetimeGeneric.Service.Interface;
using DateTimeGeneric.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeGeneric.Service.Service
{
    public class IEmployeeService : IEmployee
    {
        public int GetAllEmployeeFilterByDateAndSalary(DateTime startdate, DateTime enddate, double salary)
        {
            var employees = GetAll();
            int count = 0;
            foreach (var employee in employees)
            {
                if (employee.Birthday>startdate && employee.Birthday<enddate && employee.Salary>salary)
                {
                    count++;
                }
            }return count;

        }
        private Employee[] GetAll()
        {
            Employee employee1 = new(DateTime.Now.AddDays(-200));
            employee1.Name = "employee1";
            employee1.Salary = 2000;
            Employee employee2 = new(DateTime.Now.AddDays(-100));
            employee2.Name = "employee2";
            employee2.Salary = 1500;
            Employee employee3 = new(DateTime.Now.AddDays(-500));
            employee3.Name = "employee3";
            employee3.Salary = 2500;
            Employee employee4 = new(DateTime.Now.AddDays(-140));
            employee4.Name = "employee4";
            employee4.Salary = 2400;

            Employee[] employess = { employee1, employee2, employee3, employee4 };
            return employess;
        }
    }
}
