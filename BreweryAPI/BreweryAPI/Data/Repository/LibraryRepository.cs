﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Data.Entities;

namespace BreweryAPI.Data.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private List<BreweryEntity> breweries = new List<BreweryEntity>
        {
            new BreweryEntity(){ Id = 1, Name = "Paulaner", Country = "Germany", FundationDate = new DateTime(1634, 1, 1)},
            new BreweryEntity(){ Id = 2, Name = "Flensburger", Country = "Germany", FundationDate = new DateTime(1634, 1, 1)}
        };

        private List<BeerEntity> beers = new List<BeerEntity>
        {
            new BeerEntity(){ Id = 1, Name = "Hefe-Weissbier", Type = "Weissbier", alcoholPorcentage = 5.5m, Price = 2.5m, breweryId =1 },
            new BeerEntity(){ Id = 2, Name = "Munchner Hell", Type = "Lager", alcoholPorcentage = 4.9m, Price = 3.2m, breweryId =1 },
            new BeerEntity(){ Id = 3, Name = "Hefe-Weissbier Dunkel", Type = "Weissbier", alcoholPorcentage = 5.3m, Price = 2.0m, breweryId =1 },

            new BeerEntity(){ Id = 4, Name = "Flensburger Pilsener", Type = "Pilsener", alcoholPorcentage = 4.8m, Price = 2.5m, breweryId =2 },
            new BeerEntity(){ Id = 5, Name = "Flensburger Gold", Type = "Pilsener", alcoholPorcentage = 4.8m, Price = 2.5m, breweryId =2 },
            new BeerEntity(){ Id = 6, Name = "Flensburger Dunkel", Type = "Dunkel", alcoholPorcentage = 4.8m, Price = 3.5m, breweryId =2 },
            new BeerEntity(){ Id = 7, Name = "Flensburger Winterbock", Type = "Bock", alcoholPorcentage = 7.0m, Price = 4.0m, breweryId =2 },

        };

   

        // breweries
        public BreweryEntity CreateBrewery(BreweryEntity brewery)
        {
            int newId;
            if (breweries.Count == 0)
            {
                newId = 1;
            }
            else
            {
                newId = breweries.OrderByDescending(b => b.Id).FirstOrDefault().Id + 1;
            }

            brewery.Id = newId;

            breweries.Add(brewery);
            return brewery;
        }

        public bool DeleteBrewery(int breweryId)
        {
            var breweryToDelete = breweries.FirstOrDefault(c => c.Id == breweryId);
            breweries.Remove(breweryToDelete);
            return true;
        }

        public IEnumerable<BreweryEntity> GetBreweries(string orderBy)
        {
            switch (orderBy)
            {
                case "id":
                    return breweries.OrderBy(c => c.Id);
                case "name":
                    return breweries.OrderBy(c => c.Name);
                case "country":
                    return breweries.OrderBy(c => c.Country);
                case "fundation-date":
                    return breweries.OrderBy(c => c.FundationDate);

                default:
                    return breweries.OrderBy(c => c.Id); ;
            }
        }

        public BreweryEntity GetBrewery(int breweryId)
        {
            return breweries.FirstOrDefault(b => b.Id == breweryId);
        }

        public bool UpdateBrewery(BreweryEntity breweryModel)
        {
            var breweryToUpdate = GetBrewery(breweryModel.Id);
            //companyToUpdate.CEO = companyModel.CEO ?? companyToUpdate.CEO;
            breweryToUpdate.Name = breweryModel.Name ?? breweryToUpdate.Name;
            breweryToUpdate.Country = breweryModel.Country ?? breweryToUpdate.Country;
            breweryToUpdate.FundationDate = breweryModel.FundationDate ?? breweryToUpdate.FundationDate;
           
            return true;
        }

        //beers
        public BeerEntity CreateBeer(BeerEntity beer)
        {
            int newId;
            var lastBeer = beers.OrderByDescending(b => b.Id).FirstOrDefault();
            if (lastBeer == null)
            {
                newId = 1;
            }
            else
            {
                newId = lastBeer.Id + 1;
            }
            beer.Id = newId;
            beers.Add(beer);
            return beer;
        }

        public BeerEntity GetBeer(int beerId)
        {
            return beers.FirstOrDefault(b => b.Id == beerId);
        }

        public IEnumerable<BeerEntity> GetBeers(int breweryId)
        {
            return beers.Where(b => b.breweryId == breweryId);
        }

        public bool UpdateBeer(BeerEntity beer)
        {
            var beerToUpdate = GetBeer(beer.Id);
            beerToUpdate.Name = beer.Name ?? beerToUpdate.Name;
            beerToUpdate.Type = beer.Type ?? beerToUpdate.Type;
            beerToUpdate.alcoholPorcentage = beer.alcoholPorcentage ?? beerToUpdate.alcoholPorcentage;
            beerToUpdate.Price = beer.Price ?? beerToUpdate.Price;

            return true;
        }

        public bool DeleteBeer(int beerId)
        {
            var beerToDelete = beers.SingleOrDefault(b => b.Id == beerId);
            beers.Remove(beerToDelete);
            return true;
        }

    }


}

