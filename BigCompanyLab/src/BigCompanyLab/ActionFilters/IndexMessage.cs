using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigCompanyLab.ActionFilters
{
    public class IndexMessage : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Controller c = (Controller)context.Controller;
            c.ViewData["spooky"] = "This is our index message";
        }
    }
}
