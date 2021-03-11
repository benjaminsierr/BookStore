using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// view model with a list of all book models
/// </summary>
namespace BookStore.Models.ViewModels
{
    public class BookList
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
}
