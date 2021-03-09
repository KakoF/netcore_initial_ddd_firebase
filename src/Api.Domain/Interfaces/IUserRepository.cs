using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity> GetAsync(string id);
        Task<UserEntity> InsertAsync(UserEntity item);
        Task<UserEntity> UpdateAsync(string id, UserEntity item);
        Task<bool> DeleteAsync(string id);
        Task<IEnumerable<UserEntity>> GetAllAsync();
    }
}