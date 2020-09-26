using System;
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


        // companies
        public BreweryEntity CreateCompany(BreweryEntity company)
        {
            int newId;
            if (breweries.Count == 0)
            {
                newId = 1;
            }
            else
            {
                newId = breweries.OrderByDescending(c => c.Id).FirstOrDefault().Id + 1;
            }

            company.Id = newId;

            breweries.Add(company);
            return company;
        }

        public bool DeleteCompany(int companyId)
        {
            var companyToDelete = breweries.FirstOrDefault(c => c.Id == companyId);
            breweries.Remove(companyToDelete);
            return true;
        }

        public IEnumerable<BreweryEntity> GetCompanies(string orderBy)
        {
            switch (orderBy)
            {
                case "id":
                    return breweries.OrderBy(c => c.Id);
                case "name":
                    return breweries.OrderBy(c => c.Name);
                case "fundation-date":
                    return breweries.OrderBy(c => c.FundationDate);
                case "country":
                    return breweries.OrderBy(c => c.Country);
                default:
                    return breweries.OrderBy(c => c.Id); ;
            }
        }

        public BreweryEntity GetCompany(int companyId)
        {
            return breweries.FirstOrDefault(c => c.Id == companyId);
        }

        public bool UpdateCompany(BreweryEntity breweryModel)
        {
            var companyToUpdate = GetCompany(breweryModel.Id);
            //companyToUpdate.CEO = companyModel.CEO ?? companyToUpdate.CEO;
            companyToUpdate.Country = breweryModel.Country ?? companyToUpdate.Country;
            companyToUpdate.FundationDate = breweryModel.FundationDate ?? companyToUpdate.FundationDate;
            companyToUpdate.Name = breweryModel.Name ?? companyToUpdate.Name;
            return true;
        }


    }
}
