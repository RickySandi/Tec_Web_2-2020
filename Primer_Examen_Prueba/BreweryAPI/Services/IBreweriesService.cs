﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Primer_Examen.Models; 

namespace Primer_Examen.Services
{
     public interface IBreweriesService
    {
        IEnumerable<BreweryModel> GetBreweries(string orderBy);
        BreweryModel GetBrewery(int breweryId);
        BreweryModel CreateBrewery(BreweryModel breweryModel); 
        DeleteModel DeleteBrewery(int breweryId);
        BreweryModel UpdateBrewery(int breweryId, BreweryModel breweryModel);

        IEnumerable<BreweryModel> FilterBreweryByCountry(string beerCountry);

    }
}
