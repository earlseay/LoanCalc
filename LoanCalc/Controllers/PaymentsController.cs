﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanCalc.Controllers
{
    public class PaymentsController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }
    }
}