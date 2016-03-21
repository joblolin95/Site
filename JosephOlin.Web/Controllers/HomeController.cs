using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JosephOlin.Web.Models;

namespace JosephOlin.Web.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(owner);
        }

        public ActionResult Contact()
        {
            return View(owner);
        }

        public FileResult DisplayResume()
        {
            return File("~/Content/Joseph.Olin.resume.pdf", "application/pdf");
        }

        //Test how 500 errors are handled by throwing an exception
        public Exception TestException()
        {
            throw new Exception();
        }
    }
}