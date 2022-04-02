using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Domain.Models;
using Telegram.Service.Interfaces;
using Telegram.ViewModel.User;

namespace Telegram.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("add_user")]
        public async Task<User> CreateUser(CreateUserViewModel user)
        {
            return await _userService.CreateAsync(user);
        }

        [HttpGet]
        [Route("get_from_phone_number")]
        public async Task<User> GetFromPhoneNumber(string phone)
        {
            return await _userService.GetAsync(p => p.PhoneNumber == phone);
        }

        [HttpGet]
        [Route("get")]
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet]
        [Route("get_name")]
        public async Task<IEnumerable<User>> GetUsersWithNameAsync([FromQuery]string name)
        {
            return await _userService.GetAllAsync(p => p.FirstName.ToLower() == name.ToLower());
        }


        [HttpGet]
        [Route("get_from_id")]
        public async Task<IEnumerable<User>> GetUsersFromIdAsync(long id)
        {
            return await _userService.GetAllAsync(p => p.Id == id);
        }

      

        [HttpGet]
        [Route("get/{id}")]
        public async Task<User> GetUserAsync(long id)
        {
            return await _userService.GetAsync(p => p.Id == id);
        }

   

    }
}
