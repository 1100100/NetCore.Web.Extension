﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCore.Web.Extension;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(AuthenticationSchemes = "Cookies")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Nick = User.GetClaimValue("nick");
            return View();
        }
    }
}