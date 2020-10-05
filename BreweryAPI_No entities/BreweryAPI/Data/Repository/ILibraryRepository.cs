using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using BreweryAPI.Data.Entities;
using BreweryAPI.Models; 

namespace BreweryAPI.Data.Repository
{
    public interface ILibraryRepository
    {
        ////breweries
        IEnumerable<BreweryModel> GetBreweries(string orderBy);
        BreweryModel GetBrewery(int breweryId);
        BreweryModel CreateBrewery(BreweryModel breweryModel);
        bool DeleteBrewery(int breweryId);
        bool UpdateBrewery(BreweryModel breweryModel);

        IEnumerable<BreweryModel> FilterBreweryByCountry(string beerCountry);


        ////beers 
        BeerModel CreateBeer(BeerModel beer);
        BeerModel GetBeer(int beerId);
        IEnumerable<BeerModel> GetBeers(int breweryId);
        bool UpdateBeer(BeerModel beer);
        bool DeleteBeer(int breweryId);
        

        IEnumerable<BeerModel> NotSoldBeers(); 


    }
}
