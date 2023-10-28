using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTO_s;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Areas.Admin.Models;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        //public IActionResult Index()
        //{
        //    List<Announcement> announcements = _announcementService.TGetList();
        //    List<AnnouncementListViewModel> models = new List<AnnouncementListViewModel>();
        //    foreach( var item in announcements)
        //    {
        //        AnnouncementListViewModel announcementListViewModels = new AnnouncementListViewModel();
        //        announcementListViewModels.ID = item.AnnouncementID;
        //        announcementListViewModels.Title = item.Title;
        //        announcementListViewModels.Content = item.Content;
        //        models.Add(announcementListViewModels);
        //    }
        //    return View(models);
        //}
        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncmentListDTO>>(_announcementService.TGetList());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())

                });
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetByID(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetByID(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID=model.AnnouncementID,
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
