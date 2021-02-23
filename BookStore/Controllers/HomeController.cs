using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.ViewModels;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        //set global variables
        private readonly ILogger<HomeController> _logger;

        private BookStoreRepository _repository;

        public int PageSize = 5;
        public HomeController(ILogger<HomeController> logger,BookStoreRepository repository) 
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int page = 1)
        {
            //return a Booklist view model with the list of books and paginginfo
            return View(new BookList
            {
                Books = _repository.Books
                .OrderBy(b => b.BookId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Books.Count()
                }
            });
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
