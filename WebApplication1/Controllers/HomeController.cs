using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Domain;
using PagedList;
using System.Net;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly NorthwindEntities db = new NorthwindEntities();
        private readonly int pageSize = 5;
        public ActionResult Index(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var customers = db.Customers.OrderBy(x => x.CustomerID);
            var result = customers.ToPagedList(currentPage, pageSize);
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public ActionResult Delete(WebApplication1.Domain.Customers item)
        //{
        //    if (item == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Customers customers = db.Customers.Find(item);
        //    if (customers == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customers);
        //}

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Customers customers = db.Customers.Find(id);
            db.Customers.Remove(customers);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}