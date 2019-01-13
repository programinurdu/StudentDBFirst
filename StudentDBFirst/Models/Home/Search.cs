using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentDBFirst.Models.Home
{
    public class Search
    {
        [Display(Name = "Search:")]
        [Required(ErrorMessage = "Enter a search text.")]
        public string SearchText { get; set; }
    }
}