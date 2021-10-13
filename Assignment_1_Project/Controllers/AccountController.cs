using Assignment_1_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1_Project.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            List<Country> countriesList = new List<Country>()
            {
                new Country(){CountryId= 1,CountryName="India"},
                new Country(){CountryId = 2, CountryName="China"} 
            };
            //assigning selectlistItem to ViewBag
            ViewBag.country = new SelectList(countriesList, "CountryId", "CountryName");
            ViewBag.Gender = Gender;
            return View();
        }

        public JsonResult GetCityList(int countryId)
        {

            List<City> cityList1 = new List<City>()
            {
                new City(){CityId =1, CityName="Bangalore", CountryId=1 },
                new City(){CityId =2, CityName="Tumkur", CountryId=1 },
                new City(){CityId =3, CityName="Beijing", CountryId=2 },
                new City(){CityId =4, CityName="Shanghai", CountryId=2 }
            };
          
            List<City> cityList = cityList1.FindAll(x => x.CountryId == countryId);
            SelectList cities = new SelectList(cityList, "CityId", "CityName");
            ViewBag.city = cities;               
            return new JsonResult(cities);
        }

        public List<SelectListItem> Gender = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Male", Value = "M" },
            new SelectListItem() { Text = "Female", Value = "F" }

        };
    }
}
