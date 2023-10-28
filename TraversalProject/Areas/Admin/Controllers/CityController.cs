using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Models;

namespace TraversalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var JsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(JsonCity); 
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
        public IActionResult getById(int DestinationID)
        {
            var values=_destinationService.TGetByID(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        public IActionResult DeleteCity (int id)
        {
            var city = _destinationService.TGetByID(id);
            _destinationService.TDelete(city);
            return NoContent();
        }
        public IActionResult UpdateCity(Destination destination)
        {
            
            _destinationService.TUpdate(destination);
            var jsonvalues = JsonConvert.SerializeObject(destination);
            return Json(jsonvalues);

        }
        public static List<CityClass> cities = new List<CityClass>{
            new CityClass
            {
                CityID=1,
                CityName="Üsküp",
                CityCountry="Makedonya"
            },
        new CityClass
        {
            CityID=2,
            CityName="Malatya",
            CityCountry="Türkiye"
        },
        new CityClass
        {
            CityID=3,
            CityName="NewYork",
            CityCountry="Amerika"
        }

        };
    }
}
