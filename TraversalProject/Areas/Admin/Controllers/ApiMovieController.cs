using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using TraversalProject.Areas.Admin.Models;
using Newtonsoft.Json;

namespace TraversalProject.Areas.Admin.Controllers
{
    public class ApiMovieController : Controller
    {
        [Area("Admin")]
		[AllowAnonymous]
        public async Task<IActionResult> Index()
        {
			List<MovieViewModel> movieList = new List<MovieViewModel>();

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
				Headers =
	{
		{ "X-RapidAPI-Key", "da8e286d21msh96a39d7f01809c4p10f562jsnd9eedc9df574" },
		{ "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				movieList = JsonConvert.DeserializeObject<List<MovieViewModel>>(body);
			}
			return View(movieList);
        }
    }
}
