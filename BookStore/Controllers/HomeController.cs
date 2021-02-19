using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private BookStoreRepository _repository;

        public int ItemsPerPage = 5;
        public HomeController(ILogger<HomeController> logger,BookStoreRepository repository) 
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int page = 1)
        {

            return View(_repository.Books
                .OrderBy(b => b.BookId)
                .Skip((page - 1) * ItemsPerPage)
                .Take(ItemsPerPage)
                );
        }

        public IActionResult Privacy()
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View();
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
