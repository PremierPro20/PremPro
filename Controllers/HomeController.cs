using Microsoft.AspNetCore.Mvc;
using PremierPro.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace PremierPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }

        public IActionResult Fixture()
        {
            return View();
        }

        public IActionResult FetchMatches()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FetchMatchesAsync()
        {
            string matches;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-football-v1.p.rapidapi.com/v3/fixtures?date=2021-01-29"),
                Headers =
                {
                    { "x-rapidapi-key", "5327a1ad7cmshdfb2faccc967c43p1651bdjsna67a2bbcf642" },
                    { "x-rapidapi-host", "api-football-v1.p.rapidapi.com" },
                },
            };

            try
            {
                using (var response = await _httpClient.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    matches = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation("API call successful. Data: {0}", matches);
                }
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, "Error fetching matches from API");
                matches = "Error fetching matches from API.";
            }

            return Json(matches);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
