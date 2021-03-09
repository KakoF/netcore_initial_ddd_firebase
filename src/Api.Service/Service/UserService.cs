using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Service.User;

namespace Api.Service.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(string id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<UserEntity> Get(string id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
              return await _repository.GetAllAsync();
        }

        public async Task<UserEntity> Post(UserEntity item)
        {
            if(item.Nome == "Teste"){
                return null;
            }
             return await _repository.InsertAsync(item);
        }

        public async Task<UserEntity> Put(string id, UserEntity item)
        {
            return await _repository.UpdateAsync(id, item);
        }
    }
}