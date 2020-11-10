using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Primer_Examen.Data.Entities;
using Primer_Examen.Data.Repository;
using Primer_Examen.Exceptions;
using Primer_Examen.Models;


namespace Primer_Examen.Services
{
    public class ResultsService : IResultsService
    {
        ILibraryRepository _libraryRepository;
        private IMapper _mapper;

        private HashSet<string> allowedOrderByParameters = new HashSet<string>()
        {
            "id"


        };

        public ResultsService(ILibraryRepository libraryRepository, IMapper mapper)
        {
            _libraryRepository = libraryRepository;
            _mapper = mapper;
        }

        public IEnumerable<ResultsModel> GetResults(int resultId)
        {
            var entityList = _libraryRepository.GetResults(resultId);
            var modelList = _mapper.Map<IEnumerable<ResultsModel>>(entityList);
            return modelList;

        }


    }
}