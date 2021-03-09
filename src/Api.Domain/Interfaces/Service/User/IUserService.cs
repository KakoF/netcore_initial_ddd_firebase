using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Service.User
{
    public interface IUserService
    {
        Task<UserEntity> Get (string id);
        Task<IEnumerable<UserEntity>> GetAll ();
        Task<UserEntity> Post (UserEntity item);
        Task<UserEntity> Put (string id, UserEntity item);
        Task<bool> Delete (string id);
    }
}