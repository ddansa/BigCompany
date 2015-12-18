using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using BigCompanyLab.Models.Classes;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BigCompanyLab.Controllers
{
    public class CompanyController : MainController
    {
        // GET: /<controller>/
        public IActionResult Index(string id)
        {
            return View((Object)id);
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            var stuff = company;
            return Redirect("/Company/index/" + company.CompanyName);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
