using AutoMapper;
using ClassLibrary1CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases.GetAllUser
{
    public sealed class GetAllUserMapper : Profile
    {
        public GetAllUserMapper()
        {
            CreateMap<User, GetAllUserResponse>();
        }
    }
}