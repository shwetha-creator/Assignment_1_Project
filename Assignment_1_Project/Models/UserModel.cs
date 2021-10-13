using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment_1_Project.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Please enter the Name ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Username ")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter the Password ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter the Confirm Password ")]
        [Compare("Password",ErrorMessage ="Confirm password is not same as Password entered")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter the Contact Number ")]
        [RegularExpression(@"^[6-9]{1}[0-9]{9}$", ErrorMessage ="Enter the Valid Contact number")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please select the Country ")]
        public string Country { get; set; }
        public List<Country> CountryList { get; set; }

        [Required(ErrorMessage = "Please select the City ")]
        public string City { get; set; }
        public SelectList  CityList { get; set; }

        [Required(ErrorMessage = "Please select the Gender ")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please select the Accept Terms ")]
        public bool AcceptTerms { get; set; }

        
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string  CountryName { get; set; }
    }

    public class City
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
    }
}
