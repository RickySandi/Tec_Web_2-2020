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
    public class TablesService : ITablesService
    {
        ILibraryRepository _libraryRepository;
        private IMapper _mapper;

        private HashSet<string> allowedOrderByParameters = new HashSet<string>()
        {
            "id",
            "from",
            "to",
            "number",
            "president"

        }; 

        public TablesService(ILibraryRepository libraryRepository, IMapper mapper)
        {
            _libraryRepository = libraryRepository;
            _mapper = mapper;
        }

        public TableModel CreateTable(TableModel TableModel)
        {

            var tableModel = _mapper.Map<TableModel>(TableModel);
            var returnedTable = _libraryRepository.CreateTable(tableModel);
            return _mapper.Map<TableModel>(returnedTable);
        }

    

        public IEnumerable<TableModel> GetTables(string orderBy="Id")
        {
            if (!allowedOrderByParameters.Contains(orderBy.ToLower()))
            {
                throw new BadRequestOperationException($"the field: {orderBy} is not supported, please use one of these {string.Join(",", allowedOrderByParameters)}");
            }

            var entityList = _libraryRepository.GetTables(orderBy);
            var modelList = _mapper.Map<IEnumerable<TableModel>>(entityList);
            return modelList;
        }

        public TableModel GetTable(int breweryId)
        {
            var brewery = _libraryRepository.GetTable(breweryId);
            if (brewery == null)
            {
                throw new NotFoundOperationException($"The brewery with id:{breweryId} does not exists");
            }

            return _mapper.Map<TableModel>(brewery);
        }

        public TableModel InvalidateTable(int tableId, TableModel tableModel)
        {
            var tableEntity = _mapper.Map<TableModel>(tableModel);
            _libraryRepository.InvalidateTable(tableEntity);
            return tableModel;

        }



        //public IEnumerable<TableModel> FilterBreweryByCountry(string beerCountry)
        //{
        //    //if (!allowedOrderByParameters.Contains(orderBy.ToLower()))
        //    //{
        //    //    throw new BadRequestOperationException($"the field: {orderBy} is not supported, please use one of these {string.Join(",", allowedOrderByParameters)}");
        //    //}

        //    var result = GetTables().Where(b => b.Country == beerCountry);
        //    return result;

        //}

    }
}
