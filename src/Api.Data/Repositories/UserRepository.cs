using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using FireSharp;
using Api.Domain.Interfaces;
using Api.Data.Context.Interface;
using System.Text.Json;

namespace Api.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IFirebaseConnection _context;
        public UserRepository(IFirebaseConnection context)
        {
            _context = context;
        }
        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserEntity>> GetAllAsync()
        {
            try
            {
            var client = _context.Init();
            var response = await client.GetAsync("/Usuarios");
            var users = JsonSerializer.Deserialize<List<UserEntity>>(response.Body.ToString());
            return users;
            }
            catch (Exception e)
            {
                
                throw e;
            }
          
        }
        public Task<UserEntity> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> InsertAsync(UserEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> UpdateAsync(UserEntity item)
        {
            throw new NotImplementedException();
        }
    }
}