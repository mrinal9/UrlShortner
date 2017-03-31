using System;
using System.ComponentModel.DataAnnotations;

namespace MyDealUrlShortner.Models
{
    public class CheckMyDealDomain : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            Uri fullPath;
            if (value==null)
                return new ValidationResult("Please enter a Url to be minified");
            try
            {
               fullPath = new Uri(value.ToString());
            }
            catch (Exception)
            {
                return new ValidationResult("Please enter a valid url");
            }
            return (fullPath.Host == "mydeal.com.au" || fullPath.Host == "www.mydeal.com.au")
                ? ValidationResult.Success
                : new ValidationResult("Only Urls from myDeals allowed");

        }
    }
}