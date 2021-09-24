using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjeCamp.Controllers
{
    public class GalleryController : Controller
    {

        ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());

        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }

        [HttpGet]
        public ActionResult ImageAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ImageAdd(ImageFile imageFile)
        {
            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string expansion = Path.GetExtension(Request.Files[0].FileName);
                string path = "/AdminLTE-3.0.4/images/" + fileName + expansion;
                Request.Files[0].SaveAs(Server.MapPath(path));
                imageFile.ImagePath = "/AdminLTE-3.0.4/images/" + fileName + expansion;
                ifm.Add(imageFile);
                return RedirectToAction("Index");

            }
            return View();
        }
    }
}