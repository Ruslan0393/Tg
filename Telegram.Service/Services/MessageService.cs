using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Data.IRepository;
using Telegram.Domain.Models;
using Telegram.Service.Interfaces;
using Telegram.ViewModel.Message;

namespace Telegram.Service.Services
{
    public class MessageService : IMessageService
    {
        private IMessageRepository _messageRepository;
        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }



        public async Task<Message> CreateAsync(MessageCreateViewModel messageView)
        {
            var message = new Message
            {
                Text = messageView.Text,
                ClientId = messageView.ClientId,
                UserId = messageView.UserId,
                Owner = messageView.Owner,
                CreatedDate = DateTime.Now
            };

            return await _messageRepository.CreateAsynce(message);
        }

        public async Task<bool> DeleteAsync(Expression<Func<Message, bool>> expression)
        {
            return await _messageRepository.DeleteAsync(expression);
        }

        public async Task<IQueryable<Message>> GetAllAsync(Expression<Func<Message, bool>> expression = null)
        {
            return await _messageRepository.GetAllAsync(expression);
        }

        public async Task<Message> GetAsync(Expression<Func<Message, bool>> expression)
        {
            return await _messageRepository.GetAsync(expression);
        }

        public async Task<Message> UpdateAsync(Message message)
        {
            return await _messageRepository.UpdateAsync(message);
        }

        
    }
}
