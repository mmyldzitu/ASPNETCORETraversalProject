﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.AdminDashboard
{
    public class _DashBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
