using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Primer_Examen.Data.Entities;
using Primer_Examen.Models;

namespace Primer_Examen.Data.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private List<TableModel> tables = new List<TableModel>
        {
            new TableModel(){ Id = 1, From = 'A', To = 'K', Number = 1, President="Presidente 1"},
            new TableModel(){ Id = 2, From = 'L', To = 'Z', Number = 2, President="Presidente 2"}



        };

        private List<VoteModel> votes = new List<VoteModel>
        {
            new VoteModel(){ Id = 1, PartyA = true, PartyB = false, PartyC = false, Name="Votante 1", tableId =1 },  //A
            new VoteModel(){ Id = 2, PartyA = false, PartyB = true, PartyC = false, Name="Votante 2", tableId =1 },  //B

            new VoteModel(){ Id = 3, PartyA = false, PartyB = false, PartyC = false, Name="Votante 3", tableId =2 },  //Blank
            new VoteModel(){ Id = 4, PartyA = true, PartyB = true, PartyC = false, Name="Votante 4", tableId =2 }    //Null


        };

   

        // tables
        public TableModel CreateTable(TableModel table)
        {
            int newId;
            if (tables.Count == 0)
            {
                newId = 1;
            }
            else
            {
                newId = tables.OrderByDescending(b => b.Id).FirstOrDefault().Id + 1;
            }

            table.Id = newId;

            tables.Add(table);
            return table;
        }

  

        public IEnumerable<TableModel> GetTables(string orderBy)
        {
            switch (orderBy)
            {
                case "id":
                    return tables.OrderBy(c => c.Id);
                case "from":
                    return tables.OrderBy(c => c.From);
                case "to":
                    return tables.OrderBy(c => c.To);
                case "number":
                    return tables.OrderBy(c => c.Number);
                case "president":
                    return tables.OrderBy(c => c.President);

                default:
                    return tables.OrderBy(c => c.Id); ;
            }
        }

        public TableModel GetTable(int tableId)
        {
            return tables.FirstOrDefault(b => b.Id == tableId);
        }

        public bool InvalidateTable(TableModel tableModel)
        {
            var tableToInvalidate = GetTable(tableModel.Id); 

                tableToInvalidate.Id = 0;
                tableToInvalidate.From = ' ';
                tableToInvalidate.To = ' ';
                tableToInvalidate.Number = 0;
                tableToInvalidate.President = " ";


            return true; 
        }



        //votes
        public VoteModel CreateVote(VoteModel vote)
        {
            int newId;
            var lastVote = votes.OrderByDescending(v => v.Id).FirstOrDefault();
            if (lastVote == null)
            {
                newId = 1;
            }
            else
            {
                newId = lastVote.Id + 1;
            }
            vote.Id = newId;
            vote.Name = " "; //eliminando nombre del votante para endpoint 2 
            votes.Add(vote);
            return vote;
        }

        public VoteModel GetVote(int voteId)
        {
            return votes.FirstOrDefault(v => v.Id == voteId);
        }

        public IEnumerable<VoteModel> GetVotes(int tableId)
        {
            return votes.Where(v => v.tableId == tableId);
        }

    

        //public IEnumerable<TableModel> FilterBreweryByCountry(string beerCountry)
        //{
        //    return tables.Where(b => b.Country == beerCountry); 
        //}

        //public IEnumerable<VoteModel> NotSoldvotes()
        //{
        //    return votes.Where(b => b.soldAmount < 1); 
        //}
    }

    


}

