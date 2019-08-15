using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Domain;

namespace WebApplication1.Infrastructure.Filters
{
    public class CustomAttribute1 : ActionFilterAttribute
    {
        private readonly NorthwindEntities db = new NorthwindEntities();
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("1<br>");
            //filterContext.Controller.ViewBag.Customer2 = db.Customers.ToList();
        }
            
    }
    public class CustomAttribute2 : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("2<br>");
        }
    }
}