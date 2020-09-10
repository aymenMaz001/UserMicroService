using AutoMapper;
using Infrastructure.EFDataAcess.Entities;

namespace UserMicroService
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, Domain.User>();
            CreateMap<Information, Domain.Information>();
        }
    }
}
