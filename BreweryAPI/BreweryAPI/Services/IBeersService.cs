using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Models;

namespace BreweryAPI.Services
{
    public interface IBeersService
    {
        IEnumerable<BeerModel> GetBeers(int breweryId);
        BeerModel GetBeer(int breweryId, int beerId);
        BeerModel CreateBeer(int breweryId, BeerModel beer);
        bool DeleteBeer(int breweryId, int beerId);
        BeerModel UpdateBeer(int breweryId, int beerId, BeerModel breweryModel);
    }
}
