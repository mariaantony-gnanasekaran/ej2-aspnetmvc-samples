﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SliderController : Controller
    {
        public ActionResult Bar()
        {
            ViewBag.sliderValue = new int[] { 30, 70 };
            return View();
        }
    }
}
