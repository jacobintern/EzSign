using Microsoft.AspNetCore.Mvc;
using EzSign.BusinessLogic.Interfaces;

namespace EzSign.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISampleScoped _scoped;
        private readonly ISampleSingleton _singleton;
        private readonly ISampleTransient _transient;
        public HomeController(ISampleScoped scoped,
        ISampleSingleton singleton,
        ISampleTransient transient)
        {
            _scoped = scoped;
            _singleton = singleton;
            _transient = transient;
        }

        public IActionResult Index()
        {
            ViewBag.TransientId = _transient.id();
            ViewBag.TransientHashCode = _transient.GetHashCode();

            ViewBag.ScopedId = _scoped.id();
            ViewBag.ScopedHashCode = _scoped.GetHashCode();

            ViewBag.SingletonId = _singleton.id();
            ViewBag.SingletonHashCode = _singleton.GetHashCode();
            return View();
        }
    }
}