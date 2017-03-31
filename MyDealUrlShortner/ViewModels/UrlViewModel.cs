using System.ComponentModel.DataAnnotations;
using MyDealUrlShortner.Models;

namespace MyDealUrlShortner.ViewModels
{
    public class UrlViewModel
    {
        [CheckMyDealDomain]
        [Display(Name = "Enter the Url you want to minify")]
        public string ActualUrl { get; set; }
        public string MinifiedUrl { get; set; }
    }
}