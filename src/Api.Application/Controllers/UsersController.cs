using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Service.User;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                
               return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("{id}", Name="GetWithId")]
        public async Task<ActionResult> Get(string id)
        {
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                
               return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                
               return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserEntity user)
        {
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Post(user);
                if(result.Nome != null){
                   return Created(new Uri(Url.Link("GetWithId", new{id = result.Id})), result);
                }else{
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                
               return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpPut]
         [Route("{id}")]
        public async Task<ActionResult> Post(string id, [FromBody] UserEntity user)
        {
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Put(id, user);
                if(result.Nome != null){
                   return Created(new Uri(Url.Link("GetWithId", new{id = result.Id})), result);
                }else{
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                
               return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}