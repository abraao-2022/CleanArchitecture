﻿using AutoMapper;
using ClassLibrary1CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases.DeleteUser
{
    public sealed class DeleteUserMapper : Profile
    {
        public DeleteUserMapper()
        {
            CreateMap<DeleteUserRequest, User>();
            CreateMap<User, DeleteUserResponse>();
        }
    }
}