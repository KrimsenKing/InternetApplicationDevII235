﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieManiaaaaa.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        //GET: HelloWorld/Welcom/
        public ActionResult Welcome(String name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}