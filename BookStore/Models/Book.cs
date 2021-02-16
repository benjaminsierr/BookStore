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
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [RegularExpression(@"^\d{3}-{1}\d{10}$")]
        public string ISBN { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public bool Fiction { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }


    }
}
