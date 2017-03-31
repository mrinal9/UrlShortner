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
        
        [Required]
        public string ActualUrl { get; set; }
        [Required]
        public string MinifiedUrl { get; set; }
    }
}