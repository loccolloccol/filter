using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Domain;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Edit(string id)
        {
            var entity = new NorthwindEntities();
            var item = entity.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            return View(item);
        }
        [HttpPost]
        public ActionResult Edit(Customers viewModle)
        {

            //if (!this.ModelState.IsValid)

            //{
            //    return View(viewModle);
            //}


            var reault = new ApiResult<string>
            {
                Result = "成功"
                //IsSuccess = true
            };
            //var reault = new ApiResult<string>
            //{
            //    ErrorMessage=new List<string>
            //    {
            //        "error"
            //    }
            //};
            return this.Json(reault);
        }
    }
}