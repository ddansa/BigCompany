using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigCompanyLab.Models.Classes
{
    public class Company
    {
        public Company(string companyName, string address, int employeecount)
        {
            CompanyName = companyName;
            Address = address;
            EmployeeCount = employeecount;
        }

        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int EmployeeCount { get; set; }

    }
}
