using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Models;
//using BreweryAPI.Exceptions;
//using BreweryAPI.Models;
//using BreweryAPI.Services;

namespace BreweryAPI.Controllers
{
    [Route("api/[controller]")]
    public class BreweriesController : Controller
    {
        private BreweryModel[] breweries = new BreweryModel[]
        {
             new BreweryModel(){ Id = 1, Name = "Paulaner", Country = "Germany", FundationDate = new DateTime(1634, 1, 1)},
             new BreweryModel(){ Id = 2, Name = "Flensburger", Country = "Germany", FundationDate = new DateTime(1634, 1, 1)}
        }; 
        //api/breweries
        [HttpGet]

        public BreweryModel[] GetBreweries()
        {
            return breweries; 
        }
        //api/breweries/breweryId
        [HttpGet("{breweryId:int}")]
        public BreweryModel GetBrewery(int breweryId)
        {
            return breweries.FirstOrDefault(b => b.Id == breweryId); 
        }

    }
}
