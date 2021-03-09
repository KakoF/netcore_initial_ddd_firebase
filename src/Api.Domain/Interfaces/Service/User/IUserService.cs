using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Service.User
{
    public interface IUserService
    {
        Task<UserEntity> Get (Guid id);
        Task<IEnumerable<UserEntity>> GetAll ();
        Task<UserEntity> Post (UserEntity item);
        Task<UserEntity> Put (UserEntity item);
        Task<bool> Delete (Guid id);
    }
}