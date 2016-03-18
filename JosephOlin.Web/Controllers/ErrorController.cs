using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JosephOlin.Web.Models;

namespace JosephOlin.Web.Controllers
{
    public class ErrorController : Controller
    {       
        // GET: Error
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            
            //Creating another Person object is temporary
            // A different implementation will eventually be followed.
            return View(
                new Person {
                    Name = "Joseph Olin",
                    Email = "jbo@user.com",
                    Phone = "123-456-7890",
                    Employer = "ZirMed, Inc",
                    Position = "IT Intern",
                    University = "Indiana University Southeast",
                    Major = "Computer Science"
                });
        }
    }
}