﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AutoCompleteController : Controller
    {
        public ActionResult virtualscroll()
        {
            ViewBag.data = new Record().RecordModelList();
            return View();
        }
    }
}