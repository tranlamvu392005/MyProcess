﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProcess.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProductDetail()
        { 
            return View();
        }
        public ActionResult ShoppingCaart()
        {
            return View();
        }
    }
}