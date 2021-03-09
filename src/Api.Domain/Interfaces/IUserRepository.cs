using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity> GetAsync(Guid id);
        Task<UserEntity> InsertAsync(UserEntity item);
        Task<UserEntity> UpdateAsync(UserEntity item);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<UserEntity>> GetAllAsync();
    }
}