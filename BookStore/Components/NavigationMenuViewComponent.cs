using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Components
{
    //create "subview" dynamically with model
    public class NavigationMenuViewComponent : ViewComponent
    {

        private BookStoreRepository repository;

        public NavigationMenuViewComponent(BookStoreRepository r)
        {
            repository = r;
        }



        public IViewComponentResult Invoke()
        {
            //send data in viewbag
            ViewBag.SelectedCategory = RouteData?.Values["Category"];
            //select distinct category from books
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
