using AutoMapper;
using Infrastructure.EFDataAcess.Entities;

namespace UserMicroService
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, Domain.User>();
            CreateMap<Domain.User, User>();
            CreateMap<Information, Domain.Information>();
            CreateMap<Domain.Information, Information>();
            CreateMap<Domain.Simulation, Simulation>();
            CreateMap<Simulation, Domain.Simulation>();
        }
    }
}
