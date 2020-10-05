using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using BreweryAPI.Data.Entities;
using BreweryAPI.Data.Repository;
using BreweryAPI.Exceptions;
using BreweryAPI.Models;


namespace BreweryAPI.Services
{
    public class BreweriesService : IBreweriesService
    {
        ILibraryRepository _libraryRepository;
        private IMapper _mapper;

        private HashSet<string> allowedOrderByParameters = new HashSet<string>()
        {
            "id",
            "name",
            "country",
            "fundation-date"
            
        };

        public BreweriesService(ILibraryRepository libraryRepository, IMapper mapper)
        {
            _libraryRepository = libraryRepository;
            _mapper = mapper;
        }

        public BreweryModel CreateBrewery(BreweryModel breweryModel)
        {

            var breweryEntity = _mapper.Map<BreweryModel>(breweryModel);
            var returnedBreuery = _libraryRepository.CreateBrewery(breweryEntity);
            return _mapper.Map<BreweryModel>(returnedBreuery);
        }

        public DeleteModel DeleteBrewery(int breweryId)
        {
            var breweryToDelete = GetBrewery(breweryId);

            var result = _libraryRepository.DeleteBrewery(breweryId);

            if (result)
            {
                return new DeleteModel()
                {
                    IsSuccess = result,
                    Message = "The brewery was deleted."
                };
            }
            else
            {
                return new DeleteModel()
                {
                    IsSuccess = result,
                    Message = "The brewery was not deleted."
                };
            }

        }

        public IEnumerable<BreweryModel> GetBreweries(string orderBy="Id")
        {
            if (!allowedOrderByParameters.Contains(orderBy.ToLower()))
            {
                throw new BadRequestOperationException($"the field: {orderBy} is not supported, please use one of these {string.Join(",", allowedOrderByParameters)}");
            }

            var entityList = _libraryRepository.GetBreweries(orderBy);
            var modelList = _mapper.Map<IEnumerable<BreweryModel>>(entityList);
            return modelList;
        }

        public BreweryModel GetBrewery(int breweryId)
        {
            var brewery = _libraryRepository.GetBrewery(breweryId);
            if (brewery == null)
            {
                throw new NotFoundOperationException($"The brewery with id:{breweryId} does not exists");
            }

            return _mapper.Map<BreweryModel>(brewery);
        }

        public BreweryModel UpdateBrewery(int breweryId, BreweryModel breweryModel)
        {
            var breweryEntity = _mapper.Map<BreweryModel>(breweryModel);
            _libraryRepository.UpdateBrewery(breweryEntity);
            return breweryModel;
        }

        public IEnumerable<BreweryModel> FilterBreweryByCountry(string beerCountry)
        {
            //if (!allowedOrderByParameters.Contains(orderBy.ToLower()))
            //{
            //    throw new BadRequestOperationException($"the field: {orderBy} is not supported, please use one of these {string.Join(",", allowedOrderByParameters)}");
            //}

            var result = GetBreweries().Where(b => b.Country == beerCountry);
            return result;

        }

    }
}
