using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JosephOlin.Web.Models;

namespace JosephOlin.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected Person owner = new Person
        {
            Name = "Joseph Olin",
            Email = "jbo@user.com",
            Phone = "123-456-7890",
            Employer = "ZirMed, Inc",
            Position = "IT Intern",
            University = "Indiana University Southeast",
            Major = "Computer Science"
        };       
    }
}