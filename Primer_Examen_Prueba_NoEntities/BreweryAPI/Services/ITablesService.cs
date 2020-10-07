using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Primer_Examen.Models; 

namespace Primer_Examen.Services
{
     public interface ITablesService
    {
        IEnumerable<TableModel> GetTables(string orderBy);
        TableModel GetTable(int tableId);
        TableModel CreateTable(TableModel tableModel); 
        

        //IEnumerable<TableModel> FilterBreweryByCountry(string beerCountry);

        /*
              ////tables
        IEnumerable<TableModel> GetTables(string orderBy);
        TableModel GetTable(int tableId);
        TableModel CreateTable(TableModel TableModel);
     
        //bool InvalidateTable(TableModel TableModel);
        //void GetResult

        //IEnumerable<TableModel> FilterBreweryByCountry(string beerCountry);


        ////votes 
        VoteModel CreateVote(VoteModel beer);
        VoteModel GetVote(int voteId);
        IEnumerable<VoteModel> GetVotes(int tableId);
         */

    }
}
