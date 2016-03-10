﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JosephOlin.Web.Models;

namespace JosephOlin.Web.Controllers
{
    public class HomeController : Controller
    {
        Person p = new Person
        {
            Name = "Joseph Olin",
            Email = "jbo@user.com",
            Phone = "123-456-7890",
            Employer = "ZirMed",
            Position = "IT Intern"
        };
        
        // GET: Home
        public ActionResult Index()
        {
            return View(p);

        }

        public ActionResult Contact()
        {
            return View(p);
        }
    }
}