using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    //view model with info relevant to pagination setup
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        //determine total number of pages needed
        public int TotalPages => (int) Math.Ceiling((decimal) TotalNumItems / ItemsPerPage);


    }
}
