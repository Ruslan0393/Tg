using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Domain.Models;
using Telegram.Service.Interfaces;
using Telegram.ViewModel.Message;

namespace Telegram.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IMessageService messageService;
        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }


        [HttpPost]
        public async Task<Message> Create(MessageCreateViewModel messageCreateView)
        {
            return await messageService.CreateAsync(messageCreateView);
        }



        [HttpGet]
        public async Task<IEnumerable<Message>> GetAllClients([FromQuery]long UserId)
        {
            return await messageService.GetAllAsync(p => p.UserId == UserId || p.ClientId == UserId);
        }

    }
}
