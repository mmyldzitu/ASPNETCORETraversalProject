using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.ContactUsDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Controllers
{
    [AllowAnonymous]
    public class ContactUsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

  

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    Mail = model.Mail,
                    Name = model.Name,
                    MessageStatus = true,
                    MessageBody = model.MessageBody,
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                }) ;
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
