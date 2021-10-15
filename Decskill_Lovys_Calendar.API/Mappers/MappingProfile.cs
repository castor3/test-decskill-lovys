using AutoMapper;
using Decskill_Lovys_Calendar.API.ViewModels;
using Decskill_Lovys_Calendar.Domain.Entities;

namespace Decskill_Lovys_Calendar.API.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PostAvailabilityRequest, AvailabilityEntity>();
        }
    }
}