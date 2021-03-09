using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using FireSharp;
using Api.Domain.Interfaces;
using Api.Data.Context.Interface;
using System.Text.Json;
using FireSharp.Response;
using Newtonsoft.Json.Linq;

namespace Api.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IFirebaseConnection _context;
        public UserRepository(IFirebaseConnection context)
        {
            _context = context;
        }
        
        public async Task<bool> DeleteAsync(string id)
        {
            try
            {
            var client = _context.Init();
            var response = await client.DeleteAsync($"/Usuarios/{id}");
            return true;
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }

        public async Task<IEnumerable<UserEntity>> GetAllAsync()
        {
            try
            {
            var client = _context.Init();
            var response = await client.GetAsync("/Usuarios");
            var users = JsonSerializer.Deserialize<List<UserEntity>>(response.Body);
            return users;
            }
            catch (Exception e)
            {
                throw e;
            }
          
        }
        public async Task<UserEntity> GetAsync(string id)
        {
            try
            {
            var client = _context.Init();
            var response = await client.GetAsync($"/Usuarios/{id}");
            var user = JsonSerializer.Deserialize<UserEntity>(response.Body.ToString());
            
            return user;
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }

        public async Task<UserEntity> InsertAsync(UserEntity item)
        {
            try
            {
            var client = _context.Init();
            PushResponse response = await client.PushAsync("/Usuarios", item);
            item.Id = response.Result.name;
            return item;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<UserEntity> UpdateAsync(string id,UserEntity item)
        {
            try
            {
                var client = _context.Init();
                var response = await client.UpdateAsync($"/Usuarios/{id}", item);
                var user = JsonSerializer.Deserialize<UserEntity>(response.Body.ToString());
                return user;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}