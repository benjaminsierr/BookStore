using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public long ISBN { get; set; }
        public string Publisher { get; set; }

        public bool Fiction { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }


    }
}
