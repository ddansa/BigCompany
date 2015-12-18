using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigCompanyLab.Models.Classes
{
    public class Company
    {
        public Company()
        {
        }
        public Company(string companyName, string address, int empolyeeCount)
        {
            CompanyName = companyName;
            Address = address;
            EmployeeCount = empolyeeCount;
        }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int EmployeeCount { get; set; }

    }
}
