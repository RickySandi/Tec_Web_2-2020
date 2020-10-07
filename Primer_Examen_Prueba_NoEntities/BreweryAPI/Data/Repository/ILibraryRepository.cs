using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Primer_Examen.Data.Entities;
using Primer_Examen.Models;

namespace Primer_Examen.Data.Repository
{
    public interface ILibraryRepository
    {
        ////tables
        IEnumerable<TableModel> GetTables(string orderBy);
        TableModel GetTable(int tableId);
        TableModel CreateTable(TableModel TableModel);

        bool InvalidateTable(TableModel tableModel); 

        //bool InvalidateTable(TableModel TableModel);
        //void GetResult

        //IEnumerable<TableModel> FilterBreweryByCountry(string beerCountry);


        ////votes 
        VoteModel CreateVote(VoteModel beer);
        VoteModel GetVote(int voteId);
        IEnumerable<VoteModel> GetVotes(int tableId);

        

       // IEnumerable<VoteModel> NotSoldBeers(); 


    }
}
