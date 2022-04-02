using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Data.IRepository;
using Telegram.Domain.Common;
using Telegram.Domain.Models;
using Telegram.Service.Interfaces;
using Telegram.ViewModel.Friend;

namespace Telegram.Service.Services
{
    public class FriendService : IFriendService
    {
        private IFriendRepository _friendRepository;
        public FriendService(IFriendRepository friendRepository)
        {
            _friendRepository = friendRepository;
        }



        public async Task<Friend> CreateAsync(AddFriendViewModel model)
        {
            Friend friend = new Friend
            {
                FriendId = model.FriendId,
                UserId = model.UserId
            };
            return await _friendRepository.CreateAsynce(friend);
        }

        public async Task<bool> DeleteAsync(Expression<Func<Friend, bool>> expression)
        {
            return await _friendRepository.DeleteAsync(expression);
        }

        public async Task<IQueryable<Friend>> GetAllAsync(Expression<Func<Friend, bool>> expression = null)
        {
            return await _friendRepository.GetAllAsync(expression);
        }

        public async Task<Friend> GetAsync(Expression<Func<Friend, bool>> expression)
        {
            return await _friendRepository.GetAsync(expression);
        }

        public async Task<Friend> UpdateAsync(Friend friend)
        {
            return await _friendRepository.UpdateAsync(friend);
        }
    }
}
