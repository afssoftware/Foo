using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeConnect.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employees> _employeeList; 

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employees>()
            {
                new Employees() {Id=1, Name="Bas", Department="HR", Email="Bas@InterConnect.nl" , Salary=2000},
                new Employees() {Id=2, Name="Martijn", Department="IT", Email="Martijn@InterConnect.nl", Salary=2100},
                new Employees() {Id=3, Name="Samer", Department="HR", Email="Samer@InterConnect.nl",  Salary=2500},
                new Employees() {Id=4, Name="Denis", Department="IT", Email="Denis@InterConnect.nl", Salary=3000}
            };
        }

        public IEnumerable<Employees> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employees GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
