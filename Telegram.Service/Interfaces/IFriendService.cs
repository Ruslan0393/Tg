using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Domain.Common;
using Telegram.Domain.Models;
using Telegram.ViewModel.Friend;

namespace Telegram.Service.Interfaces
{
    public interface IFriendService
    {
        Task<Friend> GetAsync(Expression<Func<Friend, bool>> expression);
        Task<IQueryable<Friend>> GetAllAsync(Expression<Func<Friend, bool>> expression = null);
        Task<Friend> CreateAsync(AddFriendViewModel model);
        Task<bool> DeleteAsync(Expression<Func<Friend, bool>> expression);
        Task<Friend> UpdateAsync(Friend model);
    }
}
