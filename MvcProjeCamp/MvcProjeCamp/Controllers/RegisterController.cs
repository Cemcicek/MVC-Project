using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Dtos;

namespace MvcProjeCamp.Controllers
{
    public class RegisterController : Controller
    {
        IAuthService authService = new AuthManager(new AdminManager(new EfAdminDal()), new WriterManager(new EfWriterDal()));
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(LoginDto loginDto)
        {
            authService.Register(loginDto.AdminUserName, loginDto.AdminPassword);
            return RedirectToAction("Index", "Login");
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult WriterRegister()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult WriterRegister(WriterLoginDto writerLoginDto)
        {

            authService.WriterRegister(writerLoginDto.WriterMail, writerLoginDto.WriterPassword);
            return RedirectToAction("WriterLogin", "Login");
        }
    }
}