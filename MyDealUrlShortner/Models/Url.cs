using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDealUrlShortner.Models
{
    public class Url
    {
        public int Id { get; set; }
        [Display(Name = "Enter the Url you want to minify")]
        public string ActualUrl { get; set; }
        public string MinifiedUrl { get; set; }
    }
}