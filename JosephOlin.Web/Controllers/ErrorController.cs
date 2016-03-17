using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JosephOlin.Web.Controllers
{
    public class ErrorController : Controller
    {       
        // GET: Error
        public ViewResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}