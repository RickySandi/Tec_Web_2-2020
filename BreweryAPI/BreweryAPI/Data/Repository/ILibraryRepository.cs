using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Data.Entities;

namespace BreweryAPI.Data.Repository
{
    public interface ILibraryRepository
    {
        ////breweries
        IEnumerable<BreweryEntity> GetBreweries(string orderBy);
        BreweryEntity GetBrewery(int breweryId);
        BreweryEntity CreateBrewery(BreweryEntity breweryModel);
        bool DeleteBrewery(int breweryId);
        bool UpdateBrewery(BreweryEntity breweryModel);

        IEnumerable<BreweryEntity> FilterBreweryByCountry(string beerCountry);


        ////beers 
        BeerEntity CreateBeer(BeerEntity beer);
        BeerEntity GetBeer(int beerId);
        IEnumerable<BeerEntity> GetBeers(int breweryId);
        bool UpdateBeer(BeerEntity beer);
        bool DeleteBeer(int breweryId);
        

        IEnumerable<BeerEntity> NotSoldBeers(); 


    }
}
