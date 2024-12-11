using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestForCreationDto>();
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestForUpdateDto>();
        }
    }
}
