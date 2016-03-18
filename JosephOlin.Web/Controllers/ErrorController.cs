using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JosephOlin.Web.Models;

namespace JosephOlin.Web.Controllers
{
    public class ErrorController : BaseController
    {       
        // GET: Error
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            // pass the Person object from the BaseController 
            // into the View so the NavBar, Footer, etc. can use
            // the Person object
            return View(owner);
        }
    }
}