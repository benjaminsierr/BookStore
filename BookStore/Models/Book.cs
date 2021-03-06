﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//model for books
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
        public string AuthorFirstName { get; set; }
        public string AuthorMiddleName { get; set; }
        public string AuthorLastName { get; set; }
        [Required]
        //restrict isbn to correct format
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
        [Required]
        public int Pages { get; set; }


    }
}
