using AspNet.Legacy.InterfaceViewModel.Models;
using System.Web.Mvc;

namespace AspNet.Legacy.InterfaceViewModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel { Animal = new PersonViewModel { FirstName = "Luca", LastName = "Celenza" } };

            //you can also try
            //var viewModel = new HomeViewModel { Animal = new DogViewModel { Breed = "Jack Russel Terrier" } };

            return View(viewModel);
        }
    }
}