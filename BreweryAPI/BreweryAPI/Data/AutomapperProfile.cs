using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Data.Entities;
using BreweryAPI.Models;

namespace BreweryAPI.Data
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            this.CreateMap<BreweryEntity, BreweryModel>()
            .ReverseMap();


            this.CreateMap<BeerModel, BeerEntity>()
                .ReverseMap();
            //this.CreateMap<Camp, CampModel>()
            //  .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName))
            //  .ReverseMap();

            //this.CreateMap<Talk, TalkModel>()
            //  .ReverseMap()
            //  .ForMember(t => t.Camp, opt => opt.Ignore())
            //  .ForMember(t => t.Speaker, opt => opt.Ignore());
        }
    }
}
