using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjeCamp.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult GetAllContent(string p)
        {
            var values = cm.GetList(p);
            //var values = c.Contents.ToList();
            return View(values.ToList());
        }
        public ActionResult ContentByHeading(int id)
        {
            var contnetvalues = cm.GetListByHeadingID(id);
            return View(contnetvalues);
        }
    }
}