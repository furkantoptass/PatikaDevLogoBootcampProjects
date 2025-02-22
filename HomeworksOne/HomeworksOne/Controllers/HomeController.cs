﻿using HomeworksOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworksOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Success True > 
                return SuccessTrue();
            }
            else
            {
                //Success False > 
                return SuccessFalse();
            }
        }
        public IActionResult SuccessTrue()
        {
            return Ok(new ResponseModel { Success = true, Error = "Null", Data = "Giriş İşlemi Başarılı" });
        }
        public IActionResult SuccessFalse()
        {
            return BadRequest(new ResponseModel { Success = false, Error = "Hatalı Giriş", Data = "Null" });
        }
    }
}
