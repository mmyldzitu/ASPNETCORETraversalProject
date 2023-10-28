﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
       
        public IActionResult Index()
        {
            var values=destinationManager.TGetList();
            return View(values);
        }
        public IActionResult SearchDestinationsbyName(string searchString)
        {
            ViewData["currentFilter"] = searchString;
            var values = from x in destinationManager.TGetList() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.City.Contains(searchString));
            }
            return View(values.ToList());
        }
    }
}
