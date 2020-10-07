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
    public class VotesService : IVotesService
    {
        private IMapper _mapper;
        private ILibraryRepository _libraryRepository;

        public VotesService(IMapper mapper, ILibraryRepository libraryRepository)
        {
            _mapper = mapper;
            _libraryRepository = libraryRepository;
        }

        public VoteModel CreateVote(int tableId, VoteModel vote)
        {
            validateTable(tableId);
            return _mapper.Map<VoteModel>(_libraryRepository.CreateVote(_mapper.Map<VoteModel>(vote)));
        }

        

        public VoteModel GetVote(int tableId, int voteId)
        {
            validateTable(tableId); 
            validateVote(voteId);
            return _mapper.Map<VoteModel>(_libraryRepository.GetVote(voteId));
        }

        public IEnumerable<VoteModel> GetVotes(int tableId)
        {
            validateTable(tableId);
            return _mapper.Map<IEnumerable<VoteModel>>(_libraryRepository.GetVotes(tableId));

        }
       

        private int validateTable(int tableId)
        {
            var brewery = _libraryRepository.GetVote(tableId);
            if (brewery == null)
            {
                throw new NotFoundOperationException($"the brewery id:{tableId}, does not exist");
            }
            return tableId; 
        }

        private void validateVote(int voteId)
        {
            var vote = _libraryRepository.GetVote(voteId);
            if (vote == null)                               //|| vote.tableId == validateBrewery(tableId)
            {
                throw new NotFoundOperationException($"the vote id:{voteId}, does not exist");
            }
        }
        //public IEnumerable<VoteModel> NotSoldvotes( int tableId)
        //{
        //    validateVote(tableId);
        //    return _mapper.Map<IEnumerable<VoteModel>>(_libraryRepository.GetVotes(tableId).Where(b => b.soldAmount < 1));
   
        //}





    }
}
