using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using BigCompanyLab.Models;
using BigCompanyLab.Models.Classes;


namespace BigCompanyLab.Controllers
{
    public abstract class MainController : Controller
    {
        protected static DataManager _data = new DataManager();
    }
}
