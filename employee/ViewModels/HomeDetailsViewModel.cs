using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeConnect.Models;

namespace EmployeeConnect.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Employees Employee { get; set; }
        public string PageTitle { get; set; }
    }
}
