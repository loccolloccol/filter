using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fileresult.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileResult1
        public ActionResult FileUpload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/FileUploads"), fileName);
                file.SaveAs(path);
            }
            return RedirectToAction("FileUpload");
        }
    }
}