using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Domain.Models;
using Telegram.Service.Interfaces;
using Telegram.ViewModel.Friend;

namespace Telegram.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {

        private IFriendService _friendService;
        public FriendController(IFriendService friendService)
        {
            _friendService = friendService;
        }



        [HttpGet]
        public async Task<IEnumerable<Friend>> Get()
        {
            return await _friendService.GetAllAsync();
        }


        [HttpGet]
        [Route("my-friend")]
        public async Task<IEnumerable<Friend>> GetMyFriends(long id)
        {
            return await _friendService.GetAllAsync(p => p.UserId == id);
        }


        [HttpGet("{id}")]
        public async Task<Friend> GetAsync(long id)
        {
            return await _friendService.GetAsync(p => p.UserId == id);
        }

        [HttpPost]
        public async Task<Friend> Post([FromBody] AddFriendViewModel friend)
        {
            return await _friendService.CreateAsync(friend);
        }

      /*  [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }*/
    }
}
