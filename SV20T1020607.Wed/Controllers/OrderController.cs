﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SV20T1020607.Wed.Controllers
{
    public class OrderController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id=0)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult EditDetail(int id = 0,int productId=0)
        {
            return View();
        }
        public IActionResult Shipping(int id=0)
        {
            return View();
        }
    }
}

