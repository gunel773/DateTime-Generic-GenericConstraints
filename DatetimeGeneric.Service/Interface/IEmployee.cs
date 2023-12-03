using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeGeneric.Service.Interface
{
    public interface IEmployee
    {
        int GetAllEmployeeFilterByDateAndSalary(DateTime startdate, DateTime enddate, double salary);
    }
}
