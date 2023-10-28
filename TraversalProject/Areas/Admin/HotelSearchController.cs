using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using TraversalProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace TraversalProject.Areas.Admin
{
    public class HotelSearchController : Controller
    {
		[Area("Admin")]
		[AllowAnonymous]
        public async Task <IActionResult> Index()
        {
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-11-24&filter_by_currency=EUR&dest_id=-1456928&locale=en-gb&checkout_date=2023-11-25&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
				Headers =
	{
		{ "X-RapidAPI-Key", "da8e286d21msh96a39d7f01809c4p10f562jsnd9eedc9df574" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<HotelSearchViewModel>(body);
				return View(values.results);
			}

			
        }
    }
}
