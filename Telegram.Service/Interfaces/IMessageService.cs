using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Domain.Common;
using Telegram.Domain.Models;
using Telegram.ViewModel.Message;

namespace Telegram.Service.Interfaces
{
    public interface IMessageService
    {
        Task<Message> GetAsync(Expression<Func<Message, bool>> expression);
        Task<IQueryable<Message>> GetAllAsync(Expression<Func<Message, bool>> expression = null);
        Task<Message> CreateAsync(MessageCreateViewModel user);
        Task<bool> DeleteAsync(Expression<Func<Message, bool>> expression);
        Task<Message> UpdateAsync(Message user);
    }
}
