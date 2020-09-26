using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Models; 

namespace BreweryAPI.Services
{
      interface IBreweriesService
    {
        IEnumerable<BreweryModel> GetBreweries();

        BreweryModel GetBrewery(int companyId); 
     
    }
}
