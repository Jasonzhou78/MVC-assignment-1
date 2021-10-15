using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace FindPet.Controllers
{
    public class PetController : Controller
    {
        // 
        // GET: /Pet/

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        // 
        // GET: /Pet/Welcome/ 

        // GET: /Pet/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
