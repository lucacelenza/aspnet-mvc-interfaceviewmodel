using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNet.Core.InterfaceViewModel.Models;

namespace AspNet.Core.InterfaceViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel { Animal = new PersonViewModel { FirstName = "Luca", LastName = "Celenza" } };

            //you can also try
            //var viewModel = new HomeViewModel { Animal = new DogViewModel { Breed = "Jack Russel Terrier" } };

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}