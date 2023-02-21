using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TurkiyeBolgelerSehirler.Classes;
using TurkiyeBolgelerSehirler.Models;

namespace TurkiyeBolgelerSehirler.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _db;

        public HomeController(ILogger<HomeController> logger,UygulamaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Bolgeler.ToList());
        }

        [Route("bolge/{slug}")]
        public IActionResult BolgeBilgi(string slug)
        {
            Bolge? bolge = _db.Bolgeler.FirstOrDefault(x => x.Slug == slug);
            if (bolge == null) return NotFound();

            var sehirler = _db.Sehirler.Where(x => x.BolgeId == bolge.Id).ToList();

            return View(sehirler);
        }

        [Route("sehir/{slug}")]
        public IActionResult SehirBilgi(string slug)
        {
            Sehir? sehir = _db.Sehirler.FirstOrDefault(x => x.Slug == slug);
            if (sehir == null) return NotFound();

            sehir.Bolge = _db.Bolgeler.First(x => x.Id == sehir.BolgeId);

            return View(sehir);
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
    }
}