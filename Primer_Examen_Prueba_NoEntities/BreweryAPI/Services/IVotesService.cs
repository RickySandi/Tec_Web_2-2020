using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Primer_Examen.Models;

namespace Primer_Examen.Services
{
    public interface IVotesService
    {
        IEnumerable<VoteModel> GetVotes(int breweryId);
        VoteModel GetVote(int breweryId, int beerId);
        VoteModel CreateVote(int breweryId, VoteModel beer);
      
       // IEnumerable<VoteModel> NotSoldBeers(int breweryId);


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
