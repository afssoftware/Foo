using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeConnect.Models
{
   public interface IEmployeeRepository
    {
        Employees GetEmployee(int Id);
        IEnumerable<Employees> GetAllEmployee();
    }
}
