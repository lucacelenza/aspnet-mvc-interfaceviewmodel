using AspNet.Legacy.InterfaceViewModel.Models;
using System.Web.Mvc;

namespace AspNet.Legacy.InterfaceViewModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel { Animal = new DogViewModel { Breed = "Jack Russel Terrier" } };

            // You can also try a much complex ViewModel

            //var viewModel = new HomeViewModel
            //{
            //    Animal = new PersonViewModel
            //    {
            //        FirstName = "Luca",
            //        LastName = "Celenza",
            //        Address = new AddressViewModel
            //        {
            //            City = "New Orleans",
            //            State = "Lousiana",
            //            ZipCode = "70131",
            //            Country = "USA"
            //        }
            //    }
            //};

            return View(viewModel);
        }
    }
}