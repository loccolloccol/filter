using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication1.Domain;
using WebApplication1.Infrastructure.Filters;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SelectListController : Controller
    {

        // GET: SelectList
        private readonly NorthwindEntities db = new NorthwindEntities();
        [CustomAttribute2]
        [CustomAttribute1]
        
        public ActionResult Edit()
        {
            List<SelectListItem> mySelectItemList = new List<SelectListItem>();
            var data = db.Categories;
            foreach (var item in data)
            {
                mySelectItemList.Add(new SelectListItem()
                {
                    Value = item.CategoryID.ToString(),
                    Text = item.CategoryName,
                    Selected =(item.CategoryID == 3 )

                }) ;
            }


                //Selec model = new Selec() //上面的 Model
                //{
                //    MyList = mySelectItemList
                //};


            ViewBag.Customers = db.Customers.ToList();
            ViewBag.cage = mySelectItemList;

            return View();
               // return Json(model, JsonRequestBehavior.AllowGet);
            }


        }
    }
