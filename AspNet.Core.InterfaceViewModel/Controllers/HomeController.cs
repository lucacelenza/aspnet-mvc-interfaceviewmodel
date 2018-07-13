using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNet.Core.InterfaceViewModel.Models;

namespace AspNet.Core.InterfaceViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}