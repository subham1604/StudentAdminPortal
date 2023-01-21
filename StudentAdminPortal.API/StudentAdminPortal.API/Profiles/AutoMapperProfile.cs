using AutoMapper;
using DataModels =  StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DataModels.Student,Student>()
                .ReverseMap();

            CreateMap<DataModels.Gender, Gender>()
              .ReverseMap();

            CreateMap<DataModels.Address, Address>()
              .ReverseMap();
        }
    }
}
