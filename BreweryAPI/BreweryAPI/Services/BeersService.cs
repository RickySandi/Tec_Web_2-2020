using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Data.Entities;
using BreweryAPI.Data.Repository;
using BreweryAPI.Exceptions;
using BreweryAPI.Models;

namespace BreweryAPI.Services
{
    public class BeersService : IBeersService
    {
        private IMapper _mapper;
        private ILibraryRepository _libraryRepository;

        public BeersService(IMapper mapper, ILibraryRepository libraryRepository)
        {
            _mapper = mapper;
            _libraryRepository = libraryRepository;
        }

        public BeerModel CreateBeer(int breweryId, BeerModel beer)
        {
            validateBrewery(breweryId);
            return _mapper.Map<BeerModel>(_libraryRepository.CreateBeer(_mapper.Map<BeerEntity>(beer)));
        }

        public bool DeleteBeer(int breweryId, int beerId)
        {
            GetBeer(breweryId, beerId);
            return _libraryRepository.DeleteBeer(beerId);
        }

        public BeerModel GetBeer(int breweryId, int beerId)
        {
            validateBrewery(breweryId); 
            validateBeer(beerId);
            return _mapper.Map<BeerModel>(_libraryRepository.GetBeer(beerId));
        }

        public IEnumerable<BeerModel> GetBeers(int breweryId)
        {
            validateBrewery(breweryId);
            return _mapper.Map<IEnumerable<BeerModel>>(_libraryRepository.GetBeers(breweryId));

        }

        public BeerModel UpdateBeer(int breweryId, int beerId, BeerModel beer)
        {
            GetBeer(breweryId, beerId);
            beer.Id = beerId;
            return _mapper.Map<BeerModel>(_libraryRepository.UpdateBeer(_mapper.Map<BeerEntity>(beer)));
        }

        private void validateBrewery(int breweryId)
        {
            var brewery = _libraryRepository.GetBeer(breweryId);
            if (brewery == null)
            {
                throw new NotFoundOperationException($"the brewery id:{breweryId}, does not exist");
            }
        }

        private void validateBeer(int beerId)
        {
            var beer = _libraryRepository.GetBeer(beerId);
            if (beer == null)
            {
                throw new NotFoundOperationException($"the beer id:{beerId}, does not exist");
            }
        }
        public IEnumerable<BeerModel> NotSoldBeers( int breweryId, int soldAmount)
        {
            validateBrewery(breweryId);
            return _mapper.Map<IEnumerable<BeerModel>>(_libraryRepository.GetBeers(breweryId).Where(b => b.soldAmount < 0));

        }





    }
}
